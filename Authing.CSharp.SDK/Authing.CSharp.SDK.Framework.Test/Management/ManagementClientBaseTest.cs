using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Services;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.UtilsImpl;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test
{
    public class ManagementClientBaseTest
    {
        protected ManagementClient managementClient;

        protected IDateTimeService dateTimeService;

        protected string UserOneId = "629487c14604f5ca85cbff80";

        public ManagementClientBaseTest()
        {
            //ManagementClientOptions options = new ManagementClientOptions()
            //{
            //    AccessKeyId = "AUTHING_USERPOOL_ID",
            //    AccessKeySecret = "AUTHING_SECRET"
            //};

            ManagementClientOptions options = new ManagementClientOptions()
            {
                AccessKeyId = "63a94268af567d1008a91fd2",
                AccessKeySecret = "32d1a8b39b2e956c69df7cff5b78c04e"
            };

            managementClient = new ManagementClient(options);

            dateTimeService = new DateTimeService();
        }
    }
}
