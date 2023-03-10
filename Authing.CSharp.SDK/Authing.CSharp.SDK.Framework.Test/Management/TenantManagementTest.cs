using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    public class TenantManagementTest : ManagementClientBaseTest
    {
        [Test]
        public async Task CreateTenantTest()
        {
            CreateTenantRespDto createTenantRespDto = await managementClient.CreateTenant(new CreateTenantDto
            {
                Name = "租户一",
                AppIds = new List<string> { "6409ace0b029169e6375b73c" },
                Description = "我是租户一",
                RejectHint = "尚未加入当前租户，无法登录",
                SourceAppId = "6409ace0b029169e6375b73c"
            });

            Assert.NotNull(createTenantRespDto);
        }

        [Test]
        public async Task UpdateTenantTest()
        {
            string tenantId = "640a9ae94ba58b23e7586f01";

            IsSuccessRespDto result = await managementClient.UpdateTenant(new UpdateTenantDto
            {
                TenantId = tenantId,
                Name = "租户一新名称",
                AppIds = new List<string> { "6409ace0b029169e6375b73c" },
                Description = "租户一的新描述",
                RejectHint = "尚未加入当前租户，无法登录",
                SourceAppId = "6409ace0b029169e6375b73c"
            });

            Assert.IsTrue(result.Data.Success);
        }

        [Test]
        public async Task DeleteTenantTest()
        {
            string tenantID = "640a9ae94ba58b23e7586f01";

            IsSuccessRespDto isSuccessRespDto = await managementClient.DeleteTenant(new DeleteTenantDto { TenantId = tenantID });

            Assert.IsTrue(isSuccessRespDto.Data.Success);
        }

        [Test]
        public async Task ListTenantsTest()
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    CreateTenantRespDto createTenantRespDto = await managementClient.CreateTenant(new CreateTenantDto
            //    {
            //        Name = "租户一"+i,
            //        AppIds = new List<string> { "6409ace0b029169e6375b73c" },
            //        Description = "我是租户一",
            //        RejectHint = "尚未加入当前租户，无法登录",
            //        SourceAppId = "6409ace0b029169e6375b73c"
            //    });
            //}

            TenantListPaginatedRespDto result = await managementClient.ListTenants(new ListTenantsDto { Keywords="租户"});

            Assert.IsTrue(result.Data.TotalCount>0);
        }

        public async Task GetTenantTest()
        {
            TenantSingleRespDto result = await managementClient.GetTenant(new GetTenantDto { });
        }

        public async Task ImportTenantTest()
        {
            object result = await managementClient.ImportTenant(new ImportTenantDto { });

        }

        public async Task ImportTenantHistoryTest()
        {
            object result = await managementClient.ImportTenantHistory(new ImportTenantHistoryDto { });
        }

        public async Task ImportTenantNotifyUserTest()
        {
            await managementClient.ImportTenantNotifyUser(new ImportTenantNotifyUserDto { });
        }

        public async Task SendEmailBatch()
        {
            await managementClient.SendEmailBatch(new SendManyTenantEmailDto { });
        }

        public async Task SendSmsBatchTest()
        {
            await managementClient.SendSmsBatch(new SendManyTenantSmsDto { });
        }

        public async Task ListTenantAdminTest()
        {
            await managementClient.ListTenantAdmin(new ListTenantAdminDto { });
        }

        public async Task SetTenantAdminTest()
        {
            await managementClient.SetTenantAdmin(new RemoveTenantUsersDto { });
        }

        public async Task DeleteTenantUserTest()
        {
            await managementClient.DeleteTenantUser(new RemoveTenantUsersDto { });
        }

        public async Task DeleteTenantAdminTest()
        {
            await managementClient.DeleteTenantAdmin(new GetTenantUserDto { });
        }

        public async Task GenerateInviteTenantUserLinkTest()
        {
            await managementClient.GenerateInviteTenantUserLink(new GenerateInviteTenantUserLink { });
        }

        public async Task ListInviteTenantUserRecordsTest()
        {
            await managementClient.ListInviteTennatUserRecords(new ListInviteTenantUserRecordsDto { });
        }

        public async Task ListMulipleTenantAdminsTest()
        {
            await managementClient.ListMultipleTenantAdmin(new ListMultipleTenantAdminsDto { });
        }

        public async Task CreateMultipleTenantAdminTest()
        {
            await managementClient.CreateMultipleTenantAdmin(new CreateMultipleTenantAdminDto { });
        }

        public async Task GetMultipleTenantAdminTest()
        {
            await managementClient.GetMultipleTenantAdmin(new GetMultipleTenantAdminDto { });
        }

        public async Task UpdateMultipleTenantAdminTest()
        {
            await managementClient.UpdateMultipleTenantAdmin(new UpdateMultipleTenantAdminDto { });
        }

        public async Task DeleteMultipleTenantAdminTest()
        {
            await managementClient.DeleteMultipleTenantAdmin("");
        }

        public async Task ListTenantCooperatorsTest()
        {
            await managementClient.ListTenantCooperators(new ListTenantCooperatorsDto { });
        }

        public async Task GetTenantCooperatorTest()
        {
            await managementClient.GetTenantCooperator(new GetTenantCooperatorDto { });
        }

        public async Task GetTenantCooperatorMenuTest()
        {
            await managementClient.GetTenantCooperatorMenu(new GetTenantCooperatorMenuDto { });
        }

        public async Task CreateTenantCooperatorTest()
        {
            await managementClient.CreateTenantCooperator(new CreateTenantCooperatorDto { });
        }

        public async Task UpdateTenantCooperatorTest()
        {
            await managementClient.UpdateTenantCooperator(new UpdateTenantCooperatorDto { });
        }

        public async Task DeleteTenantCooperatorTest()
        {
            await managementClient.DeleteTenantCooperator("");
        }
    }
}
