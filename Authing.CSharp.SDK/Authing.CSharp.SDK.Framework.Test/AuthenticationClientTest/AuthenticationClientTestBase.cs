using NUnit.Framework;
using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Services;


namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class AuthenticationClientTestBase
    {
        protected AuthenticationClient client;

        private string appId = "613189b38b6c66cac1d211bd";
        private string appSecret = "33a067dbebb9195af3702fe9a5d29e84";
        private string domain = "https://qidongtest.test2.authing-inc.co";
        private string redirectUri = "http://localhost:44300/auth/callback";

        [OneTimeSetUp]
        public void SetupClient()
        {
            client = new AuthenticationClient(new AuthenticationClientInitOptions
            {
                AppId = "613189b38b6c66cac1d211bd",
                AppSecret = "33a067dbebb9195af3702fe9a5d29e84",
                RedirectUri = "http://localhost:44300/auth/callback",
                AppHost = @"https://ehazzd-demo.authing.cn",
            });
        }
    }



}
