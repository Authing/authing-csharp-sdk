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
            ManagementClientOptions options = new ManagementClientOptions()
            {
                AccessKeyId = "AUTHING_USERPOOL_ID",
                AccessKeySecret = "AUTHING_SECRET"
            };



            managementClient = new ManagementClient(options);

            dateTimeService = new DateTimeService();
        }
    }
}
