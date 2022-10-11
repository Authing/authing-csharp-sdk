using Authing.CSharp.SDK.Models.Management;
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
    class GroupManagementTest: ManagementClientBaseTest
    {

        [Test]
        public async Task GetGroupTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                GroupSingleRespDto dto =await managementClient.GetGroup("testgroup_Add111");

                Assert.IsTrue(dto.Data.Name == "testgroup_Add");
            }
        }

        [Test]
        public async Task ListGroupsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                GroupPaginatedRespDto dto =await managementClient.ListGroups("");

                Assert.IsTrue(dto.Data.TotalCount > 0);
            }
        }

        [Test]
        public async Task CreateGroupTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateGroupReqDto createGroupReqDto = new CreateGroupReqDto()
                {
                    Name = "developer",
                    Code = "开发者",
                    Description = "描述内容"
                };

                GroupSingleRespDto dto =await managementClient.CreateGroup(createGroupReqDto);

                Assert.IsTrue(dto.Data.Name == "developer");
            }
        }

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
                        Code = "开发者"+new Random().Next(10,100) ,
                        Description = "V3 测试添加 Group"
                    }
                };


                CreateGroupBatchReqDto reqDto = new CreateGroupBatchReqDto()
                {
                    List = group
                };

                GroupListRespDto dto =await managementClient.CreateGroupsBatch(reqDto);

                Assert.IsTrue(dto.Data.Count == 1);
            }
        }

        [Test]
        public async Task UpdateGroupTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UpdateGroupReqDto dto = new UpdateGroupReqDto()
                {
                    Name = "developer",
                    Code = "开发者",
                    Description = "developer 描述内容",
                    NewCode = "developerUpdate"
                };

                GroupSingleRespDto groupSingle =await managementClient.UpdateGroup(dto);

                Assert.IsTrue(groupSingle.Data.Code == "developerUpdate");
            }
        }

        [Test]
        public async Task DeleteGroupsBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DeleteGroupsReqDto dto = new DeleteGroupsReqDto()
                {
                    CodeList = new List<string> { "developer","developer252","developer673" }
                };

                IsSuccessRespDto isSuccess =await managementClient.DeleteGroupsBatch(dto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        [Test]
        public async Task AddGroupMembersTest()
        {

            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                AddGroupMembersReqDto dto = new AddGroupMembersReqDto()
                {
                    Code = "testgroup_Add",
                    UserIds = new List<string> { "629856a0220b550326eefd08", "629856a0171160160a445c62" }
                };

                IsSuccessRespDto isSuccess =await managementClient.AddGroupMembers(dto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        [Test]
        public async Task RemoveGroupMembersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                RemoveGroupMembersReqDto dto = new RemoveGroupMembersReqDto()
                {
                    Code = "testgroup_Add",
                    UserIds = new List<string> { "629856a0220b550326eefd08", "629856a0171160160a445c62" }
                };

                IsSuccessRespDto isSuccess =await managementClient.RemoveGroupMembers(dto);

                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        [Test]
        public async Task ListGroupMembersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string code = "testgroup_Add";

                UserPaginatedRespDto isSuccess =await managementClient.ListGroupMembers(code);

                Assert.IsTrue(isSuccess.Data.List.Count > 0);
            }
        }

        [Test]
        public async Task GetGroupAuthorizedResourcesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string code = "testgroup_Add";

                AuthorizedResourceListRespDto dto =await managementClient.GetGroupAuthorizedResources(code, "testNameSpace2");

                Assert.IsTrue(dto.Data.Count == 1);
            }
        }
    }
}
