using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test.Management
{
    public class PostManagementTest : ManagementClientBaseTest
    {
        [Test]
        public async Task ListPostTest()
        {
            PostPaginatedRespDto result = await managementClient.PostList(new ListPostDto
            {

            });

            Assert.NotNull(result);
        }

        [Test]
        public async Task GetPostTest()
        {
            GetPostRespDto createPostDto = await managementClient.GetPost(new GetPostDto
            {
                Code = "developer"
            });

            Assert.NotNull(createPostDto);
        }

        [Test]
        public async Task GetUserPostTest()
        {
            GetUserPostRespDto createPostDto = await managementClient.GetUserPost(new GetUserPostDto
            {
                UserId = "63a94268620524a784ba9e5e"
            });

            Assert.NotNull(createPostDto);
        }

        [Test]
        public async Task GetPostByIdTest()
        {
            GetPostRespDto getPostRespDto = await managementClient.GetPost(new GetPostDto
            {
                Code = "developer"
            });

            GetPostByIdRespDto postRespDto = await managementClient.GetPostById(new GetPostByIdListDto
            {
                IdList = new List<string> { getPostRespDto.Data.ID }
            });

            Assert.NotNull(postRespDto);
        }

        [Test]
        public async Task CreatePostTest()
        {
            CreatePostRespDto createPostRespDto = await managementClient.CreatePost(new CreatePostDto
            {
                Code = "developer1",
                DepartmentIdList = new List<string> { "640985fc47d78e7a3da46067" },
                Description = "负责程序的开发",
                Name = "研发"
            });

            Assert.NotNull(createPostRespDto);
        }

        [Test]
        public async Task UpdatePostTest()
        {
            UpdatePostRespDto createPostDto = await managementClient.UpdatePost(new CreatePostDto
            {
                Code = "developer",
                DepartmentIdList = new List<string> { "640985fc47d78e7a3da46067" },
                Description = "负责程序的开发新描述",
                Name = "研发的新名字"
            });

            Assert.NotNull(createPostDto);
        }

        [Test]
        public async Task UserConnectionPostTest()
        {
            GetPostRespDto createPostDto = await managementClient.GetPost(new GetPostDto
            {
                Code = "developer"
            });

            CommonResponseDto commonResponseDto = await managementClient.UserConnectionPost(new UserConnectionPostDto
            {
                PostId =createPostDto.Data.ID ,
                UserId = "63a94268620524a784ba9e5e"
            });

            Assert.NotNull(commonResponseDto);
        }

        [Test]
        public async Task RemovePostTest()
        {
            CommonResponseDto commonResponseDto = await managementClient.RemovePost(new RemovePostDto { Code = "developer" });

            Assert.NotNull(commonResponseDto);
        }
    }
}
