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
        /// <summary>
        /// 2022-10-20 测试成功
        /// 创建 Pipeline 函数
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreatePipelineFunctionTest()
        {
            var res = await managementClient.CreatePipelineFunction(new CreatePipelineFunctionDto
            {
                FuncName = "每周日凌晨 3-6 点系统维护禁止注册/登录",
                FuncDescription = "每周日凌晨 3-6 点系统维护禁止注册/登录。",
                Scene = CreatePipelineFunctionDto.scene.PRE_REGISTER,
                SourceCode = "async function pipe(user, context, callback) {\n  const date = new Date();\n  const d = date.getDay();\n  const n = date.getHours();\n  " +
                             "// 每周日凌晨 3-6 点禁止注册\n  if (d === 0 && (3 <= n && n <= 6)) " +
                             "{\n    return callback(new Error('系统维护中，暂时停止注册！'));\n  }\n  " +
                             "callback(null, user, context)\n}",
                Timeout = 10,
            });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取 Pipeline 函数列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListPipelineFunctionsTest()
        {
            var res = await managementClient.ListPipelineFunctions(new ListPipelineFunctionDto { });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取 Pipeline 函数详情
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetPipelineFunctionTest()
        {
            var res1 = await managementClient.ListPipelineFunctions(new ListPipelineFunctionDto { });
            var target = res1.Data.List.First();
            var res = await managementClient.GetPipelineFunction(new GetPipelineFunctionDto { FuncId = target.FuncId });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 重新上传 Pipeline 函数
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ReuploadPipelineFunctionTest()
        {
            var res1 = await managementClient.ListPipelineFunctions(new ListPipelineFunctionDto { });
            var target = res1.Data.List.First();
            var res = await managementClient.ReuploadPipelineFunction(new ReUploadPipelineFunctionDto() { FuncId = target.FuncId });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 修改 Pipeline 函数
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdatePipelineFunctionTest()
        {
            var res1 = await managementClient.ListPipelineFunctions(new ListPipelineFunctionDto { });
            var target = res1.Data.List.First();
            var res = await managementClient.UpdatePipelineFunction(new UpdatePipelineFunctionDto() { FuncId = target.FuncId, Timeout = 20 });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 修改 Pipeline 函数顺序
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdatePipelineOrderTest()
        {
            var res1 = await managementClient.ListPipelineFunctions(new ListPipelineFunctionDto { });
            var target = res1.Data.List.First();
            var res2 = await managementClient.UpdatePipelineOrder(new UpdatePipelineOrderDto
            {
                Scene = UpdatePipelineOrderDto.scene.PRE_REGISTER,
                Order = new List<string>() { target.FuncId }
            });
            Assert.AreEqual(200, res2.StatusCode);
        }


        /// <summary>
        /// 2022-10-20 测试成功
        /// 删除 Pipeline 函数
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeletePipelineFunctionTest()
        {
            var res1 = await managementClient.ListPipelineFunctions(new ListPipelineFunctionDto { });
            var target = res1.Data.List.First();
            var res2 = await managementClient.DeletePipelineFunction(new DeletePipelineFunctionDto
            {
                FuncId = target.FuncId
            });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-20 测试成功
        /// 获取 Pipeline 日志
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetPipelineLogsTest()
        {
            var res1 = await managementClient.ListPipelineFunctions(new ListPipelineFunctionDto { });
            var target = res1.Data.List.First();
            var res2 = await managementClient.GetPipelineLogs(new GetPipelineLogsDto
            {
                FuncId = target.FuncId
            });
            Assert.AreEqual(200, res2.StatusCode);
        }
    }
}
