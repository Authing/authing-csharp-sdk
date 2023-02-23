using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    public class ManagementSubTest : ManagementClientBaseTest
    {
        protected ManagementClient managementClient;


        protected string UserOneId = "629487c14604f5ca85cbff80";

        public ManagementSubTest()
        {
            ManagementClientOptions options = new ManagementClientOptions()
            {
                AccessKeyId = "63bb8382e310sss0a366d5fc",
                AccessKeySecret = "qidong5566",
                WebsocketUri = "ws://sxy21.cn:30301/events",
                
            };



            managementClient = new ManagementClient(options);

        }

        [Test]
        public void SubTest()
        {
            try
            {
                managementClient.Sub("authing.test.event", message =>
                {
                    Console.WriteLine(message);
                }, error =>
                {

                });

                while (true)
                {
                   
                }
            }
            catch (Exception exp)
            { 
                
            }
           
        }
    }
}
