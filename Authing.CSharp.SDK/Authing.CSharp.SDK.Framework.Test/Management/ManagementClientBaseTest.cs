using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Models.Management;
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
        protected string UserTwoId = "61c17bd024917805ae85e397";

        [SetUp]
        public void Setup()
        {
            //ManagementClientOptions options = new ManagementClientOptions()
            //{
            //    AccessKeyId = "AUTHING_USERPOOL_ID",
            //    AccessKeySecret = "AUTHING_SECRET"
            //};

            ManagementClientOptions options = new ManagementClientOptions()
            {
                AccessKeyId = "62a992126012453b7788fa86",
                AccessKeySecret = "21ae6cee713f68c58ac80f30309a767b",
                Host= "https://console.pre.authing.cn"
            };

            managementClient = new ManagementClient(options);

            dateTimeService = new DateTimeService();
        }
    }
}
