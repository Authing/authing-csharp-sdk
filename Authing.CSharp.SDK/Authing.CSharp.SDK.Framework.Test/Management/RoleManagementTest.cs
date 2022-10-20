using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Services;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.UtilsImpl;
using NUnit.Framework;
using System.Collections.Generic;

using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test
{
    class RoleManagementTest : ManagementClientBaseTest
    {
        /// <summary>
        /// 2022-10-20 测试通过
        /// 分配角色
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task AssignRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                AssignRoleDto dto = new AssignRoleDto()
                {
                    Code = "manager",
                    Namespace = "default",
                    Targets = new List<TargetDto>
                    {
                        new TargetDto
                        {
                            TargetIdentifier = "634fc0a6ebc13285a2ac8dd2",
                            TargetType = TargetDto.targetType.USER
                        }
                    }
                };

                IsSuccessRespDto isSuccessResp = await managementClient.AssignRole(dto);

                Assert.IsTrue(isSuccessResp.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 移除分配的角色
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task RevokeRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                RevokeRoleDto dto = new RevokeRoleDto()
                {
                    Code = "manager",
                    Namespace = "default",
                    Targets = new List<TargetDto>
                    {
                        new TargetDto
                        {
                            TargetIdentifier = "634fc0a6ebc13285a2ac8dd2",
                            TargetType = TargetDto.targetType.USER
                        }
                    }
                };

                IsSuccessRespDto isSuccessResp = await managementClient.RevokeRole(dto);

                Assert.IsTrue(isSuccessResp.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取授权的资源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetRoleAuthorizedResourcesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //TestDelete
                RoleAuthorizedResourcePaginatedRespDto dto = await managementClient.GetRoleAuthorizedResources(new GetRoleAuthorizedResourcesDto 
                {
                    Code="manager",
                    Namespace="default",
                   
                });

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取角色成员
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListRoleMemebersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //Admin1
                UserPaginatedRespDto dto = await managementClient.ListRoleMembers(new ListRoleMembersDto 
                {
                    Code="manager",
                    Namespace="default",
                });

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取角色授权的部门
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListRoleDepartmentsTest()
        {
            //授权部门角色，在控制台，点击进去角色详情，进行授权

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //"Admin1", "default"
                RoleDepartmentListPaginatedRespDto dto = await managementClient.ListRoleDepartments(new ListRoleDepartmentsDto 
                {
                    Code="manager",
                    Namespace="default"
                });

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 创建角色
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取角色列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListRolesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //default
                RolePaginatedRespDto roleSingle = await managementClient.ListRoles(new ListRolesDto { Namespace = "default" });

                Assert.IsTrue(roleSingle.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 批量删除角色
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteRolesBatchTest()
        {

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateRoleDto dto = new CreateRoleDto()
                {
                    Code = "role1",
                    Namespace = "default",
                    Description = "thsi  is manager"
                };

                RoleSingleRespDto roleSingle = await managementClient.CreateRole(dto);

                dto = new CreateRoleDto()
                {
                    Code = "role2",
                    Namespace = "default",
                    Description = "thsi  is manager"
                };

                roleSingle = await managementClient.CreateRole(dto);


                DeleteRoleDto deleteRoleDto = new DeleteRoleDto()
                {
                    CodeList = new List<string> { "role1", "role2" },
                    Namespace = "default"
                };

                IsSuccessRespDto isSuccess = await managementClient.DeleteRolesBatch(deleteRoleDto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 批量创建角色
        /// </summary>
        /// <returns></returns>
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
                            Code="my-role-code1",
                            Namespace="default",
                            Description="my-role-code1 描述"
                        },
                         new RoleListItem
                        {
                            Code="my-role-code2",
                            Namespace="default",
                            Description="my-role-code2 描述"
                        }

                    }
                };

                IsSuccessRespDto isSuccess = await managementClient.CreateRolesBatch(createRoleDto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 更新角色
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UpdateRoleDto updateRoleDto = new UpdateRoleDto()
                {
                    Code = "my-role-code1",
                    NewCode = "my-role-code1-new",
                    Namespace = "default"
                };

                IsSuccessRespDto isSuccessRespDto = await managementClient.UpdateRole(updateRoleDto);

                Assert.IsTrue(isSuccessRespDto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取角色详情
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                RoleSingleRespDto dto = await managementClient.GetRole(new GetRoleDto {Code="my-role-code2",Namespace="default" });

                Assert.IsTrue(dto.Data.Code =="my-role-code2");
            }
        }


    }
}
