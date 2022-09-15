using IdentityModel.OidcClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfWebView2;

namespace SuperOffice.DevNet.Online.Wpf.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var options = new OidcClientOptions()
            {
                Authority = "https://sod.superoffice.com/login/",
                ClientId = "db1834037c58c02b6bd9898feef19845",
                Scope = "openid",
                RedirectUri = "http://127.0.0.1:8888",
                Browser = new WpfEmbeddedBrowser(),
                Policy = new Policy
                {
                    RequireIdentityTokenSignature = false,
                    ValidateTokenIssuerName = false,
                },
                LoadProfile = false
            };

            var _oidcClient = new OidcClient(options);
            _oidcClient.Options.Policy.Discovery.ValidateIssuerName = false;

            LoginResult loginResult;
            try
            {
                loginResult = await _oidcClient.LoginAsync();
            }
            catch (Exception exception)
            {
                txbMessage.Text = $"Unexpected Error: {exception.Message}";
                return;
            }

            if (loginResult.IsError)
            {
                txbMessage.Text = loginResult.Error == "UserCancel" ? "The sign-in window was closed before authorization was completed." : loginResult.Error;
            }
            else
            {
                var sb = new StringBuilder(128);
                foreach (var claim in loginResult.User.Claims)
                {
                    sb.AppendLine($"{claim.Type}: {claim.Value}");
                }

                if (!string.IsNullOrWhiteSpace(loginResult.RefreshToken))
                {
                    sb.AppendLine();
                    sb.AppendLine($"refresh token: {loginResult.RefreshToken}");
                }

                if (!string.IsNullOrWhiteSpace(loginResult.IdentityToken))
                {
                    sb.AppendLine();
                    sb.AppendLine($"identity token: {loginResult.IdentityToken}");
                }

                if (!string.IsNullOrWhiteSpace(loginResult.AccessToken))
                {
                    sb.AppendLine();
                    sb.AppendLine($"access token: {loginResult.AccessToken}");
                }
                txbMessage.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;

                txbMessage.Text = sb.ToString();
            }
        }
    }
}
