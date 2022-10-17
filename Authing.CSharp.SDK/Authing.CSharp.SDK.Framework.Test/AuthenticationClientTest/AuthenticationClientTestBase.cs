using NUnit.Framework;
using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Services;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class AuthenticationClientTestBase
    {
        protected AuthenticationClient client;

        private string appId = "634cf98aa5b1455a52949d33";
        private string appSecret = "327cdf9cc9cd7f738262f019b05b174d";
        private string domain = "https://qidongtest.test2.authing-inc.co";
        private string redirectUri = "https://www.baidu.com";
        private string host = "https://console.test2.authing-inc.co/";

        [SetUp]
        public void SetupClient()
        {
            //client = new AuthenticationClient(new AuthenticationClientInitOptions
            //{
            //    AppId = "AUTHING_APP_ID",
            //    AppSecret = "AUTHING_SECRET",
            //    RedirectUri = "AUTHING_REDIRECTURI",
            //    Host = @"AUTHING_HOST",
            //});

            client = new AuthenticationClient(new AuthenticationClientInitOptions
            {
                AppId = appId,
                AppSecret = appSecret,
                RedirectUri = redirectUri,
                Host = host,
            });
        }

    }
}
