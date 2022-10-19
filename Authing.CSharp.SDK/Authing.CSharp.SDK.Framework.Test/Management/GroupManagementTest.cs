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
    class GroupManagementTest : ManagementClientBaseTest
    {
        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetGroupTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                GroupSingleRespDto dto = await managementClient.GetGroup(new GetGroupDto { Code = "developerUpdate" });

                Assert.IsTrue(dto.Data.Code == "developerUpdate");
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListGroupsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                GroupPaginatedRespDto dto = await managementClient.ListGroups(new ListGroupsDto { Page = 1, Limit = 10 });

                Assert.IsTrue(dto.Data.TotalCount > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
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

                Assert.IsTrue(dto.Data.Code == "developer");
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateGroupsBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                List<CreateGroupReqDto> group = new List<CreateGroupReqDto>()
                {
                    new CreateGroupReqDto()
                    {
                        Name = "developer" +new Random().Next(10,1000),
                        Code = "developer"+new Random().Next(10,100) ,
                        Description = "V3 测试添加 Group"
                    }
                };


                CreateGroupBatchReqDto reqDto = new CreateGroupBatchReqDto()
                {
                    List = group
                };

                GroupListRespDto dto = await managementClient.CreateGroupsBatch(reqDto);

                Assert.IsTrue(dto.Data.Count == 1);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateGroupTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UpdateGroupReqDto dto = new UpdateGroupReqDto()
                {
                    Name = "开发者",
                    Code = "developer",
                    Description = "developer 描述内容",
                    NewCode = "developerUpdate"
                };

                GroupSingleRespDto groupSingle = await managementClient.UpdateGroup(dto);

                Assert.IsTrue(groupSingle.Data.Code == "developerUpdate");
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteGroupsBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DeleteGroupsReqDto dto = new DeleteGroupsReqDto()
                {
                    CodeList = new List<string> { "developer", "developer57" }
                };

                IsSuccessRespDto isSuccess = await managementClient.DeleteGroupsBatch(dto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task AddGroupMembersTest()
        {

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                AddGroupMembersReqDto dto = new AddGroupMembersReqDto()
                {
                    Code = "developerUpdate",
                    UserIds = new List<string> { "634cf7171d4ac32dbd620893"}
                };

                IsSuccessRespDto isSuccess = await managementClient.AddGroupMembers(dto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task RemoveGroupMembersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                RemoveGroupMembersReqDto dto = new RemoveGroupMembersReqDto()
                {
                    Code = "developerUpdate",
                    UserIds = new List<string> { "634cf7171d4ac32dbd620893" }
                };

                IsSuccessRespDto isSuccess = await managementClient.RemoveGroupMembers(dto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListGroupMembersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string code = "developerUpdate";

                UserPaginatedRespDto isSuccess = await managementClient.ListGroupMembers(new ListGroupMembersDto { Code = code });

                Assert.IsTrue(isSuccess.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetGroupAuthorizedResourcesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string code = "developerUpdate";

                AuthorizedResourceListRespDto dto = await managementClient.GetGroupAuthorizedResources(new GetGroupAuthorizedResourcesDto { Code = code, Namespace = "634cf98aa5b1455a52949d33" });

                Assert.IsTrue(dto.Data.Count == 1);
            }
        }
    }
}
