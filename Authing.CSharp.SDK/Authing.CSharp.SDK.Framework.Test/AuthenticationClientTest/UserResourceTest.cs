using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.AuthenticationClientTest
{
    internal class UserResourceTest : AuthenticationClientTestBase
    {
        private async Task<LoginTokenRespDto> Login()
        {
            LoginByCredentialsDto loginDto = new LoginByCredentialsDto { };
            loginDto.Connection = Connection.PASSWORD;
            loginDto.PasswordPayload = new PasswordPayload
            {
                UserName = "qidong1122",
                Password = "3866364"
            };

            LoginTokenRespDto loginTokenRespDto = await client.Signin(loginDto);

            return loginTokenRespDto;
        }

        /// <summary>
        /// 测试获取登录日志
        /// 2022-9-8 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetLoginHistoryTest()
        {
            var loginResult = await Login();
            Assert.NotNull(loginResult);

            var loginHistory = await client.GetLoginHistory(null);

            Assert.NotNull(loginHistory);
        }

        /// <summary>
        /// 测试获取登录应用
        /// 2022-9-8 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetLoggedInAppsTest()
        {
            var loginResult = await Login();
            Assert.NotNull(loginResult);

            var loggedApps = await client.GetLoggedInApps();

            Assert.NotNull(loggedApps);
        }

        /// <summary>
        /// 测试获取具备访问权限的应用
        /// 2022-9-8 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAccessibleAppsTest()
        {
            var loginResult = await Login();
            Assert.NotNull(loginResult);

            var apps = await client.GetAccessibleApps();

            Assert.NotNull(apps);
        }

        /// <summary>
        /// 测试获取租户列表
        /// 2022-9-8 测试未通过，控制台配置了租户，但是返回的租户列表为空
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetTenantListTest()
        {
            var loginResult = await Login();
            Assert.NotNull(loginResult);

            var tenantList = await client.GetTenantList();

            Assert.NotNull(tenantList);
        }

        /// <summary>
        /// 测试获取角色列表
        /// 2022-9-8 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetRoleList()
        {
            var loginResult = await Login();
            Assert.NotNull(loginResult);

            var roleList = await client.GetRoleList();

            Assert.NotNull(roleList);
        }

        /// <summary>
        /// 测试获取分组列表
        /// 2022-9-8 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetGroupListTest()
        {
            var loginResult = await Login();
            Assert.NotNull(loginResult);

            var groupList = await client.GetGroupList();

            Assert.NotNull(groupList);
        }

        /// <summary>
        /// 测试获取部门列表
        /// 2022-9-8 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetDepartmentListTest()
        {
            var loginResult = await Login();
            Assert.NotNull(loginResult);

            var departmentList = await client.GetDepartmentList();
            Assert.NotNull(departmentList);
        }

        /// <summary>
        /// 测试获取授权资源列表
        /// 2022-9-8 测试失败，返回无权限执行此操作
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAuthorizedResourcesTest()
        {
            var loginResult = await Login();
            Assert.NotNull(loginResult);

            var resourcesList = await client.GetAuthorizedResources("default",Models.Authentication.ResourceType.API);

            Assert.NotNull(resourcesList);
        }


    }
}
