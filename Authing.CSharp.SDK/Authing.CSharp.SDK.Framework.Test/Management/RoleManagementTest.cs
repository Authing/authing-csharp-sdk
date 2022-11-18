using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Services;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.UtilsImpl;
using NUnit.Framework;
using System;
using System.Collections.Generic;

using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test
{
    [TestFixture]
    class RoleManagement_Single_Role_Test : ManagementClientBaseTest
    {
        private string roleCode = "manager";
        private string nameSpace = "default";
        private string newRoleCode = "new_manager";

        private UserDto newAddUser;

        [OneTimeSetUp]
        public async Task CreateUser()
        {
            CreateUserReqDto dto = new CreateUserReqDto()
            {
                Username = "testUser" + new Random().Next(200, 1000),
                Status = CreateUserReqDto.status.ACTIVATED,
                Password = "password",
                Options = new CreateUserOptionsDto { DepartmentIdType = CreateUserOptionsDto.departmentIdType.DEPARTMENT_ID }
            };

            UserSingleRespDto userSingleRespDto = await managementClient.CreateUser(dto);

            newAddUser = userSingleRespDto.Data;
        }

        [OneTimeTearDown]
        public async Task DeleteUser()
        {
            await managementClient.DeleteUsersBatch(new DeleteUsersBatchDto
            {
                UserIds = new List<string> { newAddUser.UserId }
            });
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 创建角色
        /// </summary>
        /// <returns></returns>
        [Test, Order(1), Description("创建角色")]
        public async Task CreateRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateRoleDto dto = new CreateRoleDto()
                {
                    Code = roleCode,
                    Namespace = nameSpace,
                    Description = "thsi  is manager"
                };

                RoleSingleRespDto roleSingle = await managementClient.CreateRole(dto);

                Assert.IsTrue(roleSingle.Data.Code == roleCode);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 分配角色
        /// </summary>
        /// <returns></returns>
        [Test, Order(2)]
        public async Task AssignRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                AssignRoleDto dto = new AssignRoleDto()
                {
                    Code = roleCode,
                    Namespace = nameSpace,
                    Targets = new List<TargetDto>
                    {
                        new TargetDto
                        {
                            TargetIdentifier = newAddUser.UserId,
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
        /// 获取授权的资源
        /// </summary>
        /// <returns></returns>
        [Test, TestCase("ecs"),Order(3)]
        public async Task GetRoleAuthorizedResourcesTest(string resourceCode)
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //新建资源
                CreateResourceDto createResourceDto = new CreateResourceDto()
                {
                    Code = resourceCode,
                    Description = "服务器",
                    Type = CreateResourceDto.type.API,
                    Actions = new List<ResourceAction>
                    {
                        new ResourceAction
                        {
                            Name = "ecs:start",
                            Description = "启动 ECS 服务器"
                        } ,
                         new ResourceAction
                        {
                            Name = "ecs:stop",
                            Description = "启动 ECS 服务器"
                        }
                    },
                    ApiIdentifier = "https://my-awesome-api.com/api",
                    Namespace = nameSpace,
                    Name = "服务器资源"
                };

                ResourceRespDto resourceResp = await managementClient.CreateResource(createResourceDto);


                //授权资源给角色

                await managementClient.AuthorizeResources(new AuthorizeResourcesDto
                {
                    List = new List<AuthorizeResourceItem>
                    {
                        new AuthorizeResourceItem
                        {
                            Resources=new List<ResourceItemDto>
                            {
                                new ResourceItemDto
                                {
                                    Actions=new List<string> { "*"},
                                    Code=resourceCode,
                                    ResourceType=ResourceItemDto.resourceType.API
                                }
                            },
                            TargetIdentifiers=new List<string>{ roleCode },
                            TargetType=AuthorizeResourceItem.targetType.ROLE
                        }
                    },
                    Namespace = nameSpace,
                });


                RoleAuthorizedResourcePaginatedRespDto dto = await managementClient.GetRoleAuthorizedResources(new GetRoleAuthorizedResourcesDto
                {
                    Code = roleCode,
                    Namespace = nameSpace,

                });

                Assert.IsTrue(dto.Data.List.Count > 0);

                //删除资源

                var res = await managementClient.DeleteResource(new DeleteResourceDto
                {
                    Code = roleCode,
                    Namespace = nameSpace
                });

                Assert.IsTrue(res.Data.Success);
            }
        }


        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取角色成员
        /// </summary>
        /// <returns></returns>
        [Test,Order(4)]
        public async Task ListRoleMemebersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //Admin1
                UserPaginatedRespDto dto = await managementClient.ListRoleMembers(new ListRoleMembersDto
                {
                    Code = roleCode,
                    Namespace = nameSpace,
                });

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 移除分配的角色
        /// </summary>
        /// <returns></returns>
        [Test, Order(5)]
        public async Task RevokeRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                RevokeRoleDto dto = new RevokeRoleDto()
                {
                    Code = roleCode,
                    Namespace = nameSpace,
                    Targets = new List<TargetDto>
                    {
                        new TargetDto
                        {
                            TargetIdentifier = newAddUser.UserId,
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
        /// 获取角色详情
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                RoleSingleRespDto dto = await managementClient.GetRole(new GetRoleDto { Code = roleCode, Namespace = nameSpace });

                Assert.IsTrue(dto.Data.Code == "my-role-code2");
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 更新角色
        /// </summary>
        /// <returns></returns>
        [Test, Order(6)]
        public async Task UpdateRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UpdateRoleDto updateRoleDto = new UpdateRoleDto()
                {
                    Code = roleCode,
                    NewCode = newRoleCode,
                    Namespace = nameSpace
                };

                IsSuccessRespDto isSuccessRespDto = await managementClient.UpdateRole(updateRoleDto);

                Assert.IsTrue(isSuccessRespDto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 批量删除角色
        /// </summary>
        /// <returns></returns>
        [Test, Order(7)]
        public async Task DeleteRole_Test()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DeleteRoleDto deleteRoleDto = new DeleteRoleDto()
                {
                    CodeList = new List<string> { newRoleCode },
                    Namespace = nameSpace
                };

                IsSuccessRespDto isSuccess = await managementClient.DeleteRolesBatch(deleteRoleDto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }
    }

    class RoleManagementTest : ManagementClientBaseTest
    {
        /// <summary>
        /// 2022-10-20 测试通过
        /// 批量创建角色
        /// </summary>
        /// <returns></returns>
        [Test,Order(1)]
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
                    Code = "manager",
                    Namespace = "default"
                });

                Assert.IsTrue(dto.Data.List.Count > 0);
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
        [Test,Order(2)]
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






    }
}
