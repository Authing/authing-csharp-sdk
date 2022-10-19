using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    internal class PipelineManagementTest : ManagementClientBaseTest
    {
        [Test]
        public async Task CreatePipelineFunctionTest()
        {
            var dto = await managementClient.CreatePipelineFunction(new CreatePipelineFunctionDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetPipelineFunctionTest()
        {
            var dto = await managementClient.GetPipelineFunction(new GetPipelineFunctionDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task ReuploadPipelineFunctionTest()
        {
            var dto = await managementClient.ReuploadPipelineFunction(new ReUploadPipelineFunctionDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task UpdatePipelineFunctionTest()
        {
            var dto = await managementClient.UpdatePipelineFunction(new UpdatePipelineFunctionDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task UpdatePipelineOrderTest()
        {
            var dto = await managementClient.UpdatePipelineOrder(new UpdatePipelineOrderDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task DeletePipelineFunctionTest()
        {
            var dto = await managementClient.DeletePipelineFunction(new DeletePipelineFunctionDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task ListPipelineFunctionsTest()
        {
            var dto = await managementClient.ListPipelineFunctions(new ListPipelineFunctionDto { });
            Assert.NotNull(dto);
        }

        [Test]
        public async Task GetPipelineLogsTest()
        {
            var dto = await managementClient.GetPipelineLogs(new  GetPipelineLogsDto { });
            Assert.NotNull(dto);
        }
    }
}
