using Authing.CSharp.SDK.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    public class TreeDataSource
    {
        public string code { get; set; }
        public string name { get; set; }
        public string value { get; set; }
        public List<TreeDataSource> children { get; set; }
    }
    public partial class DataResourceManagementTest : ManagementClientBaseTest
    {
        private string code = "examplePermissionCode";
        private string name = "examplePermissionNamespace";
        private string description = "examplePermissionDescription";

        [Test, Order(1)]
        public async Task CreatePermissionNamespaceTest()
        {
            CreatePermissionNamespaceResponseDto result = await managementClient.CreatePermissionNamespace(new CreatePermissionNamespaceDto { Code = code, Name = name, Description = description });

            Assert.IsTrue(result.Data.Name == name);
        }

        [Test, Order(2)]
        public async Task GetPermissionNamespaceTest()
        {
            GetPermissionNamespaceResponseDto result = await managementClient.GetPermissionNamespace(new GetPermissionNamespaceDto { Code = code });

            Assert.True(result.Data.Code == code);
        }

        [Test, Order(3)]
        public async Task ListPermissionNamespaceRoles_Test()
        {
            PermissionNamespaceRolesListPaginatedRespDto result = await managementClient.ListPermissionNamespaceRoles(new ListPermissionNamespaceRolesDto
            {
                Code = code
            });

            Assert.IsTrue(result.Data.TotalCount == 0);
        }

        [Test]
        public async Task UpdateDataResource_With_Tree_Test()
        {
            UpdateDataResourceResponseDto result = await managementClient.UpdateDataResource(new UpdateDataResourceDto
            {
                NamespaceCode = code,
                ResourceName = "树资源1Name" + "update",
                ResourceCode = "tree1Code",
                Description = "这是一个数据资源树类型创建" + "update",
                Struct = new List<DataResourceTreeStructs>
                {
                    new DataResourceTreeStructs
                    {
                        Code="123update",
                        Name="数据资源update",
                        Value="示例数据资源节点update",
                        Children=new List<object>
                        {
                            new DataResourceTreeStructs
                            {
                                Code="code1",
                                Name="子节点1",
                                Value="子节点值",
                                Children=new List<object>
                                {
                                    new DataResourceTreeStructs
                                    {
                                        Code="code2",
                                        Name="子节点2",
                                        Value="子节点值2"
                                    }
                                }
                            }
                        }
                    }
                },
                Actions = new List<string> { "get", "read", "update" }
            });

            Assert.IsTrue(result.Data.ResourceCode == "tree1Code");
        }

        [Test, Order(10)]
        public async Task ListDataResourcesTest()
        {
            ListDataResourcesPaginatedRespDto result = await managementClient.ListDataResources(new ListDataResourcesDto
            {
                NamespaceCodes = code,

            });

            Assert.IsTrue(result.Data.TotalCount > 0);
        }

        [Test, Order(7)]
        public async Task UpdatepermissionNamespaceTest()
        {
            string newCode = "update" + code;

            UpdatePermissionNamespaceResponseDto result = await managementClient.UpdatePermissionNamespace(new UpdatePermissionNamespaceDto
            {
                Code = code,
                Name = "update" + name,
                NewCode = newCode,
                Description = "update" + description
            });

            Assert.IsTrue(result.Data.Code == newCode);
        }

        [Test, Order(8)]
        public async Task DeletePermissionNamespaceTest()
        {
            IsSuccessRespDto result = await managementClient.DeletePermissionNamespace(new DeletePermissionNamespaceDto
            {
                Code = "update" + code
            });

            Assert.IsTrue(result.Data.Success);
        }

        [Test, Order(9)]
        public async Task CheckPermissionNamespaceExists_CheckCode_Test()
        {
            PermissionNamespaceCheckExistsRespDto result = await managementClient.CheckPermissionNamespaceExists(new CheckPermissionNamespaceExistsDto { Code = code });

            Assert.True(result.Data.IsValid);
        }

        [Test, Order(10)]
        public async Task CheckPermissionNamespaceExists_CheckNamespace_Test()
        {
            PermissionNamespaceCheckExistsRespDto result = await managementClient.CheckPermissionNamespaceExists(new CheckPermissionNamespaceExistsDto { Name = name });

            Assert.True(result.Data.IsValid);
        }

    }

    public class DataResourceManagement_String_Test : ManagementClientBaseTest
    {
        private string code = "examplePermissionCode";
        private string name = "examplePermissionNamespace";
        private string description = "examplePermissionDescription";

        //[OneTimeSetUp]
        public async Task CreatePermissionNamespaceTest()
        {
            CreatePermissionNamespaceResponseDto result = await managementClient.CreatePermissionNamespace(new CreatePermissionNamespaceDto { Code = code, Name = name, Description = description });

            Assert.IsTrue(result.Data.Name == name);
        }

        //[OneTimeTearDown]
        public async Task DeletePermissionNamespaceTest()
        {
            IsSuccessRespDto result = await managementClient.DeletePermissionNamespace(new DeletePermissionNamespaceDto
            {
                Code = code
            });

            Assert.IsTrue(result.Data.Success);
        }

        [Test]
        public async Task CheckDataResourceExists_With_Code_Test()
        {
            CheckParamsDataResourceResponseDto result = await managementClient.CheckDataResourceExists(new CheckDataResourceExistsDto { NamespaceCode = code, ResourceCode = "str2" });
            Assert.IsTrue(result.Data.IsValid);
        }

        [Test]
        public async Task CheckDataResourceExists_With_Name_Test()
        {
            CheckParamsDataResourceResponseDto result = await managementClient.CheckDataResourceExists(new CheckDataResourceExistsDto { NamespaceCode = code, ResourceName = "字符串资源2" });
            Assert.IsTrue(result.Data.IsValid);
        }

        [Test, Order(4)]
        public async Task CreateDataResource_With_String_Type_Test()
        {
            CreateDataResourceResponseDto result = await managementClient.CreateDataResource(new CreateDataResourceDto
            {
                NamespaceCode = code,
                ResourceName = "字符串资源1",
                ResourceCode = "str1",
                Type = CreateDataResourceDto.type.STRING,
                Description = "这是一个数据资源字符串类型创建",
                Struct = "str1",
                Actions = new List<string> { "get", "read", "update" }
            });

            Assert.IsTrue(result.Data.ResourceName == "字符串资源1");
        }

        [Test, Order(7)]
        public async Task CreateStringDataResourceTest()
        {
            CreateStringDataResourceResponseDto result = await managementClient.CreateDataResourceByString(new CreateStringDataResourceDto
            {
                NamespaceCode = code,
                ResourceName = "示例数据资源名称",
                ResourceCode = "dataResourceTestCode",
                Struct = "exampleStringStruct",
                Actions = new List<string> { "read", "get" },
                Description = "示例数据资源描述"
            });

            Assert.IsTrue(result.Data.ResourceCode == "dataResourceTestCode");
        }

        [Test, Order(13)]
        public async Task GetDataResource_String_Test()
        {
            GetDataResourceResponseDto result = await managementClient.GetDataResource(new GetDataResourceDto
            {
                NamespaceCode = code,
                ResourceCode = "dataResourceTestCode"
            });

            Assert.IsTrue(result.Data.ResourceCode == "dataResourceTestCode");
        }

        [Test]
        public async Task DeleteDataResource_String_Test()
        {
            CommonResponseDto result = await managementClient.DeleteDataResource(new DeleteDataResourceDto
            {
                NamespaceCode = code,
                ResourceCode = "dataResourceTestCode"
            });

            Assert.IsTrue(result.StatusCode == 200);
        }
    }

    public class DataResourceManagement_Array_Test : ManagementClientBaseTest
    {
        private string code = "examplePermissionCode";
        private string name = "examplePermissionNamespace";
        private string description = "examplePermissionDescription";

        [SetUp]
        public async Task CreatePermissionNamespaceTest()
        {
            CreatePermissionNamespaceResponseDto result = await managementClient.CreatePermissionNamespace(new CreatePermissionNamespaceDto { Code = code, Name = name, Description = description });

            Assert.IsTrue(result.Data.Name == name);
        }

        [TearDown]
        public async Task DeletePermissionNamespaceTest()
        {
            IsSuccessRespDto result = await managementClient.DeletePermissionNamespace(new DeletePermissionNamespaceDto
            {
                Code = code
            });

            Assert.IsTrue(result.Data.Success);
        }

        [Test, Order(8)]
        public async Task CreateArrayDataResourceTest()
        {
            CreateArrayDataResourceResponseDto result = await managementClient.CreateDataResourceByArray(new CreateArrayDataResourceDto
            {
                NamespaceCode = code,
                ResourceName = "示例数组资源名称",
                ResourceCode = "dataResourceArrayTestCode",
                Struct = new List<string> { "exampleArrayStruct1", "exampleArrayStruct2" },
                Actions = new List<string> { "read", "get" },
                Description = "示例数组数据资源描述"
            });

            Assert.IsTrue(result.Data.ResourceCode == "dataResourceArrayTestCode");
        }

        [Test, Order(5)]
        public async Task CreateDataResource_With_String_Array_Type_Test()
        {
            CreateDataResourceResponseDto result = await managementClient.CreateDataResource(new CreateDataResourceDto
            {
                NamespaceCode = code,
                ResourceName = "数组资源1",
                ResourceCode = "array1",
                Type = CreateDataResourceDto.type.ARRAY,
                Description = "这是一个数据资源数组类型创建",
                Struct = new List<string> { "array1", "array2", "array3" },
                Actions = new List<string> { "get", "read", "update" }
            });

            Assert.IsTrue(result.Data.ResourceName == "数组资源1");
        }


        [Test, Order(12)]
        public async Task GetDataResource_Array_Test()
        {
            GetDataResourceResponseDto result = await managementClient.GetDataResource(new GetDataResourceDto
            {
                NamespaceCode = code,
                ResourceCode = "dataResourceArrayTestCode"
            });

            Assert.IsTrue(result.Data.ResourceCode == "dataResourceArrayTestCode");
        }

        [Test]
        public async Task DeleteDataResource_Array_Test()
        {
            CommonResponseDto result = await managementClient.DeleteDataResource(new DeleteDataResourceDto
            {
                NamespaceCode = code,
                ResourceCode = "dataResourceArrayTestCode"
            });

            Assert.IsTrue(result.StatusCode == 200);
        }
    }

    public class DataResourceManagement_Tree_Test : ManagementClientBaseTest
    {
        private string code = "examplePermissionCode";
        private string name = "examplePermissionNamespace";
        private string description = "examplePermissionDescription";

        [SetUp]
        public async Task CreatePermissionNamespaceTest()
        {
            CreatePermissionNamespaceResponseDto result = await managementClient.CreatePermissionNamespace(new CreatePermissionNamespaceDto { Code = code, Name = name, Description = description });

            Assert.IsTrue(result.Data.Name == name);
        }

        [TearDown]
        public async Task DeletePermissionNamespaceTest()
        {
            IsSuccessRespDto result = await managementClient.DeletePermissionNamespace(new DeletePermissionNamespaceDto
            {
                Code = code
            });

            Assert.IsTrue(result.Data.Success);
        }

        [Test, Order(11)]
        public async Task GetDataResource_Tree_Test()
        {
            GetDataResourceResponseDto result = await managementClient.GetDataResource(new GetDataResourceDto
            {
                NamespaceCode = code,
                ResourceCode = "tree1Code"
            });

            Assert.IsTrue(result.Data.ResourceCode == "tree1Code");
        }

        [Test, Order(6)]
        public async Task CreateDataResource_With_Tree_Type_Test()
        {
            CreateDataResourceResponseDto result = await managementClient.CreateDataResource(new CreateDataResourceDto
            {
                NamespaceCode = code,
                ResourceName = "树资源1",
                ResourceCode = "tree1",
                Type = CreateDataResourceDto.type.TREE,
                Description = "这是一个数据资源树类型创建",
                Struct = new List<TreeDataSource>
                { new TreeDataSource {code="tree1",name="tree1",value="tree1",
                    children=new List<TreeDataSource>
                    {
                        new TreeDataSource
                        { code="tree2",name="tree2",value="tree2",
                            children=new List<TreeDataSource>
                            {
                                new TreeDataSource
                                { code="tree3",name="tree3",value="tree3"}
                            }
                        }
                    }
                    }
                },
                Actions = new List<string> { "get", "read", "update" }
            });

            Assert.IsTrue(result.Data.ResourceName == "树资源1");
        }


        [Test, Order(9)]
        public async Task CreateTreeDataResourceTest()
        {
            CreateTreeDataResourceResponseDto result = await managementClient.CreateDataResourceByTree(new CreateTreeDataResourceDto
            {
                NamespaceCode = code,
                ResourceName = "树资源1Name",
                ResourceCode = "tree1Code",
                Description = "这是一个数据资源树类型创建",
                Struct = new List<DataResourceTreeStructs>
                {
                    new DataResourceTreeStructs
                    {
                        Code="123",
                        Name="数据资源",
                        Value="示例数据资源节点",
                        Children=new List<object>
                        {
                            new DataResourceTreeStructs
                            {
                                Code="code1",
                                Name="子节点1",
                                Value="子节点值",
                                Children=new List<object>
                                {
                                    new DataResourceTreeStructs
                                    {
                                        Code="code2",
                                        Name="子节点2",
                                        Value="子节点值2"
                                    }
                                }
                            }
                        }
                    }
                },
                Actions = new List<string> { "get", "read", "update" }
            });

            Assert.IsTrue(result.Data.ResourceName == "树资源1Name");
        }


        [Test]
        public async Task DeleteDataResource_String_Test()
        {
            CommonResponseDto result = await managementClient.DeleteDataResource(new DeleteDataResourceDto
            {
                NamespaceCode = code,
                ResourceCode = "tree1Code"
            });

            Assert.IsTrue(result.StatusCode == 200);
        }
    }

    public class DataResourceManagement_Data_Policy_Test : ManagementClientBaseTest
    {
        private string code = "examplePermissionCode";

        [Test]
        public async Task CreateDataPolicyTest()
        {
            CreateDataPolicyResponseDto result = await managementClient.CreateDataPolicy(new CreateDataPolicyDto
            {
                PolicyName = "示例数据策略",
                Description = "这是一个示例数据策略",
                StatementList = new List<DataStatementPermissionDto>
                {
                    new DataStatementPermissionDto
                    {
                        Effect=DataStatementPermissionDto.effect.ALLOW,
                        Permissions=new List<string>
                        {
                            "examplePermissionCode/str1/get",
                            "examplePermissionCode/str1/read",
                        }
                    }
                }
            });
            Assert.IsTrue(result.Data.PolicyName == "示例数据策略");
        }

        [Test]
        public async Task ListDataPoliciesTest()
        {
            ListDataPoliciesPaginatedRespDto result = await managementClient.ListDataPolices(new ListDataPoliciesDto
            {

            });

            Assert.IsTrue(result.Data.TotalCount > 0);
        }

        [Test]
        public async Task ListSimpleDataPoliciesTest()
        {
            ListSimpleDataPoliciesPaginatedRespDto result = await managementClient.ListSimpleDataPolices(new ListSimpleDataPoliciesDto
            {

            });

            Assert.IsTrue(result.Data.TotalCount > 0);
        }

        [Test]
        public async Task GetDataPolicyTest()
        {
            ListSimpleDataPoliciesPaginatedRespDto result = await managementClient.ListSimpleDataPolices(new ListSimpleDataPoliciesDto
            {

            });

            Assert.IsTrue(result.Data.TotalCount > 0);

            GetDataPolicyResponseDto res = await managementClient.GetDataPolicy(new GetDataPolicyDto
            {
                PolicyId = result.Data.List.First().PolicyId
            });

            Assert.IsTrue(res.Data.PolicyId == result.Data.List.First().PolicyId);
        }

        [Test]
        public async Task UpdateDataPolicy()
        {
            ListSimpleDataPoliciesPaginatedRespDto result = await managementClient.ListSimpleDataPolices(new ListSimpleDataPoliciesDto
            {

            });

            Assert.IsTrue(result.Data.TotalCount > 0);

            UpdateDataPolicyResponseDto res = await managementClient.UpdateDataPolicy(new UpdateDataPolicyDto
            {
                PolicyId = result.Data.List.First().PolicyId,
                PolicyName = "策略名称_update",
                StatementList = new List<DataStatementPermissionDto>
                {
                    new DataStatementPermissionDto
                    {
                        Effect=DataStatementPermissionDto.effect.ALLOW,
                        Permissions=new List<string>
                        {
                            "examplePermissionCode/str1/update"
                        }
                    }
                }
            });

            Assert.IsTrue(res.Data.PolicyName == "策略名称_update");
        }



        [Test]
        public async Task CheckDataPolicyExistsTest()
        {
            CheckParamsDataPolicyResponseDto result = await managementClient.CheckDataPolicyExists(new CheckDataPolicyExistsDto
            {
                PolicyName = "策略名称"
            });

            Assert.IsTrue(result.Data.IsValid);
        }

        [Test]
        public async Task AuthorizeDataPoliciesTest()
        {
            UserPaginatedRespDto res = await managementClient.ListUsers(new ListUsersRequestDto { });

            ListSimpleDataPoliciesPaginatedRespDto polocyList = await managementClient.ListSimpleDataPolices(new ListSimpleDataPoliciesDto
            {

            });

            CommonResponseDto result = await managementClient.AuthorizeDataPolicies(new CreateAuthorizeDataPolicyDto
            {
                PolicyIds = new List<string> { polocyList.Data.List.First().PolicyId },
                TargetList = new List<SubjectDto>
                {
                    new SubjectDto
                    {
                        Id=res.Data.List.First().UserId,
                        Name=res.Data.List.First().Name,
                        Type=SubjectDto.type.USER
                    }
                }
            });

            Assert.IsTrue(result.StatusCode == 200);
        }

        [Test]
        public async Task GetUserPermissionListTest()
        {
            UserPaginatedRespDto res = await managementClient.ListUsers(new ListUsersRequestDto { });

            GetUserPermissionListRespDto result = await managementClient.GetUserPermissionList(new GetUserPermissionListDto
            {
                NamespaceCodes = new List<string> { code },
                UserIds = new List<string> { res.Data.List.First().UserId }
            });

            Assert.IsTrue(result.Data.UserPermissionList.Count > 0);
        }

        [Test]
        public async Task CheckPermissionTest()
        {
            UserPaginatedRespDto res = await managementClient.ListUsers(new ListUsersRequestDto { });


            CheckPermissionRespDto result = await managementClient.CheckPermission(new CheckPermissionDto
            {
                NamespaceCode = code,
                UserId = res.Data.List.First().UserId,
                Action = "get,read",
                Resources = new List<string> { "str1" }
            });

            Assert.IsTrue(result.Data.CheckResultList.Count > 0);
        }

        [Test]
        public async Task CheckExternalUserPermissionTest()
        {
            UserPaginatedRespDto res = await managementClient.ListUsers(new ListUsersRequestDto { });



            CheckExternalUserPermissionRespDto result = await managementClient.CheckExternalUserPermission(new CheckExternalUserPermissionDto
            {
                NamespaceCode = code,
                ExternalId = res.Data.List.First().ExternalId,
                Action = "get,read",
                Resources = new List<string> { "str1" }
            });

            Assert.IsFalse(result.Data.CheckResultList.First().Enabled);
        }

        [Test]
        public async Task GetUserResourcePermissionListTest()
        {
            UserPaginatedRespDto res = await managementClient.ListUsers(new ListUsersRequestDto { });

            GetUserResourcePermissionListRespDto result = await managementClient.GetUserResourcePermissionList(new GetUserResourcePermissionListDto
            {
                NamespaceCode = code,
                Resources = new List<string> { "str1" },
                UserId = res.Data.List.First().UserId
            });

            Assert.IsTrue(result.Data.PermissionList.Count > 0);
        }

        [Test]
        public async Task ListResourceTargetsTest()
        {
            ListResourceTargetsRespDto result = await managementClient.ListResourceTargets(new ListResourceTargets
            {
                NamespaceCode = code,
                Actions = new List<string> { "read" },
                Resources = new List<string> { "str1" }
            });

            Assert.IsTrue(result.Data.AuthUserList.Count > 0);
        }

        [Test]
        public async Task CheckUserSamLevelPermissionTest()
        {
            UserPaginatedRespDto res = await managementClient.ListUsers(new ListUsersRequestDto { });


            CheckUserSameLevelPermissionResponseDto result = await managementClient.CheckUserSameLevelPermission(new CheckUserSameLevelPermissionDto
            {
                NamespaceCode = code,
                UserId = res.Data.List.First().UserId,
                Action = "read",
                Resource = "str1",
            });

            Assert.IsTrue(result.Data.CheckLevelResultList.Count > 0);
        }

        [Test]
        public async Task RevokeDataPolicy()
        {
            UserPaginatedRespDto res = await managementClient.ListUsers(new ListUsersRequestDto { });

            ListSimpleDataPoliciesPaginatedRespDto polocyList = await managementClient.ListSimpleDataPolices(new ListSimpleDataPoliciesDto
            {

            });

            CommonResponseDto result = await managementClient.RevokeDataPolicy(new DeleteAuthorizeDataPolicyDto
            {
                PolicyId = polocyList.Data.List.First().PolicyId,
                TargetIdentifier = res.Data.List.First().UserId,
                TargetType = DeleteAuthorizeDataPolicyDto.targetType.USER
            });

            Assert.IsTrue(result.StatusCode == 200);
        }


        [Test]
        public async Task DeleteDataPolicy()
        {
            ListSimpleDataPoliciesPaginatedRespDto result = await managementClient.ListSimpleDataPolices(new ListSimpleDataPoliciesDto
            {

            });

            Assert.IsTrue(result.Data.TotalCount > 0);

            CommonResponseDto res = await managementClient.DeleteDataPolicy(new DeleteDataPolicyDto
            {
                PolicyId = result.Data.List.First().PolicyId,
            });

            Assert.IsTrue(res.StatusCode == 200);
        }


    }

    public class DataResourceManagementTest_Batch_Test : ManagementClientBaseTest
    {
        private string code = "examplePermissionCode";
        private string name = "examplePermissionNamespace";
        private string description = "examplePermissionDescription";

        [SetUp]
        public async Task CreatePermissionNamespaceTest()
        {
            CreatePermissionNamespaceResponseDto result = await managementClient.CreatePermissionNamespace(new CreatePermissionNamespaceDto { Code = code, Name = name, Description = description });

            Assert.IsTrue(result.Data.Name == name);
        }

        [TearDown]
        public async Task DeletePermissionNamespaceTest()
        {
            IsSuccessRespDto result = await managementClient.DeletePermissionNamespace(new DeletePermissionNamespaceDto
            {
                Code = code
            });

            Assert.IsTrue(result.Data.Success);
        }

        [Test, Order(1)]
        public async Task CreatePermissionNamespacesBatchTest()
        {
            List<CreatePermissionNamespacesBatchItemDto> nameSpaceList = new List<CreatePermissionNamespacesBatchItemDto>();
            for (int i = 0; i < 3; i++)
            {
                CreatePermissionNamespacesBatchItemDto item = new CreatePermissionNamespacesBatchItemDto
                {
                    Code = code + i,
                    Name = name + i,
                    Description = description + i
                };

                nameSpaceList.Add(item);
            }

            IsSuccessRespDto dto = await managementClient.CreatePermissionNamespacesBatch(new CreatePermissionNamespacesBatchDto
            {
                List = nameSpaceList
            });

            Assert.IsTrue(dto.Data.Success);
        }

        [Test, Order(2)]
        public async Task GetPermissionNamespacesBatchTest()
        {
            GetPermissionNamespaceListResponseDto result = await managementClient.GetPermissionNamespacesBatch(new GetPermissionNamespacesBatchDto
            {
                Codes = $"{code}0,{code}1,{code}2"
            });

            Assert.IsTrue(result.Data.Count == 3);
        }

        [Test, Order(3)]
        public async Task ListPermissionNamespacesTest()
        {
            PermissionNamespaceListPaginatedRespDto result = await managementClient.ListPermissionNamespaces(new ListPermissionNamespacesDto
            {
                Page = 1,
                Limit = 1,
            });

            Assert.IsTrue(result.Data.TotalCount > 0);
        }

        [Test, Order(4)]
        public async Task DeletePermissionNamespacesBatchTest()
        {
            IsSuccessRespDto result = await managementClient.DeletePermissionNamespacesBatch(new DeletePermissionNamespacesBatchDto
            {
                Codes = new List<string>
                {
                    $"{code}0",
                    $"{code}1",
                    $"{code}2",
                }
            });

            Assert.IsTrue(result.Data.Success);
        }
    }


}
