using Authing.CSharp.SDK.Extensions;
using Authing.CSharp.SDK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Services
{
    public class ManagementClient : BaseManagementService
    {
        /// <summary>
        /// 初始化管理服务
        /// </summary>
        /// <param name="accessKeyId ">用户池 ID</param>
        /// <param name="accessKeySecret ">用户池密钥</param>
        public ManagementClient(ManagementClientOptions options) : base(options)
        {
        }

        ///<summary>
        /// 获取 Management API Token
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GetManagementTokenRespDto</returns>
        public async Task<GetManagementTokenRespDto> GetManagementToken(GetManagementAccessTokenDto requestBody
    )
        {
            string httpResponse = await Request("POST", "/api/v3/get-management-token", requestBody).ConfigureAwait(false);
            GetManagementTokenRespDto result = m_JsonService.DeserializeObject<GetManagementTokenRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户信息
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserSingleRespDto</returns>
        public async Task<UserSingleRespDto> GetUser(string userId, string userIdType = "user_id", bool withCustomData = false, bool withIdentities = false, bool withDepartmentIds = false)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user", new Dictionary<string, object> {
            {"userId",userId },
            {"userIdType",userIdType },
            {"withCustomData",withCustomData },
            {"withIdentities",withIdentities },
            {"withDepartmentIds",withDepartmentIds },
        }).ConfigureAwait(false);
            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量获取用户信息
        ///</summary>
        /// <param name="userIds">用户 ID 数组</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserListRespDto</returns>
        public async Task<UserListRespDto> GetUserBatch(string userIds, string userIdType = "user_id", bool withCustomData = false, bool withIdentities = false, bool withDepartmentIds = false)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-batch", new Dictionary<string, object> {
            {"userIds",userIds },
            {"userIdType",userIdType },
            {"withCustomData",withCustomData },
            {"withIdentities",withIdentities },
            {"withDepartmentIds",withDepartmentIds },
        }).ConfigureAwait(false);
            UserListRespDto result = m_JsonService.DeserializeObject<UserListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="status">账户当前状态，如 已停用、已离职、正常状态、已归档</param>
        /// <param name="updatedAtStart">用户创建、修改开始时间，为精确到秒的 UNIX 时间戳；支持获取从某一段时间之后的增量数据</param>
        /// <param name="updatedAtEnd">用户创建、修改终止时间，为精确到秒的 UNIX 时间戳；支持获取某一段时间内的增量数据。默认为当前时间</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListUsers(long page = 1, long limit = 10, string status = null, long updatedAtStart = 0, long updatedAtEnd = 0, bool withCustomData = false, bool withIdentities = false, bool withDepartmentIds = false)
        {
            string httpResponse = await Request("GET", "/api/v3/list-users", new Dictionary<string, object> {
            {"page",page },
            {"limit",limit },
            {"status",status },
            {"updatedAtStart",updatedAtStart },
            {"updatedAtEnd",updatedAtEnd },
            {"withCustomData",withCustomData },
            {"withIdentities",withIdentities },
            {"withDepartmentIds",withDepartmentIds },
        }).ConfigureAwait(false);
            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户的外部身份源
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        ///<returns>IdentityListRespDto</returns>
        public async Task<IdentityListRespDto> GetUserIdentities(string userId, string userIdType = "user_id")
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-identities", new Dictionary<string, object> {
            {"userId",userId },
            {"userIdType",userIdType },
        }).ConfigureAwait(false);
            IdentityListRespDto result = m_JsonService.DeserializeObject<IdentityListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户角色列表
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        ///<returns>RolePaginatedRespDto</returns>
        public async Task<RolePaginatedRespDto> GetUserRoles(string userId, string userIdType = "user_id", string nameSpace = null)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-roles", new Dictionary<string, object> {
            {"userId",userId },
            {"userIdType",userIdType },
            {"namespace",nameSpace },
        }).ConfigureAwait(false);
            RolePaginatedRespDto result = m_JsonService.DeserializeObject<RolePaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户实名认证信息
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        ///<returns>PrincipalAuthenticationInfoPaginatedRespDto</returns>
        public async Task<PrincipalAuthenticationInfoPaginatedRespDto> GetUserPrincipalAuthenticationInfo(string userId, string userIdType = "user_id")
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-principal-authentication-info", new Dictionary<string, object> {
            {"userId",userId },
            {"userIdType",userIdType },
        }).ConfigureAwait(false);
            PrincipalAuthenticationInfoPaginatedRespDto result = m_JsonService.DeserializeObject<PrincipalAuthenticationInfoPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除用户实名认证信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> ResetUserPrincipalAuthenticationInfo(ResetUserPrincipalAuthenticationInfoDto requestBody
    )
        {
            string httpResponse = await Request("POST", "/api/v3/reset-user-principal-authentication-info", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户部门列表
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="sortBy">排序依据，如 部门创建时间、加入部门时间、部门名称、部门标志符</param>
        /// <param name="orderBy">增序或降序</param>
        ///<returns>UserDepartmentPaginatedRespDto</returns>
        public async Task<UserDepartmentPaginatedRespDto> GetUserDepartments(string userId, string userIdType = "user_id", long page = 1, long limit = 10, bool withCustomData = false, string sortBy = "JoinDepartmentAt", string orderBy = "Desc")
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-departments", new Dictionary<string, object> {
        {"userId",userId },
        {"userIdType",userIdType },
        {"page",page },
        {"limit",limit },
        {"withCustomData",withCustomData },
        {"sortBy",sortBy },
        {"orderBy",orderBy },
    }).ConfigureAwait(false);
            UserDepartmentPaginatedRespDto result = m_JsonService.DeserializeObject<UserDepartmentPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 设置用户所在部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> SetUserDepartments(SetUserDepartmentsDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/set-user-departments", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户分组列表
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        ///<returns>GroupPaginatedRespDto</returns>
        public async Task<GroupPaginatedRespDto> GetUserGroups(string userId, string userIdType = "user_id")
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-groups", new Dictionary<string, object> {
        {"userId",userId },
        {"userIdType",userIdType },
    }).ConfigureAwait(false);
            GroupPaginatedRespDto result = m_JsonService.DeserializeObject<GroupPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteUsersBatch(DeleteUsersBatchDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/delete-users-batch", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户 MFA 绑定信息
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        ///<returns>UserMfaSingleRespDto</returns>
        public async Task<UserMfaSingleRespDto> GetUserMfaInfo(string userId, string userIdType = "user_id")
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-mfa-info", new Dictionary<string, object> {
        {"userId",userId },
        {"userIdType",userIdType },
    }).ConfigureAwait(false);
            UserMfaSingleRespDto result = m_JsonService.DeserializeObject<UserMfaSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取已归档的用户列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="startAt">开始时间，为精确到秒的 UNIX 时间戳，默认不指定</param>
        ///<returns>ListArchivedUsersSingleRespDto</returns>
        public async Task<ListArchivedUsersSingleRespDto> ListArchivedUsers(long page = 1, long limit = 10, long startAt = 0)
        {
            string httpResponse = await Request("GET", "/api/v3/list-archived-users", new Dictionary<string, object> {
        {"page",page },
        {"limit",limit },
        {"startAt",startAt },
    }).ConfigureAwait(false);
            ListArchivedUsersSingleRespDto result = m_JsonService.DeserializeObject<ListArchivedUsersSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 强制下线用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> KickUsers(KickUsersDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/kick-users", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 判断用户是否存在
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsUserExistsRespDto</returns>
        public async Task<IsUserExistsRespDto> IsUserExists(IsUserExistsReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/is-user-exists", requestBody).ConfigureAwait(false);
            IsUserExistsRespDto result = m_JsonService.DeserializeObject<IsUserExistsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserSingleRespDto</returns>
        public async Task<UserSingleRespDto> CreateUser(CreateUserReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-user", requestBody).ConfigureAwait(false);
            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserListRespDto</returns>
        public async Task<UserListRespDto> CreateUsersBatch(CreateUserBatchReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-users-batch", requestBody).ConfigureAwait(false);
            UserListRespDto result = m_JsonService.DeserializeObject<UserListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改用户资料
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserSingleRespDto</returns>
        public async Task<UserSingleRespDto> UpdateUser(UpdateUserReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/update-user", requestBody).ConfigureAwait(false);
            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户可访问的应用
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        ///<returns>AppListRespDto</returns>
        public async Task<AppListRespDto> GetUserAccessibleApps(string userId, string userIdType = "user_id")
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-accessible-apps", new Dictionary<string, object> {
        {"userId",userId },
        {"userIdType",userIdType },
    }).ConfigureAwait(false);
            AppListRespDto result = m_JsonService.DeserializeObject<AppListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户授权的应用
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        ///<returns>AppListRespDto</returns>
        public async Task<AppListRespDto> GetUserAuthorizedApps(string userId, string userIdType = "user_id")
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-authorized-apps", new Dictionary<string, object> {
        {"userId",userId },
        {"userIdType",userIdType },
    }).ConfigureAwait(false);
            AppListRespDto result = m_JsonService.DeserializeObject<AppListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 判断用户是否有某个角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>HasAnyRoleRespDto</returns>
        public async Task<HasAnyRoleRespDto> HasAnyRole(HasAnyRoleReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/has-any-role", requestBody).ConfigureAwait(false);
            HasAnyRoleRespDto result = m_JsonService.DeserializeObject<HasAnyRoleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户的登录历史记录
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        /// <param name="appId">应用 ID</param>
        /// <param name="clientIp">客户端 IP</param>
        /// <param name="start">开始时间戳（毫秒）</param>
        /// <param name="end">结束时间戳（毫秒）</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>UserLoginHistoryPaginatedRespDto</returns>
        public async Task<UserLoginHistoryPaginatedRespDto> GetUserLoginHistory(string userId, string userIdType = "user_id", string appId = null, string clientIp = null, long start = 0, long end = 0, long page = 1, long limit = 10)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-login-history", new Dictionary<string, object> {
        {"userId",userId },
        {"userIdType",userIdType },
        {"appId",appId },
        {"clientIp",clientIp },
        {"start",start },
        {"end",end },
        {"page",page },
        {"limit",limit },
    }).ConfigureAwait(false);
            UserLoginHistoryPaginatedRespDto result = m_JsonService.DeserializeObject<UserLoginHistoryPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 通过用户 ID，获取用户曾经登录过的应用，可以选择指定用户 ID 类型等。
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        ///<returns>UserLoggedInAppsListRespDto</returns>
        public async Task<UserLoggedInAppsListRespDto> GetUserLoggedinApps(string userId, string userIdType = "user_id")
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-loggedin-apps", new Dictionary<string, object> {
        {"userId",userId },
        {"userIdType",userIdType },
    }).ConfigureAwait(false);
            UserLoggedInAppsListRespDto result = m_JsonService.DeserializeObject<UserLoggedInAppsListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 通过用户 ID，获取用户曾经登录过的身份源，可以选择指定用户 ID 类型等。
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        ///<returns>UserLoggedInIdentitiesRespDto</returns>
        public async Task<UserLoggedInIdentitiesRespDto> GetUserLoggedinIdentities(string userId, string userIdType = "user_id")
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-logged-in-identities", new Dictionary<string, object> {
        {"userId",userId },
        {"userIdType",userIdType },
    }).ConfigureAwait(false);
            UserLoggedInIdentitiesRespDto result = m_JsonService.DeserializeObject<UserLoggedInIdentitiesRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户被授权的所有资源
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        /// <param name="resourceType">资源类型，如 数据、API、菜单、按钮</param>
        ///<returns>AuthorizedResourcePaginatedRespDto</returns>
        public async Task<AuthorizedResourcePaginatedRespDto> GetUserAuthorizedResources(string userId, string userIdType = "user_id", string nameSpace = null, string resourceType = null)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-authorized-resources", new Dictionary<string, object> {
        {"userId",userId },
        {"userIdType",userIdType },
        {"namespace",nameSpace },
        {"resourceType",resourceType },
    }).ConfigureAwait(false);
            AuthorizedResourcePaginatedRespDto result = m_JsonService.DeserializeObject<AuthorizedResourcePaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取分组详情
        ///</summary>
        /// <param name="code">分组 code</param>
        ///<returns>GroupSingleRespDto</returns>
        public async Task<GroupSingleRespDto> GetGroup(string code)
        {
            string httpResponse = await Request("GET", "/api/v3/get-group", new Dictionary<string, object> {
        {"code",code },
    }).ConfigureAwait(false);
            GroupSingleRespDto result = m_JsonService.DeserializeObject<GroupSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取分组列表
        ///</summary>
        /// <param name="keywords">搜索分组 code 或分组名称</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>GroupPaginatedRespDto</returns>
        public async Task<GroupPaginatedRespDto> ListGroups(string keywords = null, long page = 1, long limit = 10)
        {
            string httpResponse = await Request("GET", "/api/v3/list-groups", new Dictionary<string, object> {
        {"keywords",keywords },
        {"page",page },
        {"limit",limit },
    }).ConfigureAwait(false);
            GroupPaginatedRespDto result = m_JsonService.DeserializeObject<GroupPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GroupSingleRespDto</returns>
        public async Task<GroupSingleRespDto> CreateGroup(CreateGroupReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-group", requestBody).ConfigureAwait(false);
            GroupSingleRespDto result = m_JsonService.DeserializeObject<GroupSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GroupListRespDto</returns>
        public async Task<GroupListRespDto> CreateGroupsBatch(CreateGroupBatchReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-groups-batch", requestBody).ConfigureAwait(false);
            GroupListRespDto result = m_JsonService.DeserializeObject<GroupListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GroupSingleRespDto</returns>
        public async Task<GroupSingleRespDto> UpdateGroup(UpdateGroupReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/update-group", requestBody).ConfigureAwait(false);
            GroupSingleRespDto result = m_JsonService.DeserializeObject<GroupSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteGroupsBatch(DeleteGroupsReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/delete-groups-batch", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 添加分组成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AddGroupMembers(AddGroupMembersReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/add-group-members", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量移除分组成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> RemoveGroupMembers(RemoveGroupMembersReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/remove-group-members", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取分组成员列表
        ///</summary>
        /// <param name="code">分组 code</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListGroupMembers(string code, long page = 1, long limit = 10, bool withCustomData = false, bool withIdentities = false, bool withDepartmentIds = false)
        {
            string httpResponse = await Request("GET", "/api/v3/list-group-members", new Dictionary<string, object> {
        {"code",code },
        {"page",page },
        {"limit",limit },
        {"withCustomData",withCustomData },
        {"withIdentities",withIdentities },
        {"withDepartmentIds",withDepartmentIds },
    }).ConfigureAwait(false);
            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取分组被授权的资源列表
        ///</summary>
        /// <param name="code">分组 code</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        /// <param name="resourceType">资源类型</param>
        ///<returns>AuthorizedResourceListRespDto</returns>
        public async Task<AuthorizedResourceListRespDto> GetGroupAuthorizedResources(string code, string nameSpace = null, string resourceType = null)
        {
            string httpResponse = await Request("GET", "/api/v3/get-group-authorized-resources", new Dictionary<string, object> {
        {"code",code },
        {"namespace",nameSpace },
        {"resourceType",resourceType },
    }).ConfigureAwait(false);
            AuthorizedResourceListRespDto result = m_JsonService.DeserializeObject<AuthorizedResourceListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取角色详情
        ///</summary>
        /// <param name="code">权限分组内角色的唯一标识符</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        ///<returns>RoleSingleRespDto</returns>
        public async Task<RoleSingleRespDto> GetRole(string code, string nameSpace = null)
        {
            string httpResponse = await Request("GET", "/api/v3/get-role", new Dictionary<string, object> {
        {"code",code },
        {"namespace",nameSpace },
    }).ConfigureAwait(false);
            RoleSingleRespDto result = m_JsonService.DeserializeObject<RoleSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 分配角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AssignRole(AssignRoleDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/assign-role", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 移除分配的角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> RevokeRole(RevokeRoleDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/revoke-role", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取角色被授权的资源列表
        ///</summary>
        /// <param name="code">权限分组内角色的唯一标识符</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        /// <param name="resourceType">资源类型，如 数据、API、按钮、菜单</param>
        ///<returns>RoleAuthorizedResourcePaginatedRespDto</returns>
        public async Task<RoleAuthorizedResourcePaginatedRespDto> GetRoleAuthorizedResources(string code, string nameSpace = null, string resourceType = null)
        {
            string httpResponse = await Request("GET", "/api/v3/get-role-authorized-resources", new Dictionary<string, object> {
        {"code",code },
        {"namespace",nameSpace },
        {"resourceType",resourceType },
    }).ConfigureAwait(false);
            RoleAuthorizedResourcePaginatedRespDto result = m_JsonService.DeserializeObject<RoleAuthorizedResourcePaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取角色成员列表
        ///</summary>
        /// <param name="code">权限分组内角色的唯一标识符</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListRoleMembers(string code, long page = 1, long limit = 10, bool withCustomData = false, bool withIdentities = false, bool withDepartmentIds = false, string nameSpace = null)
        {
            string httpResponse = await Request("GET", "/api/v3/list-role-members", new Dictionary<string, object> {
        {"page",page },
        {"limit",limit },
        {"withCustomData",withCustomData },
        {"withIdentities",withIdentities },
        {"withDepartmentIds",withDepartmentIds },
        {"code",code },
        {"namespace",nameSpace },
    }).ConfigureAwait(false);
            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取角色的部门列表
        ///</summary>
        /// <param name="code">权限分组内角色的唯一标识符</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>RoleDepartmentListPaginatedRespDto</returns>
        public async Task<RoleDepartmentListPaginatedRespDto> ListRoleDepartments(string code, string nameSpace = null, long page = 1, long limit = 10)
        {
            string httpResponse = await Request("GET", "/api/v3/list-role-departments", new Dictionary<string, object> {
        {"code",code },
        {"namespace",nameSpace },
        {"page",page },
        {"limit",limit },
    }).ConfigureAwait(false);
            RoleDepartmentListPaginatedRespDto result = m_JsonService.DeserializeObject<RoleDepartmentListPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>RoleSingleRespDto</returns>
        public async Task<RoleSingleRespDto> CreateRole(CreateRoleDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-role", requestBody).ConfigureAwait(false);
            RoleSingleRespDto result = m_JsonService.DeserializeObject<RoleSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取角色列表
        ///</summary>
        /// <param name="keywords">搜索角色 code</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>RolePaginatedRespDto</returns>
        public async Task<RolePaginatedRespDto> ListRoles(string keywords = null, string nameSpace = "default", long page = 1, long limit = 10)
        {
            string httpResponse = await Request("GET", "/api/v3/list-roles", new Dictionary<string, object> {
        {"keywords",keywords },
        {"namespace",nameSpace },
        {"page",page },
        {"limit",limit },
    }).ConfigureAwait(false);
            RolePaginatedRespDto result = m_JsonService.DeserializeObject<RolePaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteRolesBatch(DeleteRoleDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/delete-roles-batch", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> CreateRolesBatch(CreateRolesBatch requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-roles-batch", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UpdateRole(UpdateRoleDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/update-role", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取顶层组织机构列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="fetchAll">拉取所有</param>
        ///<returns>OrganizationPaginatedRespDto</returns>
        public async Task<OrganizationPaginatedRespDto> ListOrganizations(long page = 1, long limit = 10, bool fetchAll = false)
        {
            string httpResponse = await Request("GET", "/api/v3/list-organizations", new Dictionary<string, object> {
        {"page",page },
        {"limit",limit },
        {"fetchAll",fetchAll },
    }).ConfigureAwait(false);
            OrganizationPaginatedRespDto result = m_JsonService.DeserializeObject<OrganizationPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建顶层组织机构
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>OrganizationSingleRespDto</returns>
        public async Task<OrganizationSingleRespDto> CreateOrganization(CreateOrganizationReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-organization", requestBody).ConfigureAwait(false);
            OrganizationSingleRespDto result = m_JsonService.DeserializeObject<OrganizationSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改顶层组织机构
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>OrganizationSingleRespDto</returns>
        public async Task<OrganizationSingleRespDto> UpdateOrganization(UpdateOrganizationReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/update-organization", requestBody).ConfigureAwait(false);
            OrganizationSingleRespDto result = m_JsonService.DeserializeObject<OrganizationSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除组织机构
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteOrganization(DeleteOrganizationReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/delete-organization", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 搜索顶层组织机构列表
        ///</summary>
        /// <param name="keywords">搜索关键词，如组织机构名称</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>OrganizationPaginatedRespDto</returns>
        public async Task<OrganizationPaginatedRespDto> SearchOrganizations(string keywords, long page = 1, long limit = 10)
        {
            string httpResponse = await Request("GET", "/api/v3/search-organizations", new Dictionary<string, object> {
        {"keywords",keywords },
        {"page",page },
        {"limit",limit },
    }).ConfigureAwait(false);
            OrganizationPaginatedRespDto result = m_JsonService.DeserializeObject<OrganizationPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取部门信息
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`。departmentId 和 departmentCode 必传其一。</param>
        /// <param name="departmentCode">部门 code。departmentId 和 departmentCode 必传其一。</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> GetDepartment(string organizationCode, string departmentId = null, string departmentCode = null, string departmentIdType = "department_id", bool withCustomData = false)
        {
            string httpResponse = await Request("GET", "/api/v3/get-department", new Dictionary<string, object> {
        {"organizationCode",organizationCode },
        {"departmentId",departmentId },
        {"departmentCode",departmentCode },
        {"departmentIdType",departmentIdType },
        {"withCustomData",withCustomData },
    }).ConfigureAwait(false);
            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> CreateDepartment(CreateDepartmentReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-department", requestBody).ConfigureAwait(false);
            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> UpdateDepartment(UpdateDepartmentReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/update-department", requestBody).ConfigureAwait(false);
            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteDepartment(DeleteDepartmentReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/delete-department", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 搜索部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DepartmentListRespDto</returns>
        public async Task<DepartmentListRespDto> SearchDepartments(SearchDepartmentsReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/search-departments", requestBody).ConfigureAwait(false);
            DepartmentListRespDto result = m_JsonService.DeserializeObject<DepartmentListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取子部门列表
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">需要获取的部门 ID</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="excludeVirtualNode">是否要排除虚拟组织</param>
        /// <param name="onlyVirtualNode">是否只包含虚拟组织</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>DepartmentPaginatedRespDto</returns>
        public async Task<DepartmentPaginatedRespDto> ListChildrenDepartments(string departmentId, string organizationCode, string departmentIdType = "department_id", bool excludeVirtualNode = false, bool onlyVirtualNode = false, bool withCustomData = false)
        {
            string httpResponse = await Request("GET", "/api/v3/list-children-departments", new Dictionary<string, object> {
        {"organizationCode",organizationCode },
        {"departmentId",departmentId },
        {"departmentIdType",departmentIdType },
        {"excludeVirtualNode",excludeVirtualNode },
        {"onlyVirtualNode",onlyVirtualNode },
        {"withCustomData",withCustomData },
    }).ConfigureAwait(false);
            DepartmentPaginatedRespDto result = m_JsonService.DeserializeObject<DepartmentPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取部门成员列表
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="includeChildrenDepartments">是否包含子部门的成员</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        /// <param name="sortBy">排序依据</param>
        /// <param name="orderBy">增序还是倒序</param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListDepartmentMembers(string departmentId, string organizationCode, string departmentIdType = "department_id", bool includeChildrenDepartments = false, long page = 1, long limit = 10, bool withCustomData = false, bool withIdentities = false, bool withDepartmentIds = false, string sortBy = "JoinDepartmentAt", string orderBy = "Desc")
        {
            string httpResponse = await Request("GET", "/api/v3/list-department-members", new Dictionary<string, object> {
        {"organizationCode",organizationCode },
        {"departmentId",departmentId },
        {"departmentIdType",departmentIdType },
        {"includeChildrenDepartments",includeChildrenDepartments },
        {"page",page },
        {"limit",limit },
        {"withCustomData",withCustomData },
        {"withIdentities",withIdentities },
        {"withDepartmentIds",withDepartmentIds },
        {"sortBy",sortBy },
        {"orderBy",orderBy },
    }).ConfigureAwait(false);
            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取部门直属成员 ID 列表
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        ///<returns>UserIdListRespDto</returns>
        public async Task<UserIdListRespDto> ListDepartmentMemberIds(string departmentId, string organizationCode, string departmentIdType = "department_id")
        {
            string httpResponse = await Request("GET", "/api/v3/list-department-member-ids", new Dictionary<string, object> {
        {"organizationCode",organizationCode },
        {"departmentId",departmentId },
        {"departmentIdType",departmentIdType },
    }).ConfigureAwait(false);
            UserIdListRespDto result = m_JsonService.DeserializeObject<UserIdListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 搜索部门下的成员
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`</param>
        /// <param name="keywords">搜索关键词，如成员名称</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="includeChildrenDepartments">是否包含子部门的成员</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> SearchDepartmentMembers(string keywords, string departmentId, string organizationCode, long page = 1, long limit = 10, string departmentIdType = "department_id", bool includeChildrenDepartments = false, bool withCustomData = false, bool withIdentities = false, bool withDepartmentIds = false)
        {
            string httpResponse = await Request("GET", "/api/v3/search-department-members", new Dictionary<string, object> {
        {"organizationCode",organizationCode },
        {"departmentId",departmentId },
        {"keywords",keywords },
        {"page",page },
        {"limit",limit },
        {"departmentIdType",departmentIdType },
        {"includeChildrenDepartments",includeChildrenDepartments },
        {"withCustomData",withCustomData },
        {"withIdentities",withIdentities },
        {"withDepartmentIds",withDepartmentIds },
    }).ConfigureAwait(false);
            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 部门下添加成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AddDepartmentMembers(AddDepartmentMembersReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/add-department-members", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 部门下删除成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> RemoveDepartmentMembers(RemoveDepartmentMembersReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/remove-department-members", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取父部门信息
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> GetParentDepartment(string departmentId, string organizationCode, string departmentIdType = "department_id", bool withCustomData = false)
        {
            string httpResponse = await Request("GET", "/api/v3/get-parent-department", new Dictionary<string, object> {
        {"organizationCode",organizationCode },
        {"departmentId",departmentId },
        {"departmentIdType",departmentIdType },
        {"withCustomData",withCustomData },
    }).ConfigureAwait(false);
            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 判断用户是否在某个部门下
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`。departmentId 和 departmentCode 必传其一。</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="includeChildrenDepartments">是否包含子部门</param>
        ///<returns>IsUserInDepartmentRespDto</returns>
        public async Task<IsUserInDepartmentRespDto> IsUserInDepartment(string departmentId, string organizationCode, string userId, string departmentIdType = "department_id", bool includeChildrenDepartments = false)
        {
            string httpResponse = await Request("GET", "/api/v3/is-user-in-department", new Dictionary<string, object> {
        {"userId",userId },
        {"organizationCode",organizationCode },
        {"departmentId",departmentId },
        {"departmentIdType",departmentIdType },
        {"includeChildrenDepartments",includeChildrenDepartments },
    }).ConfigureAwait(false);
            IsUserInDepartmentRespDto result = m_JsonService.DeserializeObject<IsUserInDepartmentRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取身份源列表
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>ExtIdpListPaginatedRespDto</returns>
        public async Task<ExtIdpListPaginatedRespDto> ListExtIdp(string tenantId = null)
        {
            string httpResponse = await Request("GET", "/api/v3/list-ext-idp", new Dictionary<string, object> {
        {"tenantId",tenantId },
    }).ConfigureAwait(false);
            ExtIdpListPaginatedRespDto result = m_JsonService.DeserializeObject<ExtIdpListPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取身份源详情
        ///</summary>
        /// <param name="id">身份源 ID</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>ExtIdpDetailSingleRespDto</returns>
        public async Task<ExtIdpDetailSingleRespDto> GetExtIdp(string id, string tenantId = null)
        {
            string httpResponse = await Request("GET", "/api/v3/get-ext-idp", new Dictionary<string, object> {
        {"tenantId",tenantId },
        {"id",id },
    }).ConfigureAwait(false);
            ExtIdpDetailSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpDetailSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建身份源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpSingleRespDto</returns>
        public async Task<ExtIdpSingleRespDto> CreateExtIdp(CreateExtIdpDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-ext-idp", requestBody).ConfigureAwait(false);
            ExtIdpSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新身份源配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpSingleRespDto</returns>
        public async Task<ExtIdpSingleRespDto> UpdateExtIdp(UpdateExtIdpDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/update-ext-idp", requestBody).ConfigureAwait(false);
            ExtIdpSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除身份源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteExtIdp(DeleteExtIdpDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/delete-ext-idp", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 在某个已有身份源下创建新连接
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpConnDetailSingleRespDto</returns>
        public async Task<ExtIdpConnDetailSingleRespDto> CreateExtIdpConn(CreateExtIdpConnDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-ext-idp-conn", requestBody).ConfigureAwait(false);
            ExtIdpConnDetailSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpConnDetailSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新身份源连接
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpConnDetailSingleRespDto</returns>
        public async Task<ExtIdpConnDetailSingleRespDto> UpdateExtIdpConn(UpdateExtIdpConnDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/update-ext-idp-conn", requestBody).ConfigureAwait(false);
            ExtIdpConnDetailSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpConnDetailSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除身份源连接
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteExtIdpConn(DeleteExtIdpConnDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/delete-ext-idp-conn", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 身份源连接开关
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> ChangeConnState(EnableExtIdpConnDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/enable-ext-idp-conn", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户池配置的自定义字段列表
        ///</summary>
        /// <param name="targetType">主体类型，目前支持用户、角色、分组、部门</param>
        ///<returns>CustomFieldListRespDto</returns>
        public async Task<CustomFieldListRespDto> GetCustomFields(string targetType)
        {
            string httpResponse = await Request("GET", "/api/v3/get-custom-fields", new Dictionary<string, object> {
        {"targetType",targetType },
    }).ConfigureAwait(false);
            CustomFieldListRespDto result = m_JsonService.DeserializeObject<CustomFieldListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建/修改自定义字段定义
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CustomFieldListRespDto</returns>
        public async Task<CustomFieldListRespDto> SetCustomFields(SetCustomFieldsReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/set-custom-fields", requestBody).ConfigureAwait(false);
            CustomFieldListRespDto result = m_JsonService.DeserializeObject<CustomFieldListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 设置自定义字段的值
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> SetCustomData(SetCustomDataReqDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/set-custom-data", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户、分组、角色、组织机构的自定义字段值
        ///</summary>
        /// <param name="targetType">主体类型，目前支持用户、角色、分组、部门</param>
        /// <param name="targetIdentifier">目标对象唯一标志符</param>
        /// <param name="nameSpace">所属权限分组的 code，当 targetType 为角色的时候需要填写，否则可以忽略</param>
        ///<returns>GetCustomDataRespDto</returns>
        public async Task<GetCustomDataRespDto> GetCustomData(string targetIdentifier, string targetType, string nameSpace = null)
        {
            string httpResponse = await Request("GET", "/api/v3/get-custom-data", new Dictionary<string, object> {
        {"targetType",targetType },
        {"targetIdentifier",targetIdentifier },
        {"namespace",nameSpace },
    }).ConfigureAwait(false);
            GetCustomDataRespDto result = m_JsonService.DeserializeObject<GetCustomDataRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ResourceRespDto</returns>
        public async Task<ResourceRespDto> CreateResource(CreateResourceDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-resource", requestBody).ConfigureAwait(false);
            ResourceRespDto result = m_JsonService.DeserializeObject<ResourceRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> CreateResourcesBatch(CreateResourcesBatchDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-resources-batch", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取资源详情
        ///</summary>
        /// <param name="code">资源唯一标志符</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        ///<returns>ResourceRespDto</returns>
        public async Task<ResourceRespDto> GetResource(string code, string nameSpace = null)
        {
            string httpResponse = await Request("GET", "/api/v3/get-resource", new Dictionary<string, object> {
        {"code",code },
        {"namespace",nameSpace },
    }).ConfigureAwait(false);
            ResourceRespDto result = m_JsonService.DeserializeObject<ResourceRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量获取资源详情
        ///</summary>
        /// <param name="codeList">资源 code 列表，批量可以使用逗号分隔</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        ///<returns>ResourceListRespDto</returns>
        public async Task<ResourceListRespDto> GetResourcesBatch(string codeList, string nameSpace = null)
        {
            string httpResponse = await Request("GET", "/api/v3/get-resources-batch", new Dictionary<string, object> {
        {"namespace",nameSpace },
        {"codeList",codeList },
    }).ConfigureAwait(false);
            ResourceListRespDto result = m_JsonService.DeserializeObject<ResourceListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 分页获取资源列表
        ///</summary>
        /// <param name="nameSpace">所属权限分组的 code</param>
        /// <param name="type">资源类型</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>ResourcePaginatedRespDto</returns>
        public async Task<ResourcePaginatedRespDto> ListResources(string nameSpace = null, string type = null, long page = 1, long limit = 10)
        {
            string httpResponse = await Request("GET", "/api/v3/list-resources", new Dictionary<string, object> {
        {"namespace",nameSpace },
        {"type",type },
        {"page",page },
        {"limit",limit },
    }).ConfigureAwait(false);
            ResourcePaginatedRespDto result = m_JsonService.DeserializeObject<ResourcePaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ResourceRespDto</returns>
        public async Task<ResourceRespDto> UpdateResource(UpdateResourceDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/update-resource", requestBody).ConfigureAwait(false);
            ResourceRespDto result = m_JsonService.DeserializeObject<ResourceRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteResource(DeleteResourceDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/delete-resource", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteResourcesBatch(DeleteResourcesBatchDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/delete-resources-batch", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建权限分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>NamespaceRespDto</returns>
        public async Task<NamespaceRespDto> CreateNamespace(CreateNamespaceDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-namespace", requestBody).ConfigureAwait(false);
            NamespaceRespDto result = m_JsonService.DeserializeObject<NamespaceRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建权限分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> CreateNamespacesBatch(CreateNamespacesBatchDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/create-namespaces-batch", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取权限分组详情
        ///</summary>
        /// <param name="code">权限分组唯一标志符</param>
        ///<returns>NamespaceRespDto</returns>
        public async Task<NamespaceRespDto> GetNamespace(string code)
        {
            string httpResponse = await Request("GET", "/api/v3/get-namespace", new Dictionary<string, object> {
        {"code",code },
    }).ConfigureAwait(false);
            NamespaceRespDto result = m_JsonService.DeserializeObject<NamespaceRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量获取权限分组详情
        ///</summary>
        /// <param name="codeList">资源 code 列表，批量可以使用逗号分隔</param>
        ///<returns>NamespaceListRespDto</returns>
        public async Task<NamespaceListRespDto> GetNamespacesBatch(string codeList)
        {
            string httpResponse = await Request("GET", "/api/v3/get-namespaces-batch", new Dictionary<string, object> {
        {"codeList",codeList },
    }).ConfigureAwait(false);
            NamespaceListRespDto result = m_JsonService.DeserializeObject<NamespaceListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改权限分组信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UpdateNamespaceRespDto</returns>
        public async Task<UpdateNamespaceRespDto> UpdateNamespace(UpdateNamespaceDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/update-namespace", requestBody).ConfigureAwait(false);
            UpdateNamespaceRespDto result = m_JsonService.DeserializeObject<UpdateNamespaceRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除权限分组信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteNamespace(DeleteNamespaceDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/delete-namespace", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除权限分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteNamespacesBatch(DeleteNamespacesBatchDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/delete-namespaces-batch", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 授权资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AuthorizeResources(AuthorizeResourcesDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/authorize-resources", requestBody).ConfigureAwait(false);
            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取某个主体被授权的资源列表
        ///</summary>
        /// <param name="targetType">目标对象类型</param>
        /// <param name="targetIdentifier">目标对象唯一标志符</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        /// <param name="resourceType">限定资源类型，如数据、API、按钮、菜单</param>
        /// <param name="resourceList">限定查询的资源列表，如果指定，只会返回所指定的资源列表。</param>
        /// <param name="withDenied">是否获取被拒绝的资源</param>
        ///<returns>AuthorizedResourcePaginatedRespDto</returns>
        public async Task<AuthorizedResourcePaginatedRespDto> GetAuthorizedResources(string targetIdentifier, string targetType, string nameSpace = null, string resourceType = null, string resourceList = null, bool withDenied = false)
        {
            string httpResponse = await Request("GET", "/api/v3/get-authorized-resources", new Dictionary<string, object> {
        {"namespace",nameSpace },
        {"targetType",targetType },
        {"targetIdentifier",targetIdentifier },
        {"resourceType",resourceType },
        {"resourceList",resourceList },
        {"withDenied",withDenied },
    }).ConfigureAwait(false);
            AuthorizedResourcePaginatedRespDto result = m_JsonService.DeserializeObject<AuthorizedResourcePaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 判断用户是否对某个资源的某个操作有权限
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsActionAllowedRespDtp</returns>
        public async Task<IsActionAllowedRespDtp> IsActionAllowed(IsActionAllowedDto requestBody
        )
        {
            string httpResponse = await Request("POST", "/api/v3/is-action-allowed", requestBody).ConfigureAwait(false);
            IsActionAllowedRespDtp result = m_JsonService.DeserializeObject<IsActionAllowedRespDtp>(httpResponse);
            return result;
        }
    }
}