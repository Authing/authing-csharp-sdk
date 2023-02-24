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
                AccessKeyId = "63f60a8e31e6ebd92080dc7d",
                AccessKeySecret = "00711487506bc4a92cfada3520b76d7f",
                WebsocketUri = "wss://events.hydra.authing-inc.co",
                
            };



            managementClient = new ManagementClient(options);

        }

        [Test]
        public void SubTest()
        {
            try
            {
                managementClient.Sub("authing.user.updated", message =>
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

        [Test]
        public void PubTest()
        { 
            //managementClient.PubEvent("")
        }
    }
}
