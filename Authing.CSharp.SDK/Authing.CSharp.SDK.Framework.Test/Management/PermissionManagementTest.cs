using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    internal class PermissionManagementTest:ManagementClientBaseTest
    {
        [Test]
        public async Task createPermissionNamespace()
        {
           var result= await managementClient.CreatePermissionNamespace(new CreatePermissionNamespaceDto 
           {
            Name="examplePer"
           });
        }
    }
}
