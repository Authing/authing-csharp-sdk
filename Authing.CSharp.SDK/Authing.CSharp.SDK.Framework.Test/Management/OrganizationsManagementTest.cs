using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Services;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.UtilsImpl;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test
{
    class OrganizationsManagementTest : ManagementClientBaseTest
    {
        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListOrganizationsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                OrganizationPaginatedRespDto dto = await managementClient.ListOrganizations(new ListOrganizationsDto { });

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateOrganizationTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                CreateOrganizationReqDto reqDto = new CreateOrganizationReqDto()
                {
                    OrganizationCode = "steamory",
                    OrganizationName = "蒸汽记忆",
                    Description = "组织描述信息",
                    OpenDepartmentId = "60b49eb83fd80adb96f26e68"
                };

                OrganizationSingleRespDto dto = await managementClient.CreateOrganization(reqDto);

                Assert.IsTrue(dto.Data.OrganizationName == "蒸汽记忆");
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateOrganizationTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                UpdateOrganizationReqDto reqDto = new UpdateOrganizationReqDto()
                {
                    OrganizationCode = "steamory",
                    OrganizationName = "蒸汽记忆",
                    OrganizationNewCode = "newSteamory"
                };

                OrganizationSingleRespDto dto = await managementClient.UpdateOrganization(reqDto);

                Assert.IsTrue(dto.Data.OrganizationCode == "newSteamory");
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteOrganizationTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                OrganizationPaginatedRespDto dto = await managementClient.ListOrganizations(new ListOrganizationsDto { });

                foreach (var item in dto.Data.List)
                {
                    DeleteOrganizationReqDto reqDto = new DeleteOrganizationReqDto()
                    {
                        OrganizationCode = item.OrganizationCode
                    };

                    IsSuccessRespDto result = managementClient.DeleteOrganization(reqDto).Result;

                }
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetDepartmentTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DepartmentSingleRespDto dto = await managementClient.GetDepartment(new GetDepartmentDto { DepartmentCode= "9527",OrganizationCode = "steamory" });

                Assert.IsTrue(dto.Data != null);
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
                    ParentDepartmentId = "634e6a074033a8c4fe39f873",
                    OrganizationCode = "steamory",
                    Code = "9999",
                    Name = "开发部",
                    Description = "技术研发部门",
                    OpenDepartmentId = "61b1caf3559b06c557799b37",
                    DepartmentIdType = CreateDepartmentReqDto.departmentIdType.DEPARTMENT_ID

                };

                DepartmentSingleRespDto dto = await managementClient.CreateDepartment(reqDto);

                Assert.IsTrue(dto.Data.Name == "开发部");
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateDepartmentTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                UpdateDepartmentReqDto reqDto = new UpdateDepartmentReqDto()
                {
                    ParentDepartmentId = "634e6a074033a8c4fe39f873",
                    DepartmentId = "634e6ab9f8e204e522c60dbe",
                    OrganizationCode = "steamory",
                    Code = "9999",
                    Name = "开发部Update",
                    Description = "技术研发部门Update",
                    LeaderUserIds = new List<string> { "634e53bc7e8639080058c65a" },
                    DepartmentIdType = UpdateDepartmentReqDto.departmentIdType.DEPARTMENT_ID
                };

                DepartmentSingleRespDto dto = await managementClient.UpdateDepartment(reqDto);

                Assert.IsTrue(dto.Data.Name == "开发部Update");
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteDepartmentTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DeleteDepartmentReqDto reqDto = new DeleteDepartmentReqDto()
                {

                    OrganizationCode = "steamory",
                    DepartmentId = "634e6ab9f8e204e522c60dbe",
                    DepartmentIdType = DeleteDepartmentReqDto.departmentIdType.DEPARTMENT_ID
                };

                IsSuccessRespDto isSuccess = await managementClient.DeleteDepartment(reqDto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task SearchDepartmentsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                SearchDepartmentsReqDto reqDto = new SearchDepartmentsReqDto()
                {

                    Keywords = "开发部",
                    OrganizationCode = "steamory"
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
        public async Task ListChildrenDepartmentsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //"steamory", "62986a99952bfd28c4f6afbe"
                DepartmentPaginatedRespDto respDto = await managementClient.ListChildrenDepartments(new ListChildrenDepartmentsDto {OrganizationCode="steamory",DepartmentId= "634e6a074033a8c4fe39f873" });
                Assert.IsTrue(respDto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListDepartmentMembersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
               // "629872091ab96fdcc3904085", "999"
                UserPaginatedRespDto respDto =await managementClient.ListDepartmentMembers(new ListDepartmentMembersDto {DepartmentId= "634e6a074033a8c4fe39f873",DepartmentIdType= "department_id", OrganizationCode= "steamory" });
                Assert.IsTrue(respDto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListDepartmentsMemebersIdsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //"629872091ab96fdcc3904085", "999"
                var respDto = await managementClient.ListDepartmentMemberIds(new ListDepartmentMemberIdsDto {DepartmentId= "634e6a074033a8c4fe39f873",OrganizationCode="steamory" });
                Assert.IsTrue(respDto != null);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task AddDepartmentsMemebersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                AddDepartmentMembersReqDto addDepartmentMembersReqDto = new AddDepartmentMembersReqDto()
                {
                    DepartmentId = "634e6ebe505d3a1d59cff9d6",
                    OrganizationCode = "steamory",
                    UserIds = new List<string> { "634e53a5aceca83ce91a4af1", "634cf7171d4ac32dbd620893" }
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
        public async Task RemoveDepartmentsMemebersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                RemoveDepartmentMembersReqDto remove = new RemoveDepartmentMembersReqDto()
                {
                    DepartmentId = "634e6ebe505d3a1d59cff9d6",
                    OrganizationCode = "steamory",
                    UserIds = new List<string> { "634e53a5aceca83ce91a4af1", "634cf7171d4ac32dbd620893" }
                };

                IsSuccessRespDto respDto = await managementClient.RemoveDepartmentMembers(remove);
                Assert.IsTrue(respDto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetParentDepartmentTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //"629872091ab96fdcc3904085", "999"
                DepartmentSingleRespDto respDto = await managementClient.GetParentDepartment(new GetParentDepartmentDto { DepartmentId= "634e6ebe505d3a1d59cff9d6",OrganizationCode="steamory" });
                Assert.IsTrue(respDto.Data.DepartmentId != null);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task IsUserInDepartmentTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //"630f01362bf642ea26e430fc", "steamory", "62df936ca8070667353d3942"
                IsUserInDepartmentRespDto respDto = await managementClient.IsUserInDepartment(new IsUserInDepartmentDto {UserId= "634e53a5aceca83ce91a4af1",DepartmentId= "634e6ebe505d3a1d59cff9d6",OrganizationCode="steamory" });
                Assert.IsTrue(respDto.Data.InDepartment);
            }
        }

        /// <summary>
        /// 2022-11-1 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task SearchDepartmentMemebersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UserPaginatedRespDto respDto = await managementClient.SearchDepartmentMembers(new SearchDepartmentMembersDto { DepartmentId= "62f49ebfe31a861ac9cca20e", DepartmentIdType= "department_id", Keywords="qidong",OrganizationCode="steamory" });
                Assert.IsTrue(respDto.Data.TotalCount>0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task SearchOrganizationsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //蒸汽记忆
                OrganizationPaginatedRespDto respDto = await managementClient.SearchOrganizations(new SearchOrganizationsDto { Keywords="蒸汽记忆"});
                Assert.IsTrue(respDto.Data.TotalCount > 0);
            }
        }



    }
}
