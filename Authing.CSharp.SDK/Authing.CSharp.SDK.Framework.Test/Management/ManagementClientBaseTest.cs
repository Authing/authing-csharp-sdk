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
        protected string UserTwoId = "61c17bd024917805ae85e397";

        [SetUp]
        public void Setup()
        {
            ManagementClientOptions options = new ManagementClientOptions()
            {
                AccessKeyId = "613189b2eed393affbbf396e",
                AccessKeySecret = "AUTHING_SECRET"
            };

            managementClient = new ManagementClient(options);

            dateTimeService = new DateTimeService();
        }
    }
}
