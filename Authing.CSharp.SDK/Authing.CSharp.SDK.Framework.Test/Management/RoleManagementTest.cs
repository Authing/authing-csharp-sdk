using Authing.CSharp.SDK.Models.Management;
using Authing.CSharp.SDK.Services;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.UtilsImpl;
using NUnit.Framework;
using System.Collections.Generic;

using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test
{
    class RoleManagementTest: ManagementClientBaseTest
    {

        [Test]
        public async Task AssignRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                AssignRoleDto dto = new AssignRoleDto()
                {
                    Code = "TestDelete",
                    Namespace = "default",
                    Targets = new List<TargetDto>
                    {
                        new TargetDto
                        {
                            TargetIdentifier = "629487c14604f5ca85cbff80",
                            TargetType = TargetDto.targetType.USER
                        }
                    }
                };

                IsSuccessRespDto isSuccessResp = await managementClient.AssignRole(dto);

                Assert.IsTrue(isSuccessResp.Data.Success);
            }
        }

        [Test]
        public void AssignRoleBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {


                AssignRoleBatchDto assignRoleBatchDto = new AssignRoleBatchDto()
                {
                    Roles = new List<RoleCodeDto>
                    {
                        new RoleCodeDto
                        {
                            Code = "TestDelete",
                            Namespace = "default"
                        }
                    },
                    Targets = new List<TargetDto>
                    {
                        new TargetDto
                        {
                            TargetIdentifier = "61c1866a342c23ec8a6431fe",
                            TargetType = TargetDto.targetType.USER
                        }
                    },
                };

                /*
                  注释  2022-6-2 祁冬 ，重新生成后，没有此方法，所以先注释这两行代码

                  IsSuccessRespDto isSuccessResp = managementClient.AssignRoleBatch(assignRoleBatchDto).Result;

                  Assert.IsTrue(isSuccessResp.Data.Success);

                 */


            }
        }

        [Test]
        public async Task RevokeRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                RevokeRoleDto dto = new RevokeRoleDto()
                {
                    Code = "TestDelete",
                    Namespace = "default",
                    Targets = new List<TargetDto>
                    {
                        new TargetDto
                        {
                            TargetIdentifier = "629487c14604f5ca85cbff80",
                            TargetType = TargetDto.targetType.USER
                        }
                    }
                };

                IsSuccessRespDto isSuccessResp = await managementClient.RevokeRole(dto);

                Assert.IsTrue(isSuccessResp.Data.Success);
            }
        }

        [Test]
        public void RevokeRoleBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                RevokeRoleBatchDto assignRoleBatchDto = new RevokeRoleBatchDto()
                {
                    Roles = new List<RoleCodeDto>
                    {
                        new RoleCodeDto
                        {
                            Code = "TestDelete",
                            Namespace = "default"
                        }
                    },
                    Targets = new List<TargetDto>
                    {
                        new TargetDto
                        {
                            TargetIdentifier = "61c1866a342c23ec8a6431fe",
                            TargetType = TargetDto.targetType.USER
                        }
                    },
                };

                /*
                   注释  2022-6-2 祁冬 ，重新生成后，没有此方法，所以先注释这两行代码

                  IsSuccessRespDto isSuccessResp = managementClient.RevokeRoleBatch(assignRoleBatchDto).Result;

                  Assert.IsTrue(isSuccessResp.Data.Success);
                 */
            }
        }

        [Test]
        public async Task GetRoleAuthorizedResourcesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                RoleAuthorizedResourcePaginatedRespDto dto = await managementClient.GetRoleAuthorizedResources("TestDelete");

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        [Test]
        public async Task ListRoleMemebersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UserPaginatedRespDto dto = await managementClient.ListRoleMembers("Admin1");

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        [Test]
        public async Task ListRoleDepartmentsTest()
        {
            //授权部门角色，在控制台，点击进去角色详情，进行授权

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                RoleDepartmentListPaginatedRespDto dto = await managementClient.ListRoleDepartments("Admin1", "default");

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        [Test]
        public async Task CreateRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateRoleDto dto = new CreateRoleDto()
                {
                    Code = "manager",
                    Namespace = "default",
                    Description = "thsi  is manager"
                };

                RoleSingleRespDto roleSingle = await managementClient.CreateRole(dto);

                Assert.IsTrue(roleSingle.Data.Code == "manager");
            }
        }

        [Test]
        public async Task ListRolesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                RolePaginatedRespDto roleSingle = await managementClient.ListRoles("default");

                Assert.IsTrue(roleSingle.Data.List.Count > 0);
            }
        }

        [Test]
        public async Task DeleteRolesBatchTest()
        {

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DeleteRoleDto deleteRoleDto = new DeleteRoleDto()
                {
                    CodeList = new List<string> { "1","0" },
                    Namespace = "default"
                };

                IsSuccessRespDto isSuccess = await managementClient.DeleteRolesBatch(deleteRoleDto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        [Test]
        public async Task CreateRolesBatch()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateRolesBatch createRoleDto = new CreateRolesBatch()
                {
                    List = new List<RoleListItem>
                    {
                        new RoleListItem
                        {
                            Code="my-role-code",
                            Namespace="default",
                            Description="描述"
                        }
                    }
                };

                IsSuccessRespDto isSuccess =await managementClient.CreateRolesBatch(createRoleDto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        [Test]
        public async Task UpdateRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UpdateRoleDto updateRoleDto = new UpdateRoleDto()
                {
                    Code = "Admin1",
                    NewCode = "Admin2",
                    Namespace = "default"
                };

                IsSuccessRespDto isSuccessRespDto =await managementClient.UpdateRole(updateRoleDto);

                Assert.IsTrue(isSuccessRespDto.Data.Success);
            }
        }

        [Test]
        public async Task GetRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
               RoleSingleRespDto dto=   await managementClient.GetRole("Admin");

                Assert.IsTrue(dto.Data != null);
            }
        }


    }
}
