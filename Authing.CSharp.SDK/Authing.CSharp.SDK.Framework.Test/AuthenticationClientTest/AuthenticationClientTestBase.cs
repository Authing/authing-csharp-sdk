using NUnit.Framework;
using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Services;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class AuthenticationClientTestBase
    {       
        protected AuthenticationClient client;

        [SetUp]
        public void SetupClient()
        {
            client = new AuthenticationClient(new AuthenticationClientInitOptions
            {
                //AppId = "61e5157ea18c245048770546",
                //AppSecret = "325d96c907a989b9f6b67584e1632909",
                //Domain = @"https://authinglogindemo.authing.cn",
                //RediretUri = loginCallbackUrl,
                AppId = "62fcabb3a4ac8fdd84c5c72b",
                AppSecret = "57380da65c82d6b4c3f54347709d77de",
                Domain = @"https://ehjnacmkjhjj-demo.mysql.authing-inc.co",
                Host = @"https://console.test.authing-inc.co",
                RediretUri = "https://console.mysql.authing-inc.co/console/get-started/62fca2e367113211c9a310a7",
            });
        }

    }
}
