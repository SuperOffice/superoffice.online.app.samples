using IdentityModel.OidcClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinFormsWebView2
{
    public partial class Form1 : Form
    {
        OidcClient _oidcClient;

        public Form1()
        {
            InitializeComponent();

            var options = new OidcClientOptions
            {
                Authority = "https://sod.superoffice.com/login/",
                ClientId = "db1834037c58c02b6bd9898feef19845",
                Scope = "openid",
                RedirectUri = "http://127.0.0.1:8888",
                Browser = new WinFormsWebView("Authenticating ...", 1024, 768),
                LoadProfile = false
            };
            _oidcClient = new OidcClient(options);
            _oidcClient.Options.Policy.Discovery.ValidateIssuerName = false;

            Login();
        }

        private async void Login()
        {
            LoginResult loginResult;

            try
            {
                loginResult = await _oidcClient.LoginAsync();
            }
            catch (Exception exception)
            {
                Output.Text = $"Unexpected Error: {exception.Message}";
                return;
            }


            if (loginResult.IsError)
            {
                MessageBox.Show(this, loginResult.Error, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                Output.Text = sb.ToString();
            }
        }
    }
}