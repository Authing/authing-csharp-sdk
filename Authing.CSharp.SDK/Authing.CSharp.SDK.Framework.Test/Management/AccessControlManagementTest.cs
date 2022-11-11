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
    class AccessControlManagementTest : ManagementClientBaseTest
    {
        /// <summary>
        /// 2022-10-19 测试通过
        /// 创建资源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateResourceTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateResourceDto createResourceDto = new CreateResourceDto()
                {
                    Code = "ecs",
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
                    Namespace = "634cf98aa5b1455a52949d33"
                };

                ResourceRespDto dto = await managementClient.CreateResource(createResourceDto);

                Assert.IsTrue(dto.Data.Code == "ecs");
            }
        }

        /// <summary>
        /// 2022-10-19 测试通过
        /// 批量创建资源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateResourceBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateResourcesBatchDto createResourcesBatchDto = new CreateResourcesBatchDto()
                {
                    List = new List<CreateResourceBatchItemDto>
                    {
                        new CreateResourceBatchItemDto
                        {
                            Code = "ecs1" ,
                            Description = "服务器" ,
                            Type = CreateResourceBatchItemDto.type.API,
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
                        },
                         new CreateResourceBatchItemDto
                        {
                            Code = "ecs2" ,
                            Description = "服务器" ,
                            Type = CreateResourceBatchItemDto.type.API,
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
                        }
                    },
                    Namespace = "634cf98aa5b1455a52949d33"
                };

                IsSuccessRespDto dto = await managementClient.CreateResourcesBatch(createResourcesBatchDto);

                Assert.IsTrue(dto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-19 测试通过
        /// 获取资源详情
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetResourceTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ResourceRespDto dto = await managementClient.GetResource(new GetResourceDto { Code = "order", Namespace = "634cf98aa5b1455a52949d33" });

                Assert.IsTrue(dto.Data.Code == "ecs");
            }
        }

        /// <summary>
        /// 2022-10-19 测试失败，参数签名错误
        /// 批量获取资源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetResourceBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ResourceListRespDto dto = await managementClient.GetResourcesBatch(new GetResourcesBatchDto { CodeList = string.Join(",", new List<string> { "ecs"}), Namespace = "634cf98aa5b1455a52949d33" });

                Assert.IsTrue(dto.Data.Count == 3);
            }
        }

        /// <summary>
        /// 分页获取常规资源列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetCommonResourceTest()
        {
            var res = await managementClient.ListCommonResource(new CommonListResourceDto { NamespaceCodeList="default,system",Page=1,Limit=10});

            Assert.IsTrue(res.StatusCode == 200);
        }

        /// <summary>
        /// 2022-10-19 测试通过
        /// 分页获取资源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListResourcesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ResourcePaginatedRespDto dto = await managementClient.ListResources(new ListResourcesDto { Type="API",Namespace= "634cf98aa5b1455a52949d33" });

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-19 测试通过
        /// 更新资源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateResourceTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                var resource = managementClient.GetResource(new GetResourceDto { Code="ecs",Namespace= "634cf98aa5b1455a52949d33" }).Result;

                UpdateResourceDto updateResourceDto = new UpdateResourceDto()
                {
                    Code = resource.Data.Code,
                    Actions = resource.Data.Actions,
                    Description = "update",
                    Type = UpdateResourceDto.type.API,
                    Namespace = resource.Data.Namespace
                };

                ResourceRespDto dto = await managementClient.UpdateResource(updateResourceDto);

                Assert.IsTrue(dto.Data.Code == resource.Data.Code);
            }
        }

        /// <summary>
        /// 2022-10-19 测试通过
        /// 删除资源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteResourceTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                var resource = managementClient.GetResource(new GetResourceDto { Code="ecs",Namespace= "634cf98aa5b1455a52949d33" }).Result;

                DeleteResourceDto deleteResourceDto = new DeleteResourceDto()
                {
                    Code = "ecs",
                    Namespace = "634cf98aa5b1455a52949d33"
                };

                IsSuccessRespDto dto = await managementClient.DeleteResource(deleteResourceDto);

                Assert.IsTrue(dto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-19 测试通过
        /// 批量删除资源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteResourceBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                DeleteResourcesBatchDto deleteResourcesBatchDto = new DeleteResourcesBatchDto()
                {
                    CodeList = new List<string> { "ecs1", "ecs2" },
                    Namespace = "634cf98aa5b1455a52949d33"
                };

                IsSuccessRespDto dto = await managementClient.DeleteResourcesBatch(deleteResourcesBatchDto);

                Assert.IsTrue(dto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-19 测试通过
        /// 创建权限分组
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateNameSpaceTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateNamespaceDto createNamespaceDto = new CreateNamespaceDto()
                {
                    Code = "my-namespace",
                    Name = "我的权限分组",
                    Description = "我的权限分组描述"
                };

                NamespaceRespDto dto = await managementClient.CreateNamespace(createNamespaceDto);

                Assert.IsTrue(dto.Data.Code == "my-namespace");
            }
        }

        /// <summary>
        /// 2022-10-19 测试通过
        /// 批量创建权限分组
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateNameSpaceBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateNamespacesBatchDto createNamespacesBatchDto = new CreateNamespacesBatchDto()
                {
                    List = new List<CreateNamespacesBatchItemDto>
                    {
                        new CreateNamespacesBatchItemDto()
                            {
                                Code = "my-namespace1",
                                Name = "我的权限分组",
                                Description = "我的权限分组描述"
                            },
                          new CreateNamespacesBatchItemDto()
                            {
                                Code = "my-namespace2",
                                Name = "我的权限分组",
                                Description = "我的权限分组描述"
                            }
                    }
                };

                IsSuccessRespDto dto = await managementClient.CreateNamespacesBatch(createNamespacesBatchDto);

                Assert.IsTrue(dto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-19 测试通过
        /// 获取权限分组
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetNameSpaceTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                NamespaceRespDto dto = await managementClient.GetNamespace(new GetNamespaceDto { Code= "my-namespace" });

                Assert.IsTrue(dto.Data.Code == "my-namespace");
            }
        }

        /// <summary>
        /// 2022-10-19 测试失败，签名错误
        /// 批量获取权限分组
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetNameSpaceBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                NamespaceListRespDto dto = await managementClient.GetNamespacesBatch(new GetNamespacesBatchDto { CodeList= string.Join(",", new List<string> { "default", "system" }) });

                Assert.IsTrue(dto.Data.Count == 2);
            }
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 更新权限分组
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateNameSpaceTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateNamespaceDto createNamespaceDto = new CreateNamespaceDto()
                {
                    Code = "my-namespace",
                    Name = "我的权限分组",
                    Description = "我的权限分组描述"
                };

                NamespaceRespDto createDto = await managementClient.CreateNamespace(createNamespaceDto);


                UpdateNamespaceDto updateNamespaceDto = new UpdateNamespaceDto()
                {
                    Code = "my-namespace",
                    Name = "我的权限分组",
                    Description = "示例应用的描述",
                    NewCode = "my-new-namespace"
                };


                UpdateNamespaceRespDto dto = await managementClient.UpdateNamespace(updateNamespaceDto);

                Assert.IsTrue(dto.Data.Name == "我的权限分组");
            }
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 删除权限分组
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteNameSpaceTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateNamespaceDto createNamespaceDto = new CreateNamespaceDto()
                {
                    Code = "my-namespace",
                    Name = "我的权限分组",
                    Description = "我的权限分组描述"
                };

                NamespaceRespDto namespaceRespDto= await managementClient.CreateNamespace(createNamespaceDto);


                DeleteNamespaceDto deleteNamespaceDto = new DeleteNamespaceDto()
                {
                    Code = "my-new-namespace",
                };

                IsSuccessRespDto dto = await managementClient.DeleteNamespace(deleteNamespaceDto);

                Assert.IsTrue(dto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-19 测试失败
        /// 批量删除权限分组
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteNameSpaceBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateNamespacesBatchDto createNamespacesBatchDto = new CreateNamespacesBatchDto()
                {
                    List = new List<CreateNamespacesBatchItemDto>
                    {
                        new CreateNamespacesBatchItemDto()
                            {
                                Code = "my-namespace1",
                                Name = "我的权限分组",
                                Description = "我的权限分组描述"
                            },
                          new CreateNamespacesBatchItemDto()
                            {
                                Code = "my-namespace2",
                                Name = "我的权限分组",
                                Description = "我的权限分组描述"
                            }
                    }
                };

                DeleteNamespacesBatchDto deleteNamespacesBatchDto = new DeleteNamespacesBatchDto()
                {
                    CodeList = new List<string> { "my-namespace1", "my-namespace2" }
                };

                IsSuccessRespDto dto = await managementClient.DeleteNamespacesBatch(deleteNamespacesBatchDto);

                Assert.IsTrue(dto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 授权资源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task AuthorizedResourcesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                List<ResourceAction> resourceActions = new List<ResourceAction>();
                resourceActions.Add(new ResourceAction { Name = "start", Description = "启动 ECS 服务器" });
                resourceActions.Add(new ResourceAction { Name = "stop", Description = "启动 ECS 服务器" });

                List<AuthorizeResourceItem> items = new List<AuthorizeResourceItem>();

                List<ResourceItemDto> resourceItemDtos = new List<ResourceItemDto>();
                resourceItemDtos.Add(new ResourceItemDto { Actions = new List<string> { "start", "stop" }, Code = "ecs", ResourceType = ResourceItemDto.resourceType.API });



                items.Add(new AuthorizeResourceItem { TargetType = AuthorizeResourceItem.targetType.USER, TargetIdentifiers = new List<string> { "634fc0a6ebc13285a2ac8dd2" }, Resources = resourceItemDtos });

                AuthorizeResourcesDto authorizedResourceDto = new AuthorizeResourcesDto()
                {
                    Namespace = "default",
                    List = items
                };

                IsSuccessRespDto dto = await managementClient.AuthorizeResources(authorizedResourceDto);

                Assert.IsTrue(dto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 获取授权资源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAuthorizedResourcesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                List<ResourceAction> resourceActions = new List<ResourceAction>();
                resourceActions.Add(new ResourceAction { Name = "start", Description = "启动 ECS 服务器" });
                resourceActions.Add(new ResourceAction { Name = "stop", Description = "启动 ECS 服务器" });

                List<AuthorizeResourceItem> items = new List<AuthorizeResourceItem>();

                List<ResourceItemDto> resourceItemDtos = new List<ResourceItemDto>();
                resourceItemDtos.Add(new ResourceItemDto { Actions = new List<string> { "start", "stop" }, Code = "ecs", ResourceType = ResourceItemDto.resourceType.API });



                items.Add(new AuthorizeResourceItem { TargetType = AuthorizeResourceItem.targetType.USER, TargetIdentifiers = new List<string> { "634fc0a6ebc13285a2ac8dd2" }, Resources = resourceItemDtos });

                AuthorizeResourcesDto authorizedResourceDto = new AuthorizeResourcesDto()
                {
                    Namespace = "default",
                    List = items
                };

                IsSuccessRespDto dto = await managementClient.AuthorizeResources(authorizedResourceDto);

                AuthorizedResourcePaginatedRespDto authorized = await managementClient.GetAuthorizedResources(new GetAuthorizedResourcesDto { TargetIdentifier= "634fc0a6ebc13285a2ac8dd2", Namespace= "634cf98aa5b1455a52949d33", ResourceType="API",TargetType="USER" });

                Assert.IsTrue(authorized.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 判断用户是否对某个资源有权限
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task IsActionAllowedTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //需要先在控制台授权用户资源

                IsActionAllowedDto isActionAllowedDto = new IsActionAllowedDto
                {
                    Action = "start",
                    Namespace = "default",
                    Resource = "ecs:*",
                    UserId = "USER_ID"
                };

                var dto = await managementClient.IsActionAllowed(isActionAllowedDto);

                Assert.True(dto.Data.Allowed);
            }
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 关联/取消资源到租户
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task AssociationResourcesTest()
        {
            var dto = await managementClient.AssociateTenantResource(new  AssociateTenantResourceDto{ AppId= "AUTHING_APPID",TenantId= "AUTHING_TENANT_ID",Code="ecs" });
            Assert.NotNull(dto.Data.Success);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 获取资源被授权的主体
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAuthorizedTargetsTest()
        {
            var dto = await managementClient.GetResourceAuthorizedTargets(new  GetResourceAuthorizedTargetsDto { Resource="ecs",Namespace= "default",Limit=50,Page=1,TargetType=GetResourceAuthorizedTargetsDto.targetType.USER });

            Assert.NotNull(dto.Data.TotalCount>0);
        }
    }
}
