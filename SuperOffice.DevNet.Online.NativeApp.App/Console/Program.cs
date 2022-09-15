using IdentityModel;
using IdentityModel.OidcClient;
using Serilog;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;

namespace nativeapp.console
{
    class Program
    {

        // *************************************************************************************************
        // **** SuperOffice settings ***********************************************************************
        // *************************************************************************************************
        private static string _systemUserToken = Settings.SystemUserToken;
        private static string _customerId = Settings.TenantId;
        private static string _clientId = Settings.ClientId;
        private static string _clientSecret = Settings.ClientSecret;
        private static string _authority = "https://sod.superoffice.com/login/";
        // *************************************************************************************************
        // *************************************************************************************************
        // *************************************************************************************************

        static OidcClient _oidcClient;

        public static void Main(string[] args) => MainAsync().GetAwaiter().GetResult();

        public static async Task MainAsync()
        {
            Console.WriteLine("+-----------------------+");
            Console.WriteLine("|  Sign in with OIDC    |");
            Console.WriteLine("+-----------------------+");
            Console.WriteLine("");
            Console.WriteLine("Press any key to sign in...");
            Console.ReadKey();

            await Login();
        }

        private static async Task Login()
        {
            // create a redirect URI using an available port on the loopback address.
            // requires the OP to allow random ports on 127.0.0.1 - otherwise set a static port
            var browser = new SystemBrowser();
            string redirectUri = string.Format($"http://127.0.0.1:{browser.Port}");

            var options = new OidcClientOptions
            {
                Authority = _authority,
                ClientId = _clientId,

                ClientSecret = _clientSecret,
                RedirectUri = redirectUri,

                Scope = "openid",
                FilterClaims = false,
                LoadProfile = false,
                Browser = browser,
            };

            var serilog = new LoggerConfiguration()
                 .MinimumLevel.Verbose()
                 .Enrich.FromLogContext()
                 .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message}{NewLine}{Exception}{NewLine}")
                 .CreateLogger();

            options.LoggerFactory.AddSerilog(serilog);

            _oidcClient = new OidcClient(options);
            _oidcClient.Options.Policy.ValidateTokenIssuerName = false;
            _oidcClient.Options.Policy.Discovery.ValidateIssuerName = false;
            var result = await _oidcClient.LoginAsync(new LoginRequest());

            ShowResult(result);
            await NextSteps(result);
        }

        private static void ShowResult(LoginResult result)
        {
            if (result.IsError)
            {
                Console.WriteLine("\n\nError:\n{0}", result.Error);
                return;
            }

            Console.WriteLine("\n\nClaims:");
            foreach (var claim in result.User.Claims)
            {
                Console.WriteLine("{0}: {1}", claim.Type, claim.Value);
            }

            Console.WriteLine($"\nidentity token: {result.IdentityToken}");
            Console.WriteLine($"\naccess token:   {result.AccessToken}");
            Console.WriteLine($"\nrefresh token:  {result?.RefreshToken ?? "none"}");


        }

        private static string currentAccessToken = string.Empty;
        private static string currentRefreshToken = string.Empty;
        private static string webApiUrl = string.Empty;

        private static async Task NextSteps(LoginResult result)
        {
            currentAccessToken = result.AccessToken;
            currentRefreshToken = result.RefreshToken;
            webApiUrl = result.User.Claims.Where(c => c.Type.Contains("webapi_url", StringComparison.InvariantCultureIgnoreCase)).Select(c => c.Value).FirstOrDefault();

            var menu = "  x...exit  c...call api   ";
            if (currentRefreshToken != null) menu += "r...refresh token   ";

            while (true)
            {
                Console.WriteLine("\n\n");

                Console.Write(menu);
                var key = Console.ReadKey();

                if (key.Key == ConsoleKey.X) return;
                if (key.Key == ConsoleKey.C) await CallApi(webApiUrl, currentAccessToken);
                if (key.Key == ConsoleKey.R)
                {
                    var refreshResult = await _oidcClient.RefreshTokenAsync(currentRefreshToken);
                    if (refreshResult.IsError)
                    {
                        Console.WriteLine($"Error: {refreshResult.Error}");
                    }
                    else
                    {
                        currentRefreshToken = refreshResult.RefreshToken;
                        currentAccessToken = refreshResult.AccessToken;

                        Console.WriteLine("\n\n");
                        Console.WriteLine($"access token:   {refreshResult.AccessToken}");
                        Console.WriteLine($"refresh token:  {refreshResult?.RefreshToken ?? "none"}");
                    }
                }
            }
        }

        private static async Task CallApi(string baseUrl, string accessToken)
        {
            HttpClientHandler handler = new HttpClientHandler() { UseDefaultCredentials = false };
            var client = new HttpClient(handler);

            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            try
            {
                var contactResponse = await client.PostAsync($"v1/Agents/Contact/GetMyContact", new StringContent(""));
                
                var json = await contactResponse.Content.ReadAsStringAsync();
                var contact = JsonSerializer.Deserialize<Contact>(json);

                Console.WriteLine();
                Console.WriteLine($"Name: {contact.Name}");
                Console.WriteLine($"Dept: {contact.Department}");
                Console.WriteLine($"Desc: {contact?.Description}");


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Console.WriteLine("Leaving CallApi...");
            }

        }
    }
}
