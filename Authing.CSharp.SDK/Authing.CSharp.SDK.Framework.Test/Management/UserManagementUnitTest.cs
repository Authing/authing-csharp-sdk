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
    class UserManagementUnitTest : ManagementClientBaseTest
    {
        private UserDto newAddUser;

        /// <summary>
        /// 新建用户
        /// </summary>
        /// <returns></returns>
        //[SetUp,Category("user")]
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

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <returns></returns>
        //[TearDown]
        public async Task DeleteUser()
        {
            var result = await managementClient.DeleteUsersBatch(new DeleteUsersBatchDto
            {
                UserIds = new List<string> { newAddUser.UserId }
            });
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 通过批量获取用户获取新增的用户
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task Get_NewAddUser_Single_With_Batch_Return()
        {
            string userIds = newAddUser.UserId;

            UserListRespDto userListRespDto = await managementClient.GetUserBatch(new GetUserBatchDto { UserIds = userIds });

            Assert.IsTrue(userListRespDto.Data.Count > 0);

        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 获取/搜索用户列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListUsers_Return_GreaterThan_0()
        {
            UserPaginatedRespDto userPaginatedRespDto = await managementClient.ListUsers(new ListUsersRequestDto
            {
                Options = new ListUsersOptionsDto
                {
                    Pagination = new PaginationDto
                    {
                        Limit = 50,
                        Page = 1
                    }
                }
            });

            Assert.IsTrue(userPaginatedRespDto.Data.TotalCount > 0);

        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 获取用户的外部身份源
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserIdentitiesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string userId = "6218475c2373a54088a786b2";

                IdentityListRespDto identityListRespDto = await managementClient.GetUserIdentities(new GetUserIdentitiesDto { UserId = userId });

                Assert.IsTrue(identityListRespDto.Data == null);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 获取用户的角色列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserRolesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                //

                RolePaginatedRespDto rolePaginatedRespDto = await managementClient.GetUserRoles(new GetUserRolesDto
                { UserId = "63a2e832b61c94c3d356dd85", Namespace = "63981463f8d0a068ad0d9878" });

                Assert.IsTrue(rolePaginatedRespDto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-11-1 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserPrincipalAuthenticationInfoTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string userId = "6360bca83cf8e4e347b0747e ";

                PrincipalAuthenticationInfoPaginatedRespDto principalAuthenticationInfoPaginatedRespDto = await managementClient.GetUserPrincipalAuthenticationInfo(new GetUserPrincipalAuthenticationInfoDto { UserId = "2481452007@qq.com", UserIdType = "email" });

                Assert.IsTrue(principalAuthenticationInfoPaginatedRespDto.Data.TotalCount == 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ResetUserPrincipapAuthenticationInfoTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ResetUserPrincipalAuthenticationInfoDto resetUserPrincipalAuthenticationInfoDto = new ResetUserPrincipalAuthenticationInfoDto()
                {
                    UserId = "61c17bd024917805ae85e397"
                };

                IsSuccessRespDto isSuccessDto = await managementClient.ResetUserPrincipalAuthenticationInfo(resetUserPrincipalAuthenticationInfoDto);

                Assert.IsTrue(isSuccessDto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserDepartmentsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                UserDepartmentPaginatedRespDto userDepartmentPaginatedRespDto = await managementClient.GetUserDepartments(new GetUserDepartmentsDto { UserId = UserId });

                Assert.IsTrue(userDepartmentPaginatedRespDto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task SetUserDepartmentsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                SetUserDepartmentsDto setUserDepartmentDto = new SetUserDepartmentsDto()
                {
                    UserId = "634e4a4e0cc273a3f9c4543e",
                    Departments = new List<SetUserDepartmentDto>()
                    {
                        new SetUserDepartmentDto{ DepartmentId= "634e4e7fed93f436d0493528",
                    IsLeader=true,
                    IsMainDepartment=false}
                    }
                };

                IsSuccessRespDto isSuccessRespDto = await managementClient.SetUserDepartments(setUserDepartmentDto);

                Assert.IsTrue(isSuccessRespDto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserGroups()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                GroupPaginatedRespDto groupPaginatedRespDto = await managementClient.GetUserGroups(new GetUserGroupsDto { UserId = "634e4a4e0cc273a3f9c4543e" });

                Assert.IsTrue(groupPaginatedRespDto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task DeleteUsersBatch()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DeleteUsersBatchDto dto = new DeleteUsersBatchDto()
                {
                    UserIds = new List<string> { "634e4a4e0cc273a3f9c4543e", "634e4a42a27868cd8bfc54cd" }
                };

                IsSuccessRespDto isSuccessDto = await managementClient.DeleteUsersBatch(dto);

                Assert.IsTrue(isSuccessDto.Data.Success);
            }
        }

        [Test]
        public async Task GetUserMfaInfo()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                UserMfaSingleRespDto userMfaSingleRespDto = await managementClient.GetUserMfaInfo(new GetUserMfaInfoDto { UserId = UserId, UserIdType = "user_id" });

                Assert.IsTrue(userMfaSingleRespDto.Data.FaceMfaStatus == "disabled");
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListArchivedUsersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ListArchivedUsersSingleRespDto result = await managementClient.ListArchivedUsers(new ListArchivedUsersDto { });

                Assert.IsTrue(result.Data.TotalCount > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task KickUserTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                KickUsersDto kickUsersDto = new KickUsersDto()
                {
                    AppIds = new List<string> { "634e5637ea7c7e0e817ddfc7" },
                    UserId = "634e53bc7e8639080058c65a"
                };

                IsSuccessRespDto userSingleRespDto = await managementClient.KickUsers(kickUsersDto);

                Assert.IsTrue(userSingleRespDto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task IsUserExistsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                IsUserExistsReqDto dto = new IsUserExistsReqDto()
                {
                    Username = "test"
                };

                IsUserExistsRespDto userSingleRespDto = await managementClient.IsUserExists(dto);

                Assert.IsTrue(userSingleRespDto.Data.Exists);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateUserTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateUserReqDto dto = new CreateUserReqDto()
                {
                    Username = "qidong" + new Random().Next(200, 1000),
                    Status = CreateUserReqDto.status.ACTIVATED,
                    Password = "3866364",
                    Options = new CreateUserOptionsDto { DepartmentIdType = CreateUserOptionsDto.departmentIdType.DEPARTMENT_ID }
                };

                UserSingleRespDto userSingleRespDto = await managementClient.CreateUser(dto);

                Assert.IsTrue(userSingleRespDto.Data.Username == dto.Username);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CreateUsersBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateUserBatchReqDto reqDto = new CreateUserBatchReqDto()
                {
                    List = new List<CreateUserInfoDto> { new CreateUserInfoDto()
                    {
                        Username = "user1"+ new Random().Next(200,1000),
                        Status = CreateUserInfoDto.status.ACTIVATED,
                        Password = "password"
                    },
                    new CreateUserInfoDto()
                    {
                        Username = "user2"+new Random().Next(200,1000) ,
                        Status = CreateUserInfoDto.status.ACTIVATED,
                        Password = "password"
                    }},
                    Options = new CreateUserOptionsDto { KeepPassword = true, ResetPasswordOnFirstLogin = false }
                };



                UserListRespDto userListRespDto = await managementClient.CreateUsersBatch(reqDto);

                Assert.IsTrue(userListRespDto.Data.Count == 2);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateUserTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UpdateUserReqDto dto = new UpdateUserReqDto()
                {
                    UserId = "634e53bc7e8639080058c65a",
                    Name = "qidong",
                    Status = UpdateUserReqDto.status.ACTIVATED
                };



                UserSingleRespDto user = await managementClient.UpdateUser(dto);

                Assert.IsTrue(user.Data.Name == "qidong");
            }
        }

        /// <summary>
        /// 2022-11-2 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateUserBatchTest()
        {
            UserListRespDto dto = await managementClient.UpdateUserBatch(new UpdateUserBatchReqDto
            {
                List = new List<UpdateUserInfoDto>
                {
                    new UpdateUserInfoDto
                    {
                        UserId="6360bca83cf8e4e347b0747e",
                        Username="qidong2481452007",
                        Status=UpdateUserInfoDto.status.ACTIVATED
                    },
                    new UpdateUserInfoDto
                    {
                        UserId="62bc37200d0fc2db637e92ef",
                        Company="steamory",
                        Status=UpdateUserInfoDto.status.ACTIVATED
                    }
                }
            });

            Assert.IsTrue(dto.Data.Count > 0);
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserAccessibleAppsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = "634e53bc7e8639080058c65a";

                AppListRespDto appListResp = await managementClient.GetUserAccessibleApps(new GetUserAccessibleAppsDto { UserId = UserId });

                Assert.IsTrue(appListResp.Data.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserAuthorizedAppsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = "634e53bc7e8639080058c65a";

                AppListRespDto appListResp = await managementClient.GetUserAuthorizedApps(new GetUserAuthorizedAppsDto { UserId = UserId });

                Assert.IsTrue(appListResp.Data.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task HasAnyRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                HasAnyRoleReqDto dto = new HasAnyRoleReqDto()
                {
                    UserId = "634e53bc7e8639080058c65a",
                    Roles = new List<HasRoleRolesDto>() { new HasRoleRolesDto { Code = "Guest", Namespace = "634cf98aa5b1455a52949d33" } }
                };

                HasAnyRoleRespDto hasAnyRole = await managementClient.HasAnyRole(dto);

                Assert.IsFalse(hasAnyRole.Data.HasAnyRole);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// 获取用户历史登录数据
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserLoginHistoryTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = "62bc37200d0fc2db637e92ef";

                long beginTime = dateTimeService.DatetimeToUnixTimeMilllisecond(DateTime.Parse("2022-10-02 11:01:23"));
                long endTime = dateTimeService.DatetimeToUnixTimeMilllisecond(DateTime.Parse("2022-11-02 11:01:23"));


                UserLoginHistoryPaginatedRespDto dto = await managementClient.GetUserLoginHistory(new GetUserLoginHistoryDto { AppId = "62a9902a80f55c22346eb296", UserId = "62bc37200d0fc2db637e92ef", UserIdType = "user_id", Start = beginTime, End = endTime });

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserLoggedinAppsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                UserLoggedInAppsListRespDto dto = await managementClient.GetUserLoggedinApps(new GetUserLoggedinAppsDto { UserId = "634e53bc7e8639080058c65a" });

                Assert.IsTrue(dto.Data.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserAuthorizedResourcesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                AuthorizedResourcePaginatedRespDto dto = await managementClient.GetUserAuthorizedResources(new GetUserAuthorizedResourcesDto { UserId = "634e53bc7e8639080058c65a", Namespace = "634cf98aa5b1455a52949d33" });

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试通过
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserLoggedinIdentitiesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UserLoggedInIdentitiesRespDto dto = await managementClient.GetUserLoggedinIdentities(new GetUserLoggedInIdentitiesDto { UserId = "634e53bc7e8639080058c65a" });

                Assert.NotNull(dto.Data);
            }
        }



        /// <summary>
        /// 2022-11-1 测试通过
        /// 用户离职
        /// 需要用户先入职，才能办理离职
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ResignUserTest()
        {
            ResignUserRespDto dto = await managementClient.ResignUser(new ResignUserReqDto
            {
                UserId = "6360bca83cf8e4e347b0747e"
            });

            Assert.IsTrue(dto.Data.Success);
        }

        /// <summary>
        /// 2022-11-1 测试通过
        /// 批量离职用户
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ResignUserBatchTest()
        {
            ResignUserRespDto dto = await managementClient.ResignUserBatch(new ResignUserBatchReqDto
            {
                UserIds = new List<string> { "6360bca83cf8e4e347b0747e", "62bc37200d0fc2db637e92ef" }
            });

            Assert.IsTrue(dto.Data.Success);
        }

        /// <summary>
        /// 2022-11-1 测试通过
        /// 检查登录状态
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CheckSessionStatusTest()
        {
            CheckSessionStatusRespDto dto = await managementClient.CheckSessionStatus(new CheckSessionStatusDto
            {
                AppId = "62a9902a80f55c22346eb296",
                UserId = "62bc37200d0fc2db637e92ef"
            });

            Assert.Equals(200, dto.StatusCode);
        }

        /// <summary>
        /// Todo
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ImportOTP()
        {
            CommonResponseDto dto = await managementClient.ImportOtp(new ImportOtpReqDto
            {
                List = new List<ImportOtpItemDto>
                {
                    new ImportOtpItemDto
                    {
                        Otp=new ImportOtpItemDataDto
                        {
                            RecoveryCode="AUTHING_RECOVERY_CODE",
                            Secret="AUTHING_OTP_SECRET"
                        }
                    }
                }
            });
        }

        /// <summary>
        /// 2022-11-2 测试通过
        /// 获取用户列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ListUsersLegacyTest()
        {
            var dto = await managementClient.ListUsersLegacy(new ListUsersDto
            {

            });

            Assert.IsTrue(dto.Data.TotalCount > 0);
        }


    }
}
