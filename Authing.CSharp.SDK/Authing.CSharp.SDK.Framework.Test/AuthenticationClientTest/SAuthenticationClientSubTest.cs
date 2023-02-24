using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class SAuthenticationClientSubTest
    {
        protected AuthenticationClient client;

        [OneTimeSetUp]
        public void SetupClient()
        {
            client = new AuthenticationClient(new AuthenticationClientInitOptions
            {
                AppId = "63f46b89989965fea854adb3",
                AppSecret = "6d32fcb07096247d3e9a2398168778e7",
                RedirectUri = "http://localhost:44302/auth/callback",
                AppHost = @"https://caslogindemo.authing.cn",
                WebsocketUri="f"
            });
        }

        [Test]
        public async Task SubTest()
        {
           await client.signUpByUsernamePassword("", "");

            client.Sub("authing.user.updated", message =>
            {
                Console.WriteLine(message);
            }, error =>
            {

            });

            while (true)
            {

            }
        }
    }
}
