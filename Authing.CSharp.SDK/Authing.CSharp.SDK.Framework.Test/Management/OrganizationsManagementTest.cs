using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Services;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.UtilsImpl;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test
{
    [TestFixture]
    class Organizations_Orgs_Test : ManagementClientBaseTest
    {
        private OrganizationDto organizationDto;

        [OneTimeSetUp]
        public async Task CreateOrg()
        {
            CreateOrganizationReqDto reqDto = new CreateOrganizationReqDto()
            {
                OrganizationCode = "steamory",
                OrganizationName = "蒸汽记忆",
                Description = "组织描述信息",
            };

            OrganizationSingleRespDto dto = await managementClient.CreateOrganization(reqDto);

            organizationDto = dto.Data;
        }

        [OneTimeTearDown]
        public async Task DeleteOrg()
        {
            DeleteOrganizationReqDto reqDto = new DeleteOrganizationReqDto()
            {
                OrganizationCode = organizationDto.OrganizationCode
            };

            IsSuccessRespDto result = await managementClient.DeleteOrganization(reqDto);
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListOrganizations_Return_GreaterThan_0()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                OrganizationPaginatedRespDto dto = await managementClient.ListOrganizations(new ListOrganizationsDto { });

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-11-2 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetOrganizationTest()
        {
            OrganizationSingleRespDto dto = await managementClient.GetOrganization(new GetOrganizationDto
            {
                OrganizationCode = organizationDto.OrganizationCode
            });

            Assert.NotNull(dto.Data);
        }

        /// <summary>
        /// 2022-11-2 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetOrganizationsBatchTest()
        {
            OrganizationListRespDto dto = await managementClient.GetOrganizationsBatch(new GetOrganizationBatchDto
            {
                OrganizationCodeList = organizationDto.OrganizationCode,
            });

            Assert.NotNull(dto.Data);
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateOrganizationTest()
        {
            UpdateOrganizationReqDto reqDto = new UpdateOrganizationReqDto()
            {
                OrganizationCode = organizationDto.OrganizationCode,
                OrganizationName = "蒸汽记忆",
                OrganizationNewCode = "newSteamory"
            };

            OrganizationSingleRespDto dto = await managementClient.UpdateOrganization(reqDto);

            organizationDto = dto.Data;

            Assert.IsTrue(dto.Data.OrganizationCode == "newSteamory");

        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [TestCase("蒸汽记忆")]
        public async Task SearchOrganizationsTest(string keyword)
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //蒸汽记忆
                OrganizationPaginatedRespDto respDto = await managementClient.SearchOrganizations(new SearchOrganizationsDto { Keywords = keyword });
                Assert.IsTrue(respDto.Data.TotalCount > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateDepartmentTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                CreateDepartmentReqDto reqDto = new CreateDepartmentReqDto()
                {
                    ParentDepartmentId = organizationDto.DepartmentId,
                    OrganizationCode = organizationDto.OrganizationCode,
                    Code = "9999",
                    Name = "开发部",
                    Description = "技术研发部门",
                    OpenDepartmentId = Guid.NewGuid().ToString("N"),
                    DepartmentIdType = CreateDepartmentReqDto.departmentIdType.DEPARTMENT_ID

                };

                DepartmentSingleRespDto dto = await managementClient.CreateDepartment(reqDto);

                Assert.IsTrue(dto.Data.Name == "开发部");

            }
        }



    }

    [TestFixture]
    class Organizations_Department_Test : ManagementClientBaseTest
    {
        private OrganizationDto organizationDto;
        private DepartmentDto departmentDto;

        [OneTimeSetUp]
        public async Task CreateDepartment()
        {
            //先建立组织结构
            await managementClient.DeleteOrganization(new DeleteOrganizationReqDto 
            {
                OrganizationCode="steamory"
            });

            CreateOrganizationReqDto reqDto = new CreateOrganizationReqDto()
            {
                OrganizationCode = "steamory",
                OrganizationName = "蒸汽记忆",
                Description = "组织描述信息",
            };

            OrganizationSingleRespDto dto = await managementClient.CreateOrganization(reqDto);

            

            organizationDto = dto.Data;

            CreateDepartmentReqDto createDepartmentReqDto = new CreateDepartmentReqDto()
            {
                ParentDepartmentId = organizationDto.DepartmentId,
                OrganizationCode = organizationDto.OrganizationCode,
                Code = "9999",
                Name = "开发部",
                Description = "技术研发部门",
                OpenDepartmentId = Guid.NewGuid().ToString("N"),
                DepartmentIdType = CreateDepartmentReqDto.departmentIdType.DEPARTMENT_ID

            };

            DepartmentSingleRespDto departmentSingleRespDto = await managementClient.CreateDepartment(createDepartmentReqDto);

            departmentDto = departmentSingleRespDto.Data;
        }

        [OneTimeTearDown]
        public async Task DeleteDepartment()
        {
            //先删除部门，再删除组织机构
            DeleteDepartmentReqDto reqDto = new DeleteDepartmentReqDto()
            {

                OrganizationCode = organizationDto.OrganizationCode,
                DepartmentId = organizationDto.DepartmentId,
                DepartmentIdType = DeleteDepartmentReqDto.departmentIdType.DEPARTMENT_ID
            };

            IsSuccessRespDto isSuccess = await managementClient.DeleteDepartment(reqDto);


            DeleteOrganizationReqDto deleteOrganizationReqDto = new DeleteOrganizationReqDto()
            {
                OrganizationCode = organizationDto.OrganizationCode
            };

            IsSuccessRespDto result = await managementClient.DeleteOrganization(deleteOrganizationReqDto);
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(1)]
        public async Task GetDepartment_Return_Department_Test()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DepartmentSingleRespDto dto = await managementClient.GetDepartment(new GetDepartmentDto { DepartmentCode = departmentDto.Code, OrganizationCode = organizationDto.OrganizationCode });

                Assert.IsTrue(dto.Data != null);
            }
        }


        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(3)]
        public async Task UpdateDepartmentTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                UpdateDepartmentReqDto reqDto = new UpdateDepartmentReqDto()
                {
                    ParentDepartmentId = organizationDto.DepartmentId,
                    DepartmentId = departmentDto.DepartmentId,
                    OrganizationCode = organizationDto.OrganizationCode,
                    Code = departmentDto.Code,
                    Name = "开发部_Update",
                    Description = "技术研发部门_Update",
                    DepartmentIdType = UpdateDepartmentReqDto.departmentIdType.DEPARTMENT_ID
                };

                DepartmentSingleRespDto dto = await managementClient.UpdateDepartment(reqDto);

                Assert.IsTrue(dto.Data.Name == "开发部_Update");
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(2)]
        public async Task SearchDepartments_Return_GreaterThan_0_Test()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                SearchDepartmentsReqDto reqDto = new SearchDepartmentsReqDto()
                {

                    Keywords = departmentDto.Name,
                    OrganizationCode = organizationDto.OrganizationCode
                };

                DepartmentListRespDto respDto = await managementClient.SearchDepartments(reqDto);
                Assert.IsTrue(respDto.Data.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(4)]
        public async Task ListChildrenDepartments_Return_0_()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //"steamory", "62986a99952bfd28c4f6afbe"
                DepartmentPaginatedRespDto respDto = await managementClient.ListChildrenDepartments(new ListChildrenDepartmentsDto
                {
                    OrganizationCode = organizationDto.OrganizationCode,
                    DepartmentId = departmentDto.DepartmentId
                });
                Assert.IsTrue(respDto.Data.List.Count == 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 列出部门成员
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(5)]
        public async Task ListDepartmentMembers_Return_0()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UserPaginatedRespDto respDto = await managementClient.ListDepartmentMembers(new ListDepartmentMembersDto
                {
                    DepartmentId = departmentDto.DepartmentId,
                    DepartmentIdType = "department_id",
                    OrganizationCode = organizationDto.OrganizationCode
                });
                Assert.IsTrue(respDto.Data.List.Count == 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(6)]
        public async Task ListDepartmentsMemebersIdsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                var respDto = await managementClient.ListDepartmentMemberIds(new ListDepartmentMemberIdsDto
                {
                    DepartmentId = departmentDto.DepartmentId,
                    OrganizationCode = organizationDto.OrganizationCode
                });
                Assert.IsTrue(respDto != null);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 获取父部门
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetParentDepartmentTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //新建一个部门
                CreateDepartmentReqDto reqDto = new CreateDepartmentReqDto()
                {
                    ParentDepartmentId = departmentDto.DepartmentId,
                    OrganizationCode = organizationDto.OrganizationCode,
                    Code = "0001",
                    Name = "开发部_New",
                    Description = "技术研发部门",
                    OpenDepartmentId = Guid.NewGuid().ToString("N"),
                    DepartmentIdType = CreateDepartmentReqDto.departmentIdType.DEPARTMENT_ID

                };

                DepartmentSingleRespDto dto = await managementClient.CreateDepartment(reqDto);

                Assert.IsTrue(dto.StatusCode == 200);

                DepartmentSingleRespDto respDto = await managementClient.GetParentDepartment(new GetParentDepartmentDto { DepartmentId = departmentDto.DepartmentId, OrganizationCode = organizationDto.OrganizationCode });
                Assert.IsTrue(respDto.Data.DepartmentId != null);
            }
        }
    }

    class Organizations_Department_Delete_Test : ManagementClientBaseTest
    {


        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteDepartmentTest()
        {
            OrganizationDto organizationDto;
            DepartmentDto departmentDto;

            CreateOrganizationReqDto reqDto = new CreateOrganizationReqDto()
            {
                OrganizationCode = "steamory",
                OrganizationName = "蒸汽记忆",
                Description = "组织描述信息",
            };

            OrganizationSingleRespDto dto = await managementClient.CreateOrganization(reqDto);

            organizationDto = dto.Data;

            CreateDepartmentReqDto createDepartmentReqDto = new CreateDepartmentReqDto()
            {
                ParentDepartmentId = organizationDto.DepartmentId,
                OrganizationCode = organizationDto.OrganizationCode,
                Code = "9999",
                Name = "开发部",
                Description = "技术研发部门",
                OpenDepartmentId = Guid.NewGuid().ToString("N"),
                DepartmentIdType = CreateDepartmentReqDto.departmentIdType.DEPARTMENT_ID

            };

            DepartmentSingleRespDto departmentSingleRespDto = await managementClient.CreateDepartment(createDepartmentReqDto);

            departmentDto = departmentSingleRespDto.Data;


            DeleteDepartmentReqDto deleteDepartmentReqDto = new DeleteDepartmentReqDto()
            {
                OrganizationCode = organizationDto.OrganizationCode,
                DepartmentId = departmentDto.DepartmentId,
                DepartmentIdType = DeleteDepartmentReqDto.departmentIdType.DEPARTMENT_ID
            };

            IsSuccessRespDto isSuccess = await managementClient.DeleteDepartment(deleteDepartmentReqDto);

            Assert.IsTrue(isSuccess.Data.Success);

            //后续删除组织机构

            DeleteOrganizationReqDto deleteOrganizationReqDto = new DeleteOrganizationReqDto
            {
                OrganizationCode = organizationDto.OrganizationCode
            };

            IsSuccessRespDto isSuccessRespDto = await managementClient.DeleteOrganization(deleteOrganizationReqDto);

            Assert.IsTrue(isSuccess.Data.Success);

        }
    }

    class Organization_Member_Test : ManagementClientBaseTest
    {
        private OrganizationDto organizationDto;
        private DepartmentDto departmentDto;

        private UserDto newAddUserOne;

        private UserDto newAddUserTwo;

        /// <summary>
        /// 新建用户
        /// </summary>
        /// <returns></returns>
        public async Task CreateUser()
        {
            CreateUserReqDto dto = new CreateUserReqDto()
            {
                Username = "testUser" + new Random().Next(200, 1000),
                Name="qidong",
                Status = CreateUserReqDto.status.ACTIVATED,
                Password = "password",
                Options = new CreateUserOptionsDto { DepartmentIdType = CreateUserOptionsDto.departmentIdType.DEPARTMENT_ID }
            };

            UserSingleRespDto userSingleRespDto = await managementClient.CreateUser(dto);

            newAddUserOne = userSingleRespDto.Data;

            dto = new CreateUserReqDto()
            {
                Username = "testUser" + new Random().Next(200, 1000),
                Status = CreateUserReqDto.status.ACTIVATED,
                Password = "password",
                Options = new CreateUserOptionsDto { DepartmentIdType = CreateUserOptionsDto.departmentIdType.DEPARTMENT_ID }
            };

            userSingleRespDto = await managementClient.CreateUser(dto);

            newAddUserTwo = userSingleRespDto.Data;

        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <returns></returns>
        public async Task DeleteUser()
        {
            var result = await managementClient.DeleteUsersBatch(new DeleteUsersBatchDto
            {
                UserIds = new List<string> { newAddUserOne.UserId, newAddUserTwo.UserId }
            });
        }

        [OneTimeSetUp]
        public async Task CreateDepartment()
        {
            //先建立组织结构

            await managementClient.DeleteOrganization(new DeleteOrganizationReqDto { OrganizationCode = "steamory" });

            CreateOrganizationReqDto reqDto = new CreateOrganizationReqDto()
            {
                OrganizationCode = "steamory",
                OrganizationName = "蒸汽记忆",
                Description = "组织描述信息",
            };

            OrganizationSingleRespDto dto = await managementClient.CreateOrganization(reqDto);

            organizationDto = dto.Data;

            CreateDepartmentReqDto createDepartmentReqDto = new CreateDepartmentReqDto()
            {
                ParentDepartmentId = organizationDto.DepartmentId,
                OrganizationCode = organizationDto.OrganizationCode,
                Code = "9999",
                Name = "开发部",
                Description = "技术研发部门",
                OpenDepartmentId = Guid.NewGuid().ToString("N"),
                DepartmentIdType = CreateDepartmentReqDto.departmentIdType.DEPARTMENT_ID

            };

            DepartmentSingleRespDto departmentSingleRespDto = await managementClient.CreateDepartment(createDepartmentReqDto);

            //添加用户用于测试

            departmentDto = departmentSingleRespDto.Data;

            await CreateUser();
        }

        [OneTimeTearDown]
        public async Task DeleteDepartment()
        {
            //先删除部门，再删除组织机构
            DeleteDepartmentReqDto reqDto = new DeleteDepartmentReqDto()
            {

                OrganizationCode = organizationDto.OrganizationCode,
                DepartmentId = organizationDto.DepartmentId,
                DepartmentIdType = DeleteDepartmentReqDto.departmentIdType.DEPARTMENT_ID
            };

            IsSuccessRespDto isSuccess = await managementClient.DeleteDepartment(reqDto);


            DeleteOrganizationReqDto deleteOrganizationReqDto = new DeleteOrganizationReqDto()
            {
                OrganizationCode = organizationDto.OrganizationCode
            };

            IsSuccessRespDto result = await managementClient.DeleteOrganization(deleteOrganizationReqDto);

            await DeleteUser();
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(1)]
        public async Task AddDepartmentsMemebersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                AddDepartmentMembersReqDto addDepartmentMembersReqDto = new AddDepartmentMembersReqDto()
                {
                    DepartmentId = departmentDto.DepartmentId,
                    OrganizationCode = organizationDto.OrganizationCode,
                    UserIds = new List<string> { newAddUserOne.UserId, newAddUserTwo.UserId }
                };

                IsSuccessRespDto respDto = await managementClient.AddDepartmentMembers(addDepartmentMembersReqDto);
                Assert.IsTrue(respDto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(2)]
        public async Task IsUserInDepartmentTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                IsUserInDepartmentRespDto respDto = await managementClient.IsUserInDepartment(new IsUserInDepartmentDto
                {
                    UserId = newAddUserOne.UserId,
                    DepartmentId = departmentDto.DepartmentId,
                    OrganizationCode = organizationDto.OrganizationCode
                });
                Assert.IsTrue(respDto.Data.InDepartment);
            }
        }

        /// <summary>
        /// 2022-11-1 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [TestCase("qidong")]
        [Order(3)]
        public async Task SearchDepartmentMemebersTest(string keyword)
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UserPaginatedRespDto respDto = await managementClient.SearchDepartmentMembers(new SearchDepartmentMembersDto
                {
                    DepartmentId = departmentDto.DepartmentId,
                    DepartmentIdType = "department_id",
                    Keywords = keyword,
                    OrganizationCode = organizationDto.OrganizationCode
                });
                Assert.IsTrue(respDto.Data.TotalCount > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(4)]
        public async Task RemoveDepartmentsMemebersTest()
        {

            //先让员工离职
            var res = await managementClient.ResignUserBatch(new ResignUserBatchReqDto
            {
                UserIds = new List<string> { newAddUserOne.UserId, newAddUserTwo.UserId }
            });

            RemoveDepartmentMembersReqDto remove = new RemoveDepartmentMembersReqDto()
            {
                DepartmentId = departmentDto.DepartmentId,
                OrganizationCode = organizationDto.OrganizationCode,
                UserIds = new List<string> { newAddUserOne.UserId, newAddUserTwo.UserId }
            };

            IsSuccessRespDto respDto = await managementClient.RemoveDepartmentMembers(remove);
            Assert.IsTrue(respDto.Data.Success);

        }


    


    }

    class OrganizationsManagementTest : ManagementClientBaseTest
    {

        [Test]
        public async Task SearchDepartmentTest()
        {
            try
            {
                var res = await managementClient.SearchDepartmentsList(new SearchDepartmentsListReqDto { OrganizationCode = "OU=Root,DC=oldDomain,DC=com", Page = 1, Limit = 10 });

                Assert.NotNull(res);
            }
            catch (Exception exp)
            { 
            
            }
        }

        [Test]
        public async Task ListOrganzationsTest()
        {
            try
            {
                var res = await managementClient.ListOrganizations(new ListOrganizationsDto { });

                Assert.NotNull(res);
            }
            catch (Exception exp)
            { 
            
            }
        }

        [Test]
        public async Task ListChildrenDepartmentsTest()
        {
            try
            {
                var res = await managementClient.ListChildrenDepartments(new  ListChildrenDepartmentsDto { OrganizationCode = "OU=Root,DC=oldDomain,DC=com",DepartmentId= "634239c95686281a4d4d627f" });

                Assert.NotNull(res);
            }
            catch (Exception exp)
            {

            }
        }




    }
}
