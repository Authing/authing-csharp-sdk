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
    class UserManagementUnitTest : ManagementClientBaseTest
    {
        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string userIds = "634e4a4e0cc273a3f9c4543e,634e4a42a27868cd8bfc54cd";

                UserListRespDto userListRespDto = managementClient.GetUserBatch(new GetUserBatchDto { UserIds = userIds }).Result;

                Assert.IsTrue(userListRespDto.Data.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void ListUsersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UserPaginatedRespDto userPaginatedRespDto = managementClient.ListUsers(new ListUsersRequestDto { }).Result;

                Assert.IsTrue(userPaginatedRespDto.Data.TotalCount > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserIdentitiesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string userId = "6218475c2373a54088a786b2";

                IdentityListRespDto identityListRespDto = managementClient.GetUserIdentities(new GetUserIdentitiesDto { UserId = userId }).Result;

                Assert.IsTrue(identityListRespDto.Data == null);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserRolesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                RolePaginatedRespDto rolePaginatedRespDto = managementClient.GetUserRoles(new GetUserRolesDto { UserId = "634e4a4e0cc273a3f9c4543e", Namespace = "634cf98aa5b1455a52949d33" }).Result;

                Assert.IsTrue(rolePaginatedRespDto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试未完成
        /// TODO:用户没有主体信息
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserPrincipalAuthenticationInfoTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string userId = "634e4a4e0cc273a3f9c4543e ";

                PrincipalAuthenticationInfoPaginatedRespDto principalAuthenticationInfoPaginatedRespDto = managementClient.GetUserPrincipalAuthenticationInfo(new GetUserPrincipalAuthenticationInfoDto { UserId = userId, UserIdType = "user_id" }).Result;

                Assert.IsTrue(principalAuthenticationInfoPaginatedRespDto.Data.TotalCount == 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void ResetUserPrincipapAuthenticationInfoTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ResetUserPrincipalAuthenticationInfoDto resetUserPrincipalAuthenticationInfoDto = new ResetUserPrincipalAuthenticationInfoDto()
                {
                    UserId = "61c17bd024917805ae85e397"
                };

                IsSuccessRespDto isSuccessDto = managementClient.ResetUserPrincipalAuthenticationInfo(resetUserPrincipalAuthenticationInfoDto).Result;

                Assert.IsTrue(isSuccessDto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserDepartmentsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                UserDepartmentPaginatedRespDto userDepartmentPaginatedRespDto = managementClient.GetUserDepartments(new GetUserDepartmentsDto { UserId = UserId }).Result;

                Assert.IsTrue(userDepartmentPaginatedRespDto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void SetUserDepartmentsTest()
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

                IsSuccessRespDto isSuccessRespDto = managementClient.SetUserDepartments(setUserDepartmentDto).Result;

                Assert.IsTrue(isSuccessRespDto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserGroups()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                GroupPaginatedRespDto groupPaginatedRespDto = managementClient.GetUserGroups(new GetUserGroupsDto { UserId = "634e4a4e0cc273a3f9c4543e" }).Result;

                Assert.IsTrue(groupPaginatedRespDto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void DeleteUsersBatch()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DeleteUsersBatchDto dto = new DeleteUsersBatchDto()
                {
                    UserIds = new List<string> { "634e4a4e0cc273a3f9c4543e", "634e4a42a27868cd8bfc54cd" }
                };

                IsSuccessRespDto isSuccessDto = managementClient.DeleteUsersBatch(dto).Result;

                Assert.IsTrue(isSuccessDto.Data.Success);
            }
        }

        [Test]
        public void GetUserMfaInfo()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                UserMfaSingleRespDto userMfaSingleRespDto = managementClient.GetUserMfaInfo(new GetUserMfaInfoDto { UserId = UserId }).Result;

                Assert.IsTrue(userMfaSingleRespDto.Data.FaceMfaStatus == "disabled");
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void ListArchivedUsersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ListArchivedUsersSingleRespDto result = managementClient.ListArchivedUsers(new ListArchivedUsersDto { }).Result;

                Assert.IsTrue(result.Data.TotalCount > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void KickUserTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                KickUsersDto kickUsersDto = new KickUsersDto()
                {
                    AppIds = new List<string> { "634e5637ea7c7e0e817ddfc7" },
                    UserId = "634e53bc7e8639080058c65a"
                };

                IsSuccessRespDto userSingleRespDto = managementClient.KickUsers(kickUsersDto).Result;

                Assert.IsTrue(userSingleRespDto.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void IsUserExistsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                IsUserExistsReqDto dto = new IsUserExistsReqDto()
                {
                    Username = "test"
                };

                IsUserExistsRespDto userSingleRespDto = managementClient.IsUserExists(dto).Result;

                Assert.IsTrue(userSingleRespDto.Data.Exists);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void CreateUserTest()
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

                UserSingleRespDto userSingleRespDto = managementClient.CreateUser(dto).Result;

                Assert.IsTrue(userSingleRespDto.Data.Username == dto.Username);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void CreateUsersBatchTest()
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



                UserListRespDto userListRespDto = managementClient.CreateUsersBatch(reqDto).Result;

                Assert.IsTrue(userListRespDto.Data.Count == 2);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void UpdateUserTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UpdateUserReqDto dto = new UpdateUserReqDto()
                {
                    UserId = "634e53bc7e8639080058c65a",
                    Name = "qidong",
                    Status = UpdateUserReqDto.status.ACTIVATED
                };



                UserSingleRespDto user = managementClient.UpdateUser(dto).Result;

                Assert.IsTrue(user.Data.Name == "qidong");
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserAccessibleAppsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = "634e53bc7e8639080058c65a";

                AppListRespDto appListResp = managementClient.GetUserAccessibleApps(new GetUserAccessibleAppsDto { UserId = UserId }).Result;

                Assert.IsTrue(appListResp.Data.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserAuthorizedAppsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = "634e53bc7e8639080058c65a";

                AppListRespDto appListResp = managementClient.GetUserAuthorizedApps(new GetUserAuthorizedAppsDto { UserId = UserId }).Result;

                Assert.IsTrue(appListResp.Data.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void HasAnyRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                HasAnyRoleReqDto dto = new HasAnyRoleReqDto()
                {
                    UserId = "634e53bc7e8639080058c65a",
                    Roles = new List<HasRoleRolesDto>() { new HasRoleRolesDto { Code = "Guest", Namespace = "634cf98aa5b1455a52949d33" } }
                };

                HasAnyRoleRespDto hasAnyRole = managementClient.HasAnyRole(dto).Result;

                Assert.IsFalse(hasAnyRole.Data.HasAnyRole);
            }
        }

        /// <summary>
        /// 2022-10-18 测试失败
        /// 获取到的数据为空
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserLoginHistoryTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = "634e53bc7e8639080058c65a";

                long beginTime = dateTimeService.DateTimeToTimestamp(DateTime.Parse("2020-12-12 00:00:00"));
                long endTime = dateTimeService.DateTimeToTimestamp(DateTime.Parse("2023-12-12 00:00:00"));

                UserLoginHistoryPaginatedRespDto dto = managementClient.GetUserLoginHistory(new GetUserLoginHistoryDto { UserId = UserId, Start = beginTime, End = endTime }).Result;

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserLoggedinAppsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                UserLoggedInAppsListRespDto dto = managementClient.GetUserLoggedinApps(new GetUserLoggedinAppsDto { UserId = "634e53bc7e8639080058c65a" }).Result;

                Assert.IsTrue(dto.Data.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetUserAuthorizedResourcesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                AuthorizedResourcePaginatedRespDto dto = managementClient.GetUserAuthorizedResources(new GetUserAuthorizedResourcesDto { UserId = "634e53bc7e8639080058c65a", Namespace = "634cf98aa5b1455a52949d33" }).Result;

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        /// <summary>
        /// 2022-10-18 测试完成
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
        /// TODO
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ResignUserTest()
        {
            ResignUserRespDto dto = await managementClient.ResignUser(new ResignUserReqDto { });

            Assert.NotNull(dto);
        }

        /// <summary>
        /// Todo
        /// </summary>
        /// <returns></returns>
        public async Task ResignUserBatchTest()
        {
            await managementClient.ResignUserBatch(new ResignUserBatchReqDto { });
        }

        /// <summary>
        /// Todo
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task CheckSessionStatusTest()
        {
            await managementClient.CheckSessionStatus(new CheckSessionStatusDto { });
        }

        /// <summary>
        /// Todo
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task ImportOTP()
        {
            await managementClient.ImportOtp(new ImportOtpReqDto { });
        }


    }
}
