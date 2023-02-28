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
    public class ManagementSubTest 
    {
        protected ManagementClient managementClient;


        protected string UserOneId = "629487c14604f5ca85cbff80";

        public ManagementSubTest()
        {
            ManagementClientOptions options = new ManagementClientOptions()
            {
                AccessKeyId = "63fd7782ee75e3eea7fc9049",
                AccessKeySecret = "863c653f1c5c67a707138c19be403691",
                Host = "https://core.hydra.authing-inc.co",
                WebsocketUri = "wss://events.hydra.authing-inc.co",

            };

            //ManagementClientOptions options = new ManagementClientOptions()
            //{
            //    AccessKeyId = "613189b2eed393affbbf396e",
            //    AccessKeySecret = "ccf4951a33e5d54d64e145782a65f0a7",
            //    WebsocketUri = "wss://events.hydra.authing-inc.co",
            //};

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
        public async Task PubTest()
        {
            try
            {
                var users= await managementClient.ListUsers(new ListUsersRequestDto { });

                var result= await managementClient.PubEvent(new EventRequestDto { EventType = "authing.user.updated", EventData = "[{\"username\":\"qidong\",\"password\":\"123456\"},{\"username\":\"qidong\",\"password\":\"123456\"}]" });
            }
            catch (Exception exp)
            { 
            
            }
        }
    }
}
