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
                AppId = "63fd7782259987d15878d8cb",
                AppSecret = "5e94a572c2c1a2ee4970ec1b4e1945c3",
                RedirectUri = "https://console.hydra.authing-inc.co/console/get-started/63fd7782259987d15878d8cb",
                AppHost = @"https://jkhsm95le5h7-demo.hydra.authing-inc.co",
                WebsocketUri = "wss://events.hydra.authing-inc.co"
            });
        }

        [Test]
        public async Task SubTest()
        {
            try
            {
                var loginResult = await client.SignInByUsernamePassword("qidong5566", "3866364");

                client.setAccessToken(loginResult.Data.Access_token);
            }
            catch (Exception exp)
            {

            }

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

        [Test]
        public async Task PubTest()
        {
            try
            {
                var loginResult = await client.SignInByUsernamePassword("qidong5566", "3866364");

                client.setAccessToken(loginResult.Data.Access_token);

                await client.PubEvent("authing.user.updated", "[{\"username\":\"qidong\",\"password\":\"123456\"},{\"username\":\"qidong\",\"password\":\"123456\"}]");
            }
            catch (Exception exp)
            {

            }

        }
    }
}
