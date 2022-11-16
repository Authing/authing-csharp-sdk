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
    class GroupManagement_Create_Group_Test : ManagementClientBaseTest
    {
        private GroupDto _groupDto;

        [OneTimeTearDown]
        public async Task DeleteGroup()
        {
            await managementClient.DeleteGroupsBatch(new DeleteGroupsReqDto
            {
                CodeList = new List<string> { _groupDto.Code }
            });
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(1)]
        public async Task CreateGroupTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateGroupReqDto createGroupReqDto = new CreateGroupReqDto()
                {
                    Name = "开发者",
                    Code = "developer",
                    Description = "描述内容"
                };

                GroupSingleRespDto dto = await managementClient.CreateGroup(createGroupReqDto);

                _groupDto = dto.Data;

                Assert.IsTrue(dto.Data.Code == "developer");
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(2)]
        [TestCase("developerUpdate")]
        public async Task UpdateGroupTest(string newCode)
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UpdateGroupReqDto dto = new UpdateGroupReqDto()
                {
                    Name = _groupDto.Name,
                    Code = _groupDto.Code,
                    Description = "developer 描述内容",
                    NewCode = newCode
                };

                GroupSingleRespDto groupSingle = await managementClient.UpdateGroup(dto);

                Assert.IsTrue(groupSingle.Data.Code == "developerUpdate");
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(3)]
        public async Task GetGroupTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                GroupSingleRespDto dto = await managementClient.GetGroup(new GetGroupDto { Code = "developerUpdate" });

                Assert.IsTrue(dto.Data.Code == "developerUpdate");
            }
        }


        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(4)]
        public async Task ListGroupsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                GroupPaginatedRespDto dto = await managementClient.ListGroups(new ListGroupsDto { Page = 1, Limit = 10 });

                Assert.IsTrue(dto.Data.TotalCount > 0);
            }
        }
    }

    class GroupManagementTest : ManagementClientBaseTest
    {
        private string groupCodeOne;
        private string groupCodeTwo;

        private UserDto user;
        public GroupManagementTest()
        {
            groupCodeOne = "developer" + new Random().Next(10, 1000);
            groupCodeTwo = "developer" + new Random().Next(10, 1000);
        }

        [OneTimeSetUp]
        public async Task AddUser()
        {
            CreateUserReqDto dto = new CreateUserReqDto()
            {
                Username = "testUser" + new Random().Next(200, 1000),
                Name = "qidong",
                Status = CreateUserReqDto.status.ACTIVATED,
                Password = "password",
                Options = new CreateUserOptionsDto { DepartmentIdType = CreateUserOptionsDto.departmentIdType.DEPARTMENT_ID }
            };

            UserSingleRespDto userSingleRespDto = await managementClient.CreateUser(dto);

            user = userSingleRespDto.Data;
        }

        [OneTimeTearDown]
        public async Task DeleteUser()
        {
            await managementClient.DeleteUsersBatch(new DeleteUsersBatchDto
            {
                UserIds = new List<string> { user.UserId }
            });
        }


        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(1)]
        public async Task CreateGroupsBatchTest()
        {

            List<CreateGroupReqDto> group = new List<CreateGroupReqDto>()
            {
                new CreateGroupReqDto()
                {
                    Name = groupCodeOne,
                    Code = groupCodeOne,
                    Description = "V3 测试添加 Group"
                },
                 new CreateGroupReqDto()
                {
                    Name = groupCodeTwo,
                    Code = groupCodeTwo,
                    Description = "V3 测试添加 Group"
                },
            };


            CreateGroupBatchReqDto reqDto = new CreateGroupBatchReqDto()
            {
                List = group
            };

            GroupListRespDto dto = await managementClient.CreateGroupsBatch(reqDto);

            Assert.IsTrue(dto.Data.Count == 1);

        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(2)]
        public async Task ListGroupMembersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string code = groupCodeOne;

                UserPaginatedRespDto isSuccess = await managementClient.ListGroupMembers(new ListGroupMembersDto { Code = code });

                Assert.IsTrue(isSuccess.Data.List.Count > 0);
            }
        }




        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(3)]
        public async Task AddGroupMembersTest()
        {

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                AddGroupMembersReqDto dto = new AddGroupMembersReqDto()
                {
                    Code = groupCodeOne,
                    UserIds = new List<string> { user.UserId }
                };

                IsSuccessRespDto isSuccess = await managementClient.AddGroupMembers(dto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(4)]
        public async Task RemoveGroupMembersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                RemoveGroupMembersReqDto dto = new RemoveGroupMembersReqDto()
                {
                    Code = groupCodeOne,
                    UserIds = new List<string> { user.UserId }
                };

                IsSuccessRespDto isSuccess = await managementClient.RemoveGroupMembers(dto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }



        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(5)]
        public async Task GetGroupAuthorizedResources_()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string code = groupCodeOne;

                //await managementClient.CreateResource(new CreateResourceDto 
                //{
                //    x
                //});

                AuthorizedResourceListRespDto dto = await managementClient.GetGroupAuthorizedResources
                    (
                    new GetGroupAuthorizedResourcesDto
                    {
                        Code = code,
                        Namespace = "634cf98aa5b1455a52949d33"
                    });

                Assert.IsTrue(dto.Data.Count == 1);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(6)]
        public async Task DeleteGroupsBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DeleteGroupsReqDto dto = new DeleteGroupsReqDto()
                {
                    CodeList = new List<string> { groupCodeOne, groupCodeTwo }
                };

                IsSuccessRespDto isSuccess = await managementClient.DeleteGroupsBatch(dto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

    }
}
