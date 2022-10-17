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
                AppId = "AUTHING_APP_ID",
                AppSecret = "AUTHING_SECRET",
                RedirectUri = "AUTHING_REDIRECTURI",
                Host = @"AUTHING_HOST",
            });


        }

    }
}
