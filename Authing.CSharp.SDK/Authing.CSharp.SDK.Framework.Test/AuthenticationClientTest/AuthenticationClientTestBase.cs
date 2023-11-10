using NUnit.Framework;
using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Services;


namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class AuthenticationClientTestBase
    {
        protected AuthenticationClient client;

        private string appId = "64d5f75a31a9c7c81bae7627";
        private string appSecret = "162e97160cf15a486f04e7cef1fd623c";
        private string domain = "https://qidongtest.test2.authing-inc.co";
        private string redirectUri = "http://localhost:44300/auth/callback";

        [OneTimeSetUp]
        public void SetupClient()
        {
            client = new AuthenticationClient(new AuthenticationClientInitOptions
            {
                AppId = "64d5f75a31a9c7c81bae7627",
                AppSecret = "162e97160cf15a486f04e7cef1fd623c",
                RedirectUri = "https://console.authing.cn/console/get-started/64d5f75a31a9c7c81bae7627",
                AppHost = @"https://sdktest.authing.cn",
            });
        }
    }



}
