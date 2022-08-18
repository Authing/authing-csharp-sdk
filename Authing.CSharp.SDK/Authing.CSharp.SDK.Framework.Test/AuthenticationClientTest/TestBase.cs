using NUnit.Framework;
using Authing.CSharp.SDK.Models.Authentication;
using Authing.CSharp.SDK.Services;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    public class TestBase
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
                AppId = "62fde0d10a9d1d7388468e46",
                AppSecret = "5f6c3b9b47973bf872ba6762496b9b32",
                Domain = @"https://oijakpbocgfn-demo.test.authing-inc.co",
                Host = @"https://console.test.authing-inc.co",
                RediretUri = "https://console.test.authing-inc.co/console/get-started/62fde0d10a9d1d7388468e46",
            });
        }

    }
}
