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

        [Test]
        public void GetUserBatchTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string userIds = "61c188ccfff26fef0ca6880d";

                UserListRespDto userListRespDto = managementClient.GetUserBatch(userIds).Result;

                Assert.IsTrue(userListRespDto.Data.Count == 2);
            }
        }

        [Test]
        public void ListUsersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UserPaginatedRespDto userPaginatedRespDto = managementClient.ListUsers().Result;

                Assert.IsTrue(userPaginatedRespDto.Data.TotalCount > 0);
            }
        }

        [Test]
        public void GetUserIdentitiesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string userId = "6218475c2373a54088a786b2";

                IdentityListRespDto identityListRespDto = managementClient.GetUserIdentities(userId).Result;

                Assert.IsTrue(identityListRespDto.Data == null);
            }
        }

        [Test]
        public void GetUserRolesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                RolePaginatedRespDto rolePaginatedRespDto = managementClient.GetUserRoles(UserOneId).Result;

                Assert.IsTrue(rolePaginatedRespDto.Data.List.Count > 0);
            }
        }

        [Test]
        public void GetUserPrincipalAuthenticationInfoTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string userId = "61c17bd024917805ae85e397 ";

                PrincipalAuthenticationInfoPaginatedRespDto principalAuthenticationInfoPaginatedRespDto = managementClient.GetUserPrincipalAuthenticationInfo(userId).Result;

                Assert.IsTrue(principalAuthenticationInfoPaginatedRespDto.Data.TotalCount == 0);
            }
        }

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

        [Test]
        public void GetUserDepartmentsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                UserDepartmentPaginatedRespDto userDepartmentPaginatedRespDto = managementClient.GetUserDepartments(UserId).Result;

                Assert.IsTrue(userDepartmentPaginatedRespDto.Data.List.Count > 0);
            }
        }

        [Test]
        public void SetUserDepartmentsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                SetUserDepartmentsDto setUserDepartmentDto = new SetUserDepartmentsDto()
                {
                    UserId = UserOneId,
                    Departments = new List<SetUserDepartmentDto>()
                    {
                        new SetUserDepartmentDto{ DepartmentId= "627a36de359b4f96f398af36",
                    IsLeader=true,
                    IsMainDepartment=false}
                    }
                };

                IsSuccessRespDto isSuccessRespDto = managementClient.SetUserDepartments(setUserDepartmentDto).Result;

                Assert.IsTrue(isSuccessRespDto.Data.Success);
            }
        }

        [Test]
        public void GetUserGroups()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                GroupPaginatedRespDto groupPaginatedRespDto = managementClient.GetUserGroups(UserId).Result;

                Assert.IsTrue(groupPaginatedRespDto.Data.List.Count > 0);
            }
        }

        [Test]
        public void DeleteUsersBatch()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                DeleteUsersBatchDto dto = new DeleteUsersBatchDto()
                {
                    UserIds = new List<string> { "6298544bff41baab480a6f40" }
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

                UserMfaSingleRespDto userMfaSingleRespDto = managementClient.GetUserMfaInfo(UserId).Result;

                Assert.IsTrue(userMfaSingleRespDto.Data.FaceMfaStatus == "disabled");
            }
        }

        [Test]
        public void ListArchivedUsersTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                ListArchivedUsersSingleRespDto result = managementClient.ListArchivedUsers().Result;

                Assert.IsTrue(result.Data.TotalCount > 0);
            }
        }

        [Test]
        public void KickUserTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                KickUsersDto kickUsersDto = new KickUsersDto()
                {
                    AppIds = new List<string> { "6215dd9277d6ef55dfab41f8" },
                    UserId = UserOneId
                };

                IsSuccessRespDto userSingleRespDto = managementClient.KickUsers(kickUsersDto).Result;

                Assert.IsTrue(userSingleRespDto.Data.Success);
            }
        }

        [Test]
        public void IsUserExistsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                IsUserExistsReqDto dto = new IsUserExistsReqDto()
                {
                    Username = "13348926753"
                };

                IsUserExistsRespDto userSingleRespDto = managementClient.IsUserExists(dto).Result;

                Assert.IsTrue(userSingleRespDto.Data.Exists);
            }
        }

        [Test]
        public void CreateUserTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                CreateUserReqDto dto = new CreateUserReqDto()
                {
                    Username = "qidong" + new Random().Next(200, 1000),
                    Status = CreateUserReqDto.status.ACTIVATED,
                    PasswordEncryptType = CreateUserReqDto.passwordEncryptType.NONE,
                    Password = "3866364",
                    Options = new CreateUserOptionsDto { DepartmentIdType = CreateUserOptionsDto.departmentIdType.DEPARTMENT_ID }
                };

                UserSingleRespDto userSingleRespDto = managementClient.CreateUser(dto).Result;

                Assert.IsTrue(userSingleRespDto.Data.Username == dto.Username);
            }
        }

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
                        PasswordEncryptType = CreateUserInfoDto.passwordEncryptType.NONE,
                        Password = "password"
                    },
                    new CreateUserInfoDto()
                    {
                        Username = "user2"+new Random().Next(200,1000) ,
                        Status = CreateUserInfoDto.status.ACTIVATED,
                        PasswordEncryptType = CreateUserInfoDto.passwordEncryptType.NONE,
                        Password = "password"
                    }},
                    Options = new CreateUserOptionsDto { KeepPassword = true, ResetPasswordOnFirstLogin = false }
                };



                UserListRespDto userListRespDto = managementClient.CreateUsersBatch(reqDto).Result;

                Assert.IsTrue(userListRespDto.Data.Count == 2);
            }
        }

        [Test]
        public void UpdateUserTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                UpdateUserReqDto dto = new UpdateUserReqDto()
                {
                    UserId = UserOneId,
                    Name = "qidong"
                };



                UserSingleRespDto user = managementClient.UpdateUser(dto).Result;

                Assert.IsTrue(user.Data.Name == "qidong");
            }
        }

        [Test]
        public void GetUserAccessibleAppsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                AppListRespDto appListResp = managementClient.GetUserAccessibleApps(UserId).Result;

                Assert.IsTrue(appListResp.Data.Count > 0);
            }
        }

        [Test]
        public void GetUserAuthorizedAppsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                AppListRespDto appListResp = managementClient.GetUserAuthorizedApps(UserId).Result;

                Assert.IsTrue(appListResp.Data.Count > 0);
            }
        }

        [Test]
        public void HasAnyRoleTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                HasAnyRoleReqDto dto = new HasAnyRoleReqDto()
                {
                    UserId = UserOneId,
                    Roles = new List<HasRoleRolesDto>()
                };

                HasAnyRoleRespDto hasAnyRole = managementClient.HasAnyRole(dto).Result;

                Assert.IsFalse(hasAnyRole.Data.HasAnyRole);
            }
        }

        [Test]
        public void GetUserLoginHistoryTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                long beginTime = dateTimeService.DateTimeToLongTimeStamp(DateTime.Parse("2020-12-12 00:00:00"));
                long endTime = dateTimeService.DateTimeToLongTimeStamp(DateTime.Parse("2023-12-12 00:00:00"));

                UserLoginHistoryPaginatedRespDto dto = managementClient.GetUserLoginHistory(UserId, null, null, "", beginTime, endTime).Result;

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        [Test]
        public void GetUserLoggedinAppsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                UserLoggedInAppsListRespDto dto = managementClient.GetUserLoggedinApps(UserId).Result;

                Assert.IsTrue(dto.Data.Count > 0);
            }
        }

        [Test]
        public void GetUserAuthorizedResourcesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                string UserId = UserOneId;

                AuthorizedResourcePaginatedRespDto dto = managementClient.GetUserAuthorizedResources(UserId, "default").Result;

                Assert.IsTrue(dto.Data.List.Count > 0);
            }
        }

        [Test]
        public async Task GetUserLoggedinIdentitiesTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
               UserLoggedInIdentitiesRespDto dto= await managementClient.GetUserLoggedinIdentities("62df936ca8070667353d3942");

                Assert.NotNull(dto.Data);
            }
        }



    }
}
