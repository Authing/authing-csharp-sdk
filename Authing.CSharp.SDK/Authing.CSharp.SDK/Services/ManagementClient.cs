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

        /// <summary>
        /// 订阅事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="messageCallback">事件回调方法</param>
        /// <param name="errorCallback">事件错误回调方法</param>
        public void Sub(string eventName, Action<string> messageCallback, Action<string> errorCallback)
        {
            BaseSub(eventName, messageCallback, errorCallback);
        }

        /// <summary>
        /// 发布事件
        /// </summary>
        /// <param name="eventcode"></param>
        /// <param name="eventData"></param>
        /// <returns></returns>
        public async Task<IsSuccessRespDto> PubEvent(EventRequestDto eventRequestDto)
        {
            string httpResponse = await Request("POST", "/api/v3/pub-event", eventRequestDto).ConfigureAwait(false);
            IsSuccessRespDto commonResponseDto = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return commonResponseDto;
        }

        ///<summary>
        /// 获取/搜索用户列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListUsers(ListUsersRequestDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-users", requestBody).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
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
        public async Task<UserPaginatedRespDto> ListUsersLegacy(ListUsersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-users", reqDto).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户信息
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserSingleRespDto</returns>
        public async Task<UserSingleRespDto> GetUser(GetUserDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user", reqDto).ConfigureAwait(false);

            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取用户信息
        ///</summary>
        /// <param name="userIds">用户 ID 数组</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserListRespDto</returns>
        public async Task<UserListRespDto> GetUserBatch(GetUserBatchDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-batch", reqDto).ConfigureAwait(false);

            UserListRespDto result = m_JsonService.DeserializeObject<UserListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserSingleRespDto</returns>
        public async Task<UserSingleRespDto> CreateUser(CreateUserReqDto requestBody)
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
        public async Task<UserListRespDto> CreateUsersBatch(CreateUserBatchReqDto requestBody)
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
        public async Task<UserSingleRespDto> UpdateUser(UpdateUserReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-user", requestBody).ConfigureAwait(false);

            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量修改用户资料
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserListRespDto</returns>
        public async Task<UserListRespDto> UpdateUserBatch(UpdateUserBatchReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-user-batch", requestBody).ConfigureAwait(false);

            UserListRespDto result = m_JsonService.DeserializeObject<UserListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteUsersBatch(DeleteUsersBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-users-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户的外部身份源
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>IdentityListRespDto</returns>
        public async Task<IdentityListRespDto> GetUserIdentities(GetUserIdentitiesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-identities", reqDto).ConfigureAwait(false);

            IdentityListRespDto result = m_JsonService.DeserializeObject<IdentityListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户角色列表
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        ///<returns>RolePaginatedRespDto</returns>
        public async Task<RolePaginatedRespDto> GetUserRoles(GetUserRolesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-roles", reqDto).ConfigureAwait(false);

            RolePaginatedRespDto result = m_JsonService.DeserializeObject<RolePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户实名认证信息
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>PrincipalAuthenticationInfoPaginatedRespDto</returns>
        public async Task<PrincipalAuthenticationInfoPaginatedRespDto> GetUserPrincipalAuthenticationInfo(GetUserPrincipalAuthenticationInfoDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-principal-authentication-info", reqDto).ConfigureAwait(false);

            PrincipalAuthenticationInfoPaginatedRespDto result = m_JsonService.DeserializeObject<PrincipalAuthenticationInfoPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 删除用户实名认证信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> ResetUserPrincipalAuthenticationInfo(ResetUserPrincipalAuthenticationInfoDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/reset-user-principal-authentication-info", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户部门列表
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withDepartmentPaths">是否获取部门路径</param>
        /// <param name="sortBy">排序依据，如 部门创建时间、加入部门时间、部门名称、部门标志符</param>
        /// <param name="orderBy">增序或降序</param>
        ///<returns>UserDepartmentPaginatedRespDto</returns>
        public async Task<UserDepartmentPaginatedRespDto> GetUserDepartments(GetUserDepartmentsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-departments", reqDto).ConfigureAwait(false);

            UserDepartmentPaginatedRespDto result = m_JsonService.DeserializeObject<UserDepartmentPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 设置用户所在部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> SetUserDepartments(SetUserDepartmentsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-user-departments", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户分组列表
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>GroupPaginatedRespDto</returns>
        public async Task<GroupPaginatedRespDto> GetUserGroups(GetUserGroupsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-groups", reqDto).ConfigureAwait(false);

            GroupPaginatedRespDto result = m_JsonService.DeserializeObject<GroupPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户 MFA 绑定信息
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>UserMfaSingleRespDto</returns>
        public async Task<UserMfaSingleRespDto> GetUserMfaInfo(GetUserMfaInfoDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-mfa-info", reqDto).ConfigureAwait(false);

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
        public async Task<ListArchivedUsersSingleRespDto> ListArchivedUsers(ListArchivedUsersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-archived-users", reqDto).ConfigureAwait(false);

            ListArchivedUsersSingleRespDto result = m_JsonService.DeserializeObject<ListArchivedUsersSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 强制下线用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> KickUsers(KickUsersDto requestBody)
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
        public async Task<IsUserExistsRespDto> IsUserExists(IsUserExistsReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/is-user-exists", requestBody).ConfigureAwait(false);

            IsUserExistsRespDto result = m_JsonService.DeserializeObject<IsUserExistsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户可访问的应用
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>AppListRespDto</returns>
        public async Task<AppListRespDto> GetUserAccessibleApps(GetUserAccessibleAppsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-accessible-apps", reqDto).ConfigureAwait(false);

            AppListRespDto result = m_JsonService.DeserializeObject<AppListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户授权的应用
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>AppListRespDto</returns>
        public async Task<AppListRespDto> GetUserAuthorizedApps(GetUserAuthorizedAppsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-authorized-apps", reqDto).ConfigureAwait(false);

            AppListRespDto result = m_JsonService.DeserializeObject<AppListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 判断用户是否有某个角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>HasAnyRoleRespDto</returns>
        public async Task<HasAnyRoleRespDto> HasAnyRole(HasAnyRoleReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/has-any-role", requestBody).ConfigureAwait(false);

            HasAnyRoleRespDto result = m_JsonService.DeserializeObject<HasAnyRoleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户的登录历史记录
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="appId">应用 ID</param>
        /// <param name="clientIp">客户端 IP</param>
        /// <param name="start">开始时间戳（毫秒）</param>
        /// <param name="end">结束时间戳（毫秒）</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>UserLoginHistoryPaginatedRespDto</returns>
        public async Task<UserLoginHistoryPaginatedRespDto> GetUserLoginHistory(GetUserLoginHistoryDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-login-history", reqDto).ConfigureAwait(false);

            UserLoginHistoryPaginatedRespDto result = m_JsonService.DeserializeObject<UserLoginHistoryPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户曾经登录过的应用
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>UserLoggedInAppsListRespDto</returns>
        public async Task<UserLoggedInAppsListRespDto> GetUserLoggedinApps(GetUserLoggedinAppsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-loggedin-apps", reqDto).ConfigureAwait(false);

            UserLoggedInAppsListRespDto result = m_JsonService.DeserializeObject<UserLoggedInAppsListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户曾经登录过的身份源
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>UserLoggedInIdentitiesRespDto</returns>
        public async Task<UserLoggedInIdentitiesRespDto> GetUserLoggedinIdentities(GetUserLoggedInIdentitiesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-logged-in-identities", reqDto).ConfigureAwait(false);

            UserLoggedInIdentitiesRespDto result = m_JsonService.DeserializeObject<UserLoggedInIdentitiesRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 用户离职
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ResignUserRespDto</returns>
        public async Task<ResignUserRespDto> ResignUser(ResignUserReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/resign-user", requestBody).ConfigureAwait(false);

            ResignUserRespDto result = m_JsonService.DeserializeObject<ResignUserRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量用户离职
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ResignUserRespDto</returns>
        public async Task<ResignUserRespDto> ResignUserBatch(ResignUserBatchReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/resign-user-batch", requestBody).ConfigureAwait(false);

            ResignUserRespDto result = m_JsonService.DeserializeObject<ResignUserRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户被授权的所有资源
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        /// <param name="resourceType">资源类型，如 数据、API、菜单、按钮</param>
        ///<returns>AuthorizedResourcePaginatedRespDto</returns>
        public async Task<AuthorizedResourcePaginatedRespDto> GetUserAuthorizedResources(GetUserAuthorizedResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-authorized-resources", reqDto).ConfigureAwait(false);

            AuthorizedResourcePaginatedRespDto result = m_JsonService.DeserializeObject<AuthorizedResourcePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 检查某个用户在应用下是否具备 Session 登录态
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CheckSessionStatusRespDto</returns>
        public async Task<CheckSessionStatusRespDto> CheckSessionStatus(CheckSessionStatusDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-session-status", requestBody).ConfigureAwait(false);

            CheckSessionStatusRespDto result = m_JsonService.DeserializeObject<CheckSessionStatusRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 导入用户的 OTP
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> ImportOtp(ImportOtpReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/import-otp", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取组织机构详情
        ///</summary>
        /// <param name="organizationCode">组织 Code（organizationCode）</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>OrganizationSingleRespDto</returns>
        public async Task<OrganizationSingleRespDto> GetOrganization(GetOrganizationDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-organization", reqDto).ConfigureAwait(false);

            OrganizationSingleRespDto result = m_JsonService.DeserializeObject<OrganizationSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取组织机构详情
        ///</summary>
        /// <param name="organizationCodeList">组织 Code（organizationCode）列表</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>OrganizationListRespDto</returns>
        public async Task<OrganizationListRespDto> GetOrganizationsBatch(GetOrganizationBatchDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-organization-batch", reqDto).ConfigureAwait(false);

            OrganizationListRespDto result = m_JsonService.DeserializeObject<OrganizationListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取组织机构列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="fetchAll">拉取所有</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>OrganizationPaginatedRespDto</returns>
        public async Task<OrganizationPaginatedRespDto> ListOrganizations(ListOrganizationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-organizations", reqDto).ConfigureAwait(false);

            OrganizationPaginatedRespDto result = m_JsonService.DeserializeObject<OrganizationPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建组织机构
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>OrganizationSingleRespDto</returns>
        public async Task<OrganizationSingleRespDto> CreateOrganization(CreateOrganizationReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-organization", requestBody).ConfigureAwait(false);

            OrganizationSingleRespDto result = m_JsonService.DeserializeObject<OrganizationSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改组织机构
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>OrganizationSingleRespDto</returns>
        public async Task<OrganizationSingleRespDto> UpdateOrganization(UpdateOrganizationReqDto requestBody)
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
        public async Task<IsSuccessRespDto> DeleteOrganization(DeleteOrganizationReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-organization", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 搜索组织机构列表
        ///</summary>
        /// <param name="keywords">搜索关键词，如组织机构名称</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>OrganizationPaginatedRespDto</returns>
        public async Task<OrganizationPaginatedRespDto> SearchOrganizations(SearchOrganizationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/search-organizations", reqDto).ConfigureAwait(false);

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
        public async Task<DepartmentSingleRespDto> GetDepartment(GetDepartmentDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-department", reqDto).ConfigureAwait(false);

            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> CreateDepartment(CreateDepartmentReqDto requestBody)
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
        public async Task<DepartmentSingleRespDto> UpdateDepartment(UpdateDepartmentReqDto requestBody)
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
        public async Task<IsSuccessRespDto> DeleteDepartment(DeleteDepartmentReqDto requestBody)
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
        public async Task<DepartmentListRespDto> SearchDepartments(SearchDepartmentsReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/search-departments", requestBody).ConfigureAwait(false);

            DepartmentListRespDto result = m_JsonService.DeserializeObject<DepartmentListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 搜索部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DepartmentListRespDto</returns>
        public async Task<DepartmentListRespDto> SearchDepartmentsList(SearchDepartmentsListReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/search-departments-list", requestBody).ConfigureAwait(false);

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
        public async Task<DepartmentPaginatedRespDto> ListChildrenDepartments(ListChildrenDepartmentsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-children-departments", reqDto).ConfigureAwait(false);

            DepartmentPaginatedRespDto result = m_JsonService.DeserializeObject<DepartmentPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取部门成员列表
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`</param>
        /// <param name="sortBy">排序依据</param>
        /// <param name="orderBy">增序还是倒序</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="includeChildrenDepartments">是否包含子部门的成员</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListDepartmentMembers(ListDepartmentMembersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-department-members", reqDto).ConfigureAwait(false);

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
        public async Task<UserIdListRespDto> ListDepartmentMemberIds(ListDepartmentMemberIdsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-department-member-ids", reqDto).ConfigureAwait(false);

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
        public async Task<UserPaginatedRespDto> SearchDepartmentMembers(SearchDepartmentMembersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/search-department-members", reqDto).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 部门下添加成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AddDepartmentMembers(AddDepartmentMembersReqDto requestBody)
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
        public async Task<IsSuccessRespDto> RemoveDepartmentMembers(RemoveDepartmentMembersReqDto requestBody)
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
        public async Task<DepartmentSingleRespDto> GetParentDepartment(GetParentDepartmentDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-parent-department", reqDto).ConfigureAwait(false);

            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 判断用户是否在某个部门下
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`。departmentId 和 departmentCode 必传其一。</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="includeChildrenDepartments">是否包含子部门</param>
        ///<returns>IsUserInDepartmentRespDto</returns>
        public async Task<IsUserInDepartmentRespDto> IsUserInDepartment(IsUserInDepartmentDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/is-user-in-department", reqDto).ConfigureAwait(false);

            IsUserInDepartmentRespDto result = m_JsonService.DeserializeObject<IsUserInDepartmentRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 根据部门id查询部门
        ///</summary>
        /// <param name="departmentId">部门 ID</param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> GetDepartmentById(GetDepartmentByIdDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-department-by-id", reqDto).ConfigureAwait(false);

            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 根据组织树批量创建部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateDepartmentTreeRespDto</returns>
        public async Task<CreateDepartmentTreeRespDto> CreateDepartmentTree(CreateDepartmentTreeReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-department-tree", requestBody).ConfigureAwait(false);

            CreateDepartmentTreeRespDto result = m_JsonService.DeserializeObject<CreateDepartmentTreeRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取分组详情
        ///</summary>
        /// <param name="code">分组 code</param>
        ///<returns>GroupSingleRespDto</returns>
        public async Task<GroupSingleRespDto> GetGroup(GetGroupDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-group", reqDto).ConfigureAwait(false);

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
        public async Task<GroupPaginatedRespDto> ListGroups(ListGroupsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-groups", reqDto).ConfigureAwait(false);

            GroupPaginatedRespDto result = m_JsonService.DeserializeObject<GroupPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GroupSingleRespDto</returns>
        public async Task<GroupSingleRespDto> CreateGroup(CreateGroupReqDto requestBody)
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
        public async Task<GroupListRespDto> CreateGroupsBatch(CreateGroupBatchReqDto requestBody)
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
        public async Task<GroupSingleRespDto> UpdateGroup(UpdateGroupReqDto requestBody)
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
        public async Task<IsSuccessRespDto> DeleteGroupsBatch(DeleteGroupsReqDto requestBody)
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
        public async Task<IsSuccessRespDto> AddGroupMembers(AddGroupMembersReqDto requestBody)
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
        public async Task<IsSuccessRespDto> RemoveGroupMembers(RemoveGroupMembersReqDto requestBody)
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
        public async Task<UserPaginatedRespDto> ListGroupMembers(ListGroupMembersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-group-members", reqDto).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取分组被授权的资源列表
        ///</summary>
        /// <param name="code">分组 code</param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        /// <param name="resourceType">资源类型</param>
        ///<returns>AuthorizedResourceListRespDto</returns>
        public async Task<AuthorizedResourceListRespDto> GetGroupAuthorizedResources(GetGroupAuthorizedResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-group-authorized-resources", reqDto).ConfigureAwait(false);

            AuthorizedResourceListRespDto result = m_JsonService.DeserializeObject<AuthorizedResourceListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取角色详情
        ///</summary>
        /// <param name="code">权限分组(权限空间)内角色的唯一标识符</param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        ///<returns>RoleSingleRespDto</returns>
        public async Task<RoleSingleRespDto> GetRole(GetRoleDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-role", reqDto).ConfigureAwait(false);

            RoleSingleRespDto result = m_JsonService.DeserializeObject<RoleSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 分配角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AssignRole(AssignRoleDto requestBody)
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
        public async Task<IsSuccessRespDto> RevokeRole(RevokeRoleDto requestBody)
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
        public async Task<RoleAuthorizedResourcePaginatedRespDto> GetRoleAuthorizedResources(GetRoleAuthorizedResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-role-authorized-resources", reqDto).ConfigureAwait(false);

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
        public async Task<UserPaginatedRespDto> ListRoleMembers(ListRoleMembersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-role-members", reqDto).ConfigureAwait(false);

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
        public async Task<RoleDepartmentListPaginatedRespDto> ListRoleDepartments(ListRoleDepartmentsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-role-departments", reqDto).ConfigureAwait(false);

            RoleDepartmentListPaginatedRespDto result = m_JsonService.DeserializeObject<RoleDepartmentListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>RoleSingleRespDto</returns>
        public async Task<RoleSingleRespDto> CreateRole(CreateRoleDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-role", requestBody).ConfigureAwait(false);

            RoleSingleRespDto result = m_JsonService.DeserializeObject<RoleSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取角色列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="keywords">用于根据角色的 code 或者名称进行模糊搜索，可选。</param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 code</param>
        ///<returns>RolePaginatedRespDto</returns>
        public async Task<RolePaginatedRespDto> ListRoles(ListRolesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-roles", reqDto).ConfigureAwait(false);

            RolePaginatedRespDto result = m_JsonService.DeserializeObject<RolePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 单个权限分组（权限空间）内删除角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteRolesBatch(DeleteRoleDto requestBody)
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
        public async Task<IsSuccessRespDto> CreateRolesBatch(CreateRolesBatch requestBody)
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
        public async Task<IsSuccessRespDto> UpdateRole(UpdateRoleDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-role", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 跨权限分组（空间）删除角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteRoles(DeleteRoleBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/multiple-namespace-delete-roles-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 校验角色 Code 或者名称是否可用
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>RoleCheckParamsRespDto</returns>
        public async Task<RoleCheckParamsRespDto> CheckParamsNamespace(CheckRoleParamsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-role-params", requestBody).ConfigureAwait(false);

            RoleCheckParamsRespDto result = m_JsonService.DeserializeObject<RoleCheckParamsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取角色授权列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>RoleListPageRespDto</returns>
        public async Task<RoleListPageRespDto> ListRoleAssignments(ListRoleAssignmentsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-role-assignments", reqDto).ConfigureAwait(false);

            RoleListPageRespDto result = m_JsonService.DeserializeObject<RoleListPageRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取身份源列表
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="appId">应用 ID</param>
        ///<returns>ExtIdpListPaginatedRespDto</returns>
        public async Task<ExtIdpListPaginatedRespDto> ListExtIdp(ListExtIdpDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-ext-idp", reqDto).ConfigureAwait(false);

            ExtIdpListPaginatedRespDto result = m_JsonService.DeserializeObject<ExtIdpListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取身份源详情
        ///</summary>
        /// <param name="id">身份源 ID</param>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="appId">应用 ID</param>
        /// <param name="type">身份源类型</param>
        ///<returns>ExtIdpDetailSingleRespDto</returns>
        public async Task<ExtIdpDetailSingleRespDto> GetExtIdp(GetExtIdpDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-ext-idp", reqDto).ConfigureAwait(false);

            ExtIdpDetailSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpDetailSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建身份源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpSingleRespDto</returns>
        public async Task<ExtIdpSingleRespDto> CreateExtIdp(CreateExtIdpDto requestBody)
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
        public async Task<ExtIdpSingleRespDto> UpdateExtIdp(UpdateExtIdpDto requestBody)
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
        public async Task<IsSuccessRespDto> DeleteExtIdp(DeleteExtIdpDto requestBody)
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
        public async Task<ExtIdpConnDetailSingleRespDto> CreateExtIdpConn(CreateExtIdpConnDto requestBody)
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
        public async Task<ExtIdpConnDetailSingleRespDto> UpdateExtIdpConn(UpdateExtIdpConnDto requestBody)
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
        public async Task<IsSuccessRespDto> DeleteExtIdpConn(DeleteExtIdpConnDto requestBody)
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
        public async Task<IsSuccessRespDto> ChangeExtIdpConnState(ChangeExtIdpConnStateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/change-ext-idp-conn-state", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 租户关联身份源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> ChangeExtIdpConnAssociationState(ChangeExtIdpAssociationStateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/change-ext-idp-conn-association-state", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 租户控制台获取身份源列表
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="appId">应用 ID</param>
        /// <param name="type">身份源类型</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>ExtIdpListPaginatedRespDto</returns>
        public async Task<ExtIdpListPaginatedRespDto> ListTenantExtIdp(ListTenantExtIdpDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-tenant-ext-idp", reqDto).ConfigureAwait(false);

            ExtIdpListPaginatedRespDto result = m_JsonService.DeserializeObject<ExtIdpListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 身份源下应用的连接详情
        ///</summary>
        /// <param name="id">身份源 ID</param>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="appId">应用 ID</param>
        /// <param name="type">身份源类型</param>
        ///<returns>ExtIdpListPaginatedRespDto</returns>
        public async Task<ExtIdpListPaginatedRespDto> ExtIdpConnStateByApps(ExtIdpConnAppsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/ext-idp-conn-apps", reqDto).ConfigureAwait(false);

            ExtIdpListPaginatedRespDto result = m_JsonService.DeserializeObject<ExtIdpListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户内置字段列表
        ///</summary>
        ///<returns>CustomFieldListRespDto</returns>
        public async Task<CustomFieldListRespDto> GetUserBaseFields()
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-base-fields").ConfigureAwait(false);

            CustomFieldListRespDto result = m_JsonService.DeserializeObject<CustomFieldListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改用户内置字段配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CustomFieldListRespDto</returns>
        public async Task<CustomFieldListRespDto> SetUserBaseFields(SetUserBaseFieldsReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-user-base-fields", requestBody).ConfigureAwait(false);

            CustomFieldListRespDto result = m_JsonService.DeserializeObject<CustomFieldListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取自定义字段列表
        ///</summary>
        /// <param name="targetType">目标对象类型：
        /// - `USER`: 用户
        /// - `ROLE`: 角色
        /// - `GROUP`: 分组
        /// - `DEPARTMENT`: 部门
        /// ;该接口暂不支持分组(GROUP)</param>
        ///<returns>CustomFieldListRespDto</returns>
        public async Task<CustomFieldListRespDto> GetCustomFields(GetCustomFieldsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-custom-fields", reqDto).ConfigureAwait(false);

            CustomFieldListRespDto result = m_JsonService.DeserializeObject<CustomFieldListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建/修改自定义字段定义
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CustomFieldListRespDto</returns>
        public async Task<CustomFieldListRespDto> SetCustomFields(SetCustomFieldsReqDto requestBody)
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
        public async Task<IsSuccessRespDto> SetCustomData(SetCustomDataReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-custom-data", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户、分组、角色、组织机构的自定义字段值
        ///</summary>
        /// <param name="targetType">目标对象类型：
        /// - `USER`: 用户
        /// - `ROLE`: 角色
        /// - `GROUP`: 分组
        /// - `DEPARTMENT`: 部门
        /// </param>
        /// <param name="targetIdentifier">目标对象的唯一标志符：
        /// - 如果是用户，为用户的 ID，如 `6343b98b7cfxxx9366e9b7c`
        /// - 如果是角色，为角色的 code，如 `admin`
        /// - 如果是分组，为分组的 code，如 `developer`
        /// - 如果是部门，为部门的 ID，如 `6343bafc019xxxx889206c4c`
        /// </param>
        /// <param name="nameSpace">所属权限分组的 code，当 targetType 为角色的时候需要填写，否则可以忽略</param>
        ///<returns>GetCustomDataRespDto</returns>
        public async Task<GetCustomDataRespDto> GetCustomData(GetCustomDataDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-custom-data", reqDto).ConfigureAwait(false);

            GetCustomDataRespDto result = m_JsonService.DeserializeObject<GetCustomDataRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ResourceRespDto</returns>
        public async Task<ResourceRespDto> CreateResource(CreateResourceDto requestBody)
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
        public async Task<IsSuccessRespDto> CreateResourcesBatch(CreateResourcesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-resources-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取资源详情
        ///</summary>
        /// <param name="code">资源唯一标志符</param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        ///<returns>ResourceRespDto</returns>
        public async Task<ResourceRespDto> GetResource(GetResourceDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-resource", reqDto).ConfigureAwait(false);

            ResourceRespDto result = m_JsonService.DeserializeObject<ResourceRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取资源详情
        ///</summary>
        /// <param name="codeList">资源 code 列表，批量可以使用逗号分隔</param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        ///<returns>ResourceListRespDto</returns>
        public async Task<ResourceListRespDto> GetResourcesBatch(GetResourcesBatchDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-resources-batch", reqDto).ConfigureAwait(false);

            ResourceListRespDto result = m_JsonService.DeserializeObject<ResourceListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 分页获取常规资源列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="keyword">查询条件</param>
        /// <param name="namespaceCodeList">权限空间列表</param>
        ///<returns>CommonResourcePaginatedRespDto</returns>
        public async Task<CommonResourcePaginatedRespDto> ListCommonResource(ListCommonResourceDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-common-resource", reqDto).ConfigureAwait(false);

            CommonResourcePaginatedRespDto result = m_JsonService.DeserializeObject<CommonResourcePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 分页获取资源列表
        ///</summary>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        /// <param name="type">资源类型</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>ResourcePaginatedRespDto</returns>
        public async Task<ResourcePaginatedRespDto> ListResources(ListResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-resources", reqDto).ConfigureAwait(false);

            ResourcePaginatedRespDto result = m_JsonService.DeserializeObject<ResourcePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ResourceRespDto</returns>
        public async Task<ResourceRespDto> UpdateResource(UpdateResourceDto requestBody)
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
        public async Task<IsSuccessRespDto> DeleteResource(DeleteResourceDto requestBody)
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
        public async Task<IsSuccessRespDto> DeleteResourcesBatch(DeleteResourcesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-resources-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteResourcesByIdBatch(DeleteCommonResourcesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-common-resources-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 关联/取消关联应用资源到租户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AssociateTenantResource(AssociateTenantResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/associate-tenant-resource", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建权限分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>NamespaceRespDto</returns>
        public async Task<NamespaceRespDto> CreateNamespace(CreateNamespaceDto requestBody)
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
        public async Task<IsSuccessRespDto> CreateNamespacesBatch(CreateNamespacesBatchDto requestBody)
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
        public async Task<NamespaceRespDto> GetNamespace(GetNamespaceDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-namespace", reqDto).ConfigureAwait(false);

            NamespaceRespDto result = m_JsonService.DeserializeObject<NamespaceRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取权限分组详情
        ///</summary>
        /// <param name="codeList">权限分组 code 列表，批量可以使用逗号分隔</param>
        ///<returns>NamespaceListRespDto</returns>
        public async Task<NamespaceListRespDto> GetNamespacesBatch(GetNamespacesBatchDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-namespaces-batch", reqDto).ConfigureAwait(false);

            NamespaceListRespDto result = m_JsonService.DeserializeObject<NamespaceListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改权限分组信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UpdateNamespaceRespDto</returns>
        public async Task<UpdateNamespaceRespDto> UpdateNamespace(UpdateNamespaceDto requestBody)
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
        public async Task<IsSuccessRespDto> DeleteNamespace(DeleteNamespaceDto requestBody)
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
        public async Task<IsSuccessRespDto> DeleteNamespacesBatch(DeleteNamespacesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-namespaces-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 分页获取权限分组列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="keywords">搜索权限分组 Code</param>
        ///<returns>NamespaceListPaginatedRespDto</returns>
        public async Task<NamespaceListPaginatedRespDto> ListNamespaces(ListNamespacesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-namespaces", reqDto).ConfigureAwait(false);

            NamespaceListPaginatedRespDto result = m_JsonService.DeserializeObject<NamespaceListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 分页权限分组下所有的角色列表
        ///</summary>
        /// <param name="code">权限分组唯一标志符</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="keywords">角色 Code 或者名称</param>
        ///<returns>NamespaceRolesListPaginatedRespDto</returns>
        public async Task<NamespaceRolesListPaginatedRespDto> ListNamespaceRoles(ListNamespaceRolesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-namespace-roles", reqDto).ConfigureAwait(false);

            NamespaceRolesListPaginatedRespDto result = m_JsonService.DeserializeObject<NamespaceRolesListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 授权资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AuthorizeResources(AuthorizeResourcesDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/authorize-resources", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取某个主体被授权的资源列表
        ///</summary>
        /// <param name="targetType">目标对象类型：
        /// - `USER`: 用户
        /// - `ROLE`: 角色
        /// - `GROUP`: 分组
        /// - `DEPARTMENT`: 部门
        /// </param>
        /// <param name="targetIdentifier">目标对象的唯一标志符：
        /// - 如果是用户，为用户的 ID，如 `6343b98b7cfxxx9366e9b7c`
        /// - 如果是角色，为角色的 code，如 `admin`
        /// - 如果是分组，为分组的 code，如 `developer`
        /// - 如果是部门，为部门的 ID，如 `6343bafc019xxxx889206c4c`
        /// </param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        /// <param name="resourceType">限定资源类型，如数据、API、按钮、菜单</param>
        /// <param name="resourceList">限定查询的资源列表，如果指定，只会返回所指定的资源列表。</param>
        /// <param name="withDenied">是否获取被拒绝的资源</param>
        ///<returns>AuthorizedResourcePaginatedRespDto</returns>
        public async Task<AuthorizedResourcePaginatedRespDto> GetAuthorizedResources(GetAuthorizedResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-authorized-resources", reqDto).ConfigureAwait(false);

            AuthorizedResourcePaginatedRespDto result = m_JsonService.DeserializeObject<AuthorizedResourcePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 判断用户是否对某个资源的某个操作有权限
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsActionAllowedRespDtp</returns>
        public async Task<IsActionAllowedRespDtp> IsActionAllowed(IsActionAllowedDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/is-action-allowed", requestBody).ConfigureAwait(false);

            IsActionAllowedRespDtp result = m_JsonService.DeserializeObject<IsActionAllowedRespDtp>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取资源被授权的主体
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GetResourceAuthorizedTargetRespDto</returns>
        public async Task<GetResourceAuthorizedTargetRespDto> GetResourceAuthorizedTargets(GetResourceAuthorizedTargetsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-resource-authorized-targets", requestBody).ConfigureAwait(false);

            GetResourceAuthorizedTargetRespDto result = m_JsonService.DeserializeObject<GetResourceAuthorizedTargetRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取同步任务详情
        ///</summary>
        /// <param name="syncTaskId">同步任务 ID</param>
        ///<returns>SyncTaskSingleRespDto</returns>
        public async Task<SyncTaskSingleRespDto> GetSyncTask(GetSyncTaskDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-sync-task", reqDto).ConfigureAwait(false);

            SyncTaskSingleRespDto result = m_JsonService.DeserializeObject<SyncTaskSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取同步任务列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>SyncTaskPaginatedRespDto</returns>
        public async Task<SyncTaskPaginatedRespDto> ListSyncTasks(ListSyncTasksDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-sync-tasks", reqDto).ConfigureAwait(false);

            SyncTaskPaginatedRespDto result = m_JsonService.DeserializeObject<SyncTaskPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建同步任务
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>SyncTaskPaginatedRespDto</returns>
        public async Task<SyncTaskPaginatedRespDto> CreateSyncTask(CreateSyncTaskDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-sync-task", requestBody).ConfigureAwait(false);

            SyncTaskPaginatedRespDto result = m_JsonService.DeserializeObject<SyncTaskPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改同步任务
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>SyncTaskPaginatedRespDto</returns>
        public async Task<SyncTaskPaginatedRespDto> UpdateSyncTask(UpdateSyncTaskDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-sync-task", requestBody).ConfigureAwait(false);

            SyncTaskPaginatedRespDto result = m_JsonService.DeserializeObject<SyncTaskPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 执行同步任务
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>TriggerSyncTaskRespDto</returns>
        public async Task<TriggerSyncTaskRespDto> TriggerSyncTask(TriggerSyncTaskDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/trigger-sync-task", requestBody).ConfigureAwait(false);

            TriggerSyncTaskRespDto result = m_JsonService.DeserializeObject<TriggerSyncTaskRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取同步作业详情
        ///</summary>
        /// <param name="syncJobId">同步作业 ID</param>
        ///<returns>SyncJobSingleRespDto</returns>
        public async Task<SyncJobSingleRespDto> GetSyncJob(GetSyncJobDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-sync-job", reqDto).ConfigureAwait(false);

            SyncJobSingleRespDto result = m_JsonService.DeserializeObject<SyncJobSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取同步作业详情
        ///</summary>
        /// <param name="syncTaskId">同步任务 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="syncTrigger">同步任务触发类型：
        /// - `manually`: 手动触发执行
        /// - `timed`: 定时触发
        /// - `automatic`: 根据事件自动触发
        /// </param>
        ///<returns>SyncJobPaginatedRespDto</returns>
        public async Task<SyncJobPaginatedRespDto> ListSyncJobs(ListSyncJobsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-sync-jobs", reqDto).ConfigureAwait(false);

            SyncJobPaginatedRespDto result = m_JsonService.DeserializeObject<SyncJobPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取同步作业详情
        ///</summary>
        /// <param name="syncJobId">同步作业 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="success">根据是否操作成功进行筛选</param>
        /// <param name="action">根据操作类型进行筛选：
        /// - `CreateUser`: 创建用户
        /// - `UpdateUser`: 修改用户信息
        /// - `DeleteUser`: 删除用户
        /// - `UpdateUserIdentifier`: 修改用户唯一标志符
        /// - `ChangeUserDepartment`: 修改用户部门
        /// - `CreateDepartment`: 创建部门
        /// - `UpdateDepartment`: 修改部门信息
        /// - `DeleteDepartment`: 删除部门
        /// - `MoveDepartment`: 移动部门
        /// - `UpdateDepartmentLeader`: 同步部门负责人
        /// - `CreateGroup`: 创建分组
        /// - `UpdateGroup`: 修改分组
        /// - `DeleteGroup`: 删除分组
        /// - `Updateless`: 无更新
        /// </param>
        /// <param name="objectType">操作对象类型:
        /// - `department`: 部门
        /// - `user`: 用户
        /// </param>
        ///<returns>TriggerSyncTaskRespDto</returns>
        public async Task<TriggerSyncTaskRespDto> ListSyncJobLogs(ListSyncJobLogsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-sync-job-logs", reqDto).ConfigureAwait(false);

            TriggerSyncTaskRespDto result = m_JsonService.DeserializeObject<TriggerSyncTaskRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取同步风险操作列表
        ///</summary>
        /// <param name="syncTaskId">同步任务 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="status">根据执行状态筛选</param>
        /// <param name="objectType">根据操作对象类型，默认获取所有类型的记录：
        /// - `department`: 部门
        /// - `user`: 用户
        /// </param>
        ///<returns>SyncRiskOperationPaginatedRespDto</returns>
        public async Task<SyncRiskOperationPaginatedRespDto> ListSyncRiskOperations(ListSyncRiskOperationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-sync-risk-operations", reqDto).ConfigureAwait(false);

            SyncRiskOperationPaginatedRespDto result = m_JsonService.DeserializeObject<SyncRiskOperationPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 执行同步风险操作
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>TriggerSyncRiskOperationsRespDto</returns>
        public async Task<TriggerSyncRiskOperationsRespDto> TriggerSyncRiskOperations(TriggerSyncRiskOperationDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/trigger-sync-risk-operations", requestBody).ConfigureAwait(false);

            TriggerSyncRiskOperationsRespDto result = m_JsonService.DeserializeObject<TriggerSyncRiskOperationsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 取消同步风险操作
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CancelSyncRiskOperationsRespDto</returns>
        public async Task<CancelSyncRiskOperationsRespDto> CancelSyncRiskOperation(CancelSyncRiskOperationDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/cancel-sync-risk-operation", requestBody).ConfigureAwait(false);

            CancelSyncRiskOperationsRespDto result = m_JsonService.DeserializeObject<CancelSyncRiskOperationsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户行为日志
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserActionLogRespDto</returns>
        public async Task<UserActionLogRespDto> GetUserActionLogs(GetUserActionLogsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-user-action-logs", requestBody).ConfigureAwait(false);

            UserActionLogRespDto result = m_JsonService.DeserializeObject<UserActionLogRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取管理员操作日志
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>AdminAuditLogRespDto</returns>
        public async Task<AdminAuditLogRespDto> GetAdminAuditLogs(GetAdminAuditLogsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-admin-audit-logs", requestBody).ConfigureAwait(false);

            AdminAuditLogRespDto result = m_JsonService.DeserializeObject<AdminAuditLogRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取邮件模版列表
        ///</summary>
        ///<returns>GetEmailTemplatesRespDto</returns>
        public async Task<GetEmailTemplatesRespDto> GetEmailTemplates()
        {
            string httpResponse = await Request("GET", "/api/v3/get-email-templates").ConfigureAwait(false);

            GetEmailTemplatesRespDto result = m_JsonService.DeserializeObject<GetEmailTemplatesRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改邮件模版
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>EmailTemplateSingleItemRespDto</returns>
        public async Task<EmailTemplateSingleItemRespDto> UpdateEmailTemplate(UpdateEmailTemplateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-email-template", requestBody).ConfigureAwait(false);

            EmailTemplateSingleItemRespDto result = m_JsonService.DeserializeObject<EmailTemplateSingleItemRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 预览邮件模版
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PreviewEmailTemplateRespDto</returns>
        public async Task<PreviewEmailTemplateRespDto> PreviewEmailTemplate(PreviewEmailTemplateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/preview-email-template", requestBody).ConfigureAwait(false);

            PreviewEmailTemplateRespDto result = m_JsonService.DeserializeObject<PreviewEmailTemplateRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取第三方邮件服务配置
        ///</summary>
        ///<returns>EmailProviderRespDto</returns>
        public async Task<EmailProviderRespDto> GetEmailProvider()
        {
            string httpResponse = await Request("GET", "/api/v3/get-email-provider").ConfigureAwait(false);

            EmailProviderRespDto result = m_JsonService.DeserializeObject<EmailProviderRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 配置第三方邮件服务
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>EmailProviderRespDto</returns>
        public async Task<EmailProviderRespDto> ConfigEmailProvider(ConfigEmailProviderDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/config-email-provider", requestBody).ConfigureAwait(false);

            EmailProviderRespDto result = m_JsonService.DeserializeObject<EmailProviderRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取应用详情
        ///</summary>
        /// <param name="appId">应用 ID</param>
        ///<returns>ApplicationSingleRespDto</returns>
        public async Task<ApplicationSingleRespDto> GetApplication(GetApplicationDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-application", reqDto).ConfigureAwait(false);

            ApplicationSingleRespDto result = m_JsonService.DeserializeObject<ApplicationSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取应用列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="isIntegrateApp">是否为集成应用</param>
        /// <param name="isSelfBuiltApp">是否为自建应用</param>
        /// <param name="ssoEnabled">是否开启单点登录</param>
        /// <param name="keywords">模糊搜索字符串</param>
        ///<returns>ApplicationPaginatedRespDto</returns>
        public async Task<ApplicationPaginatedRespDto> ListApplications(ListApplicationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-applications", reqDto).ConfigureAwait(false);

            ApplicationPaginatedRespDto result = m_JsonService.DeserializeObject<ApplicationPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取应用简单信息
        ///</summary>
        /// <param name="appId">应用 ID</param>
        ///<returns>ApplicationSimpleInfoSingleRespDto</returns>
        public async Task<ApplicationSimpleInfoSingleRespDto> GetApplicationSimpleInfo(GetApplicationSimpleInfoDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-application-simple-info", reqDto).ConfigureAwait(false);

            ApplicationSimpleInfoSingleRespDto result = m_JsonService.DeserializeObject<ApplicationSimpleInfoSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取应用简单信息列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="isIntegrateApp">是否为集成应用</param>
        /// <param name="isSelfBuiltApp">是否为自建应用</param>
        /// <param name="ssoEnabled">是否开启单点登录</param>
        /// <param name="keywords">模糊搜索字符串</param>
        ///<returns>ApplicationSimpleInfoPaginatedRespDto</returns>
        public async Task<ApplicationSimpleInfoPaginatedRespDto> ListApplicationSimpleInfo(ListApplicationSimpleInfoDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-application-simple-info", reqDto).ConfigureAwait(false);

            ApplicationSimpleInfoPaginatedRespDto result = m_JsonService.DeserializeObject<ApplicationSimpleInfoPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建应用
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ApplicationPaginatedRespDto</returns>
        public async Task<ApplicationPaginatedRespDto> CreateApplication(CreateApplicationDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-application", requestBody).ConfigureAwait(false);

            ApplicationPaginatedRespDto result = m_JsonService.DeserializeObject<ApplicationPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除应用
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteApplication(DeleteApplicationDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-application", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取应用密钥
        ///</summary>
        /// <param name="appId">应用 ID</param>
        ///<returns>GetApplicationSecretRespDto</returns>
        public async Task<GetApplicationSecretRespDto> GetApplicationSecret(GetApplicationSecretDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-application-secret", reqDto).ConfigureAwait(false);

            GetApplicationSecretRespDto result = m_JsonService.DeserializeObject<GetApplicationSecretRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 刷新应用密钥
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>RefreshApplicationSecretRespDto</returns>
        public async Task<RefreshApplicationSecretRespDto> RefreshApplicationSecret(RefreshApplicationSecretDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/refresh-application-secret", requestBody).ConfigureAwait(false);

            RefreshApplicationSecretRespDto result = m_JsonService.DeserializeObject<RefreshApplicationSecretRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取应用当前登录用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListApplicationActiveUsers(ListApplicationActiveUsersDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-application-active-users", requestBody).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取应用默认访问授权策略
        ///</summary>
        /// <param name="appId">应用 ID</param>
        ///<returns>GetApplicationPermissionStrategyRespDto</returns>
        public async Task<GetApplicationPermissionStrategyRespDto> GetApplicationPermissionStrategy(GetApplicationPermissionStrategyDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-application-permission-strategy", reqDto).ConfigureAwait(false);

            GetApplicationPermissionStrategyRespDto result = m_JsonService.DeserializeObject<GetApplicationPermissionStrategyRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 更新应用默认访问授权策略
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UpdateApplicationPermissionStrategy(UpdateApplicationPermissionStrategyDataDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-application-permission-strategy", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 授权应用访问权限
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AuthorizeApplicationAccess(AuthorizeApplicationAccessDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/authorize-application-access", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除应用访问授权记录
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> RevokeApplicationAccess(RevokeApplicationAccessDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/revoke-application-access", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 检测域名是否可用
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CheckDomainAvailableSecretRespDto</returns>
        public async Task<CheckDomainAvailableSecretRespDto> CheckDomainAvailable(CheckDomainAvailable requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-domain-available", requestBody).ConfigureAwait(false);

            CheckDomainAvailableSecretRespDto result = m_JsonService.DeserializeObject<CheckDomainAvailableSecretRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>AsaAccountSingleRespDto</returns>
        public async Task<AsaAccountSingleRespDto> CreateAsaAccount(CreateAsaAccountDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-asa-account", requestBody).ConfigureAwait(false);

            AsaAccountSingleRespDto result = m_JsonService.DeserializeObject<AsaAccountSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> CreateAsaAccountBatch(CreateAsaAccountsBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-asa-accounts-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>AsaAccountSingleRespDto</returns>
        public async Task<AsaAccountSingleRespDto> UpdateAsaAccount(UpdateAsaAccountDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-asa-account", requestBody).ConfigureAwait(false);

            AsaAccountSingleRespDto result = m_JsonService.DeserializeObject<AsaAccountSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 ASA 账号列表
        ///</summary>
        /// <param name="appId">所属应用 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>AsaAccountPaginatedRespDto</returns>
        public async Task<AsaAccountPaginatedRespDto> ListAsaAccount(ListAsaAccountsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-asa-accounts", reqDto).ConfigureAwait(false);

            AsaAccountPaginatedRespDto result = m_JsonService.DeserializeObject<AsaAccountPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取 ASA 账号
        ///</summary>
        /// <param name="appId">所属应用 ID</param>
        /// <param name="accountId">ASA 账号 ID</param>
        ///<returns>AsaAccountSingleRespDto</returns>
        public async Task<AsaAccountSingleRespDto> GetAsaAccount(GetAsaAccountDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-asa-account", reqDto).ConfigureAwait(false);

            AsaAccountSingleRespDto result = m_JsonService.DeserializeObject<AsaAccountSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>AsaAccountListRespDto</returns>
        public async Task<AsaAccountListRespDto> GetAsaAccountBatch(GetAsaAccountBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-asa-accounts-batch", requestBody).ConfigureAwait(false);

            AsaAccountListRespDto result = m_JsonService.DeserializeObject<AsaAccountListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteAsaAccount(DeleteAsaAccountDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-asa-account", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteAsaAccountBatch(DeleteAsaAccountBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-asa-accounts-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 分配 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AssignAsaAccount(AssignAsaAccountsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/assign-asa-account", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 取消分配 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UnassignAsaAccount(AssignAsaAccountsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/unassign-asa-account", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 ASA 账号分配的主体列表
        ///</summary>
        /// <param name="appId">所属应用 ID</param>
        /// <param name="accountId">ASA 账号 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>GetAsaAccountAssignedTargetRespDto</returns>
        public async Task<GetAsaAccountAssignedTargetRespDto> GetAsaAccountAssignedTargets(GetAsaAccountAssignedTargetsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-asa-account-assigned-targets", reqDto).ConfigureAwait(false);

            GetAsaAccountAssignedTargetRespDto result = m_JsonService.DeserializeObject<GetAsaAccountAssignedTargetRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取主体被分配的 ASA 账号
        ///</summary>
        /// <param name="appId">所属应用 ID</param>
        /// <param name="targetType">目标对象类型：
        /// - `USER`: 用户
        /// - `ROLE`: 角色
        /// - `GROUP`: 分组
        /// - `DEPARTMENT`: 部门
        /// </param>
        /// <param name="targetIdentifier">目标对象的唯一标志符：
        /// - 如果是用户，为用户的 ID，如 `6343b98b7cfxxx9366e9b7c`
        /// - 如果是角色，为角色的 code，如 `admin`
        /// - 如果是分组，为分组的 code，如 `developer`
        /// - 如果是部门，为部门的 ID，如 `6343bafc019xxxx889206c4c`
        /// </param>
        ///<returns>AsaAccountSingleNullableRespDto</returns>
        public async Task<AsaAccountSingleNullableRespDto> GetAssignedAccount(GetAssignedAccountDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-assigned-account", reqDto).ConfigureAwait(false);

            AsaAccountSingleNullableRespDto result = m_JsonService.DeserializeObject<AsaAccountSingleNullableRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取安全配置
        ///</summary>
        ///<returns>SecuritySettingsRespDto</returns>
        public async Task<SecuritySettingsRespDto> GetSecuritySettings()
        {
            string httpResponse = await Request("GET", "/api/v3/get-security-settings").ConfigureAwait(false);

            SecuritySettingsRespDto result = m_JsonService.DeserializeObject<SecuritySettingsRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改安全配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>SecuritySettingsRespDto</returns>
        public async Task<SecuritySettingsRespDto> UpdateSecuritySettings(UpdateSecuritySettingsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-security-settings", requestBody).ConfigureAwait(false);

            SecuritySettingsRespDto result = m_JsonService.DeserializeObject<SecuritySettingsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取全局多因素认证配置
        ///</summary>
        ///<returns>MFASettingsRespDto</returns>
        public async Task<MFASettingsRespDto> GetGlobalMfaSettings()
        {
            string httpResponse = await Request("GET", "/api/v3/get-global-mfa-settings").ConfigureAwait(false);

            MFASettingsRespDto result = m_JsonService.DeserializeObject<MFASettingsRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改全局多因素认证配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>MFASettingsRespDto</returns>
        public async Task<MFASettingsRespDto> UpdateGlobalMfaSettings(MFASettingsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-global-mfa-settings", requestBody).ConfigureAwait(false);

            MFASettingsRespDto result = m_JsonService.DeserializeObject<MFASettingsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建权限空间
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreatePermissionNamespaceResponseDto</returns>
        public async Task<CreatePermissionNamespaceResponseDto> CreatePermissionNamespace(CreatePermissionNamespaceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-permission-namespace", requestBody).ConfigureAwait(false);

            CreatePermissionNamespaceResponseDto result = m_JsonService.DeserializeObject<CreatePermissionNamespaceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建权限空间
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> CreatePermissionNamespacesBatch(CreatePermissionNamespacesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-permission-namespaces-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取权限空间详情
        ///</summary>
        /// <param name="code">权限空间 Code</param>
        ///<returns>GetPermissionNamespaceResponseDto</returns>
        public async Task<GetPermissionNamespaceResponseDto> GetPermissionNamespace(GetPermissionNamespaceDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-permission-namespace", reqDto).ConfigureAwait(false);

            GetPermissionNamespaceResponseDto result = m_JsonService.DeserializeObject<GetPermissionNamespaceResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取权限空间详情列表
        ///</summary>
        /// <param name="codes">权限空间 code 列表，批量可以使用逗号分隔</param>
        ///<returns>GetPermissionNamespaceListResponseDto</returns>
        public async Task<GetPermissionNamespaceListResponseDto> GetPermissionNamespacesBatch(GetPermissionNamespacesBatchDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-permission-namespaces-batch", reqDto).ConfigureAwait(false);

            GetPermissionNamespaceListResponseDto result = m_JsonService.DeserializeObject<GetPermissionNamespaceListResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 分页获取权限空间列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">权限空间 name</param>
        ///<returns>PermissionNamespaceListPaginatedRespDto</returns>
        public async Task<PermissionNamespaceListPaginatedRespDto> ListPermissionNamespaces(ListPermissionNamespacesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-permission-namespaces", reqDto).ConfigureAwait(false);

            PermissionNamespaceListPaginatedRespDto result = m_JsonService.DeserializeObject<PermissionNamespaceListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改权限空间
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UpdatePermissionNamespaceResponseDto</returns>
        public async Task<UpdatePermissionNamespaceResponseDto> UpdatePermissionNamespace(UpdatePermissionNamespaceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-permission-namespace", requestBody).ConfigureAwait(false);

            UpdatePermissionNamespaceResponseDto result = m_JsonService.DeserializeObject<UpdatePermissionNamespaceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除权限空间
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeletePermissionNamespace(DeletePermissionNamespaceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-permission-namespace", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除权限空间
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeletePermissionNamespacesBatch(DeletePermissionNamespacesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-permission-namespaces-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 校验权限空间 Code 或者名称是否可用
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PermissionNamespaceCheckExistsRespDto</returns>
        public async Task<PermissionNamespaceCheckExistsRespDto> CheckPermissionNamespaceExists(CheckPermissionNamespaceExistsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-permission-namespace-exists", requestBody).ConfigureAwait(false);

            PermissionNamespaceCheckExistsRespDto result = m_JsonService.DeserializeObject<PermissionNamespaceCheckExistsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 分页查询权限空间下所有的角色列表
        ///</summary>
        /// <param name="code">权限分组唯一标志符 Code</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">角色 Code 或者名称</param>
        ///<returns>PermissionNamespaceRolesListPaginatedRespDto</returns>
        public async Task<PermissionNamespaceRolesListPaginatedRespDto> ListPermissionNamespaceRoles(ListPermissionNamespaceRolesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-permission-namespace-roles", reqDto).ConfigureAwait(false);

            PermissionNamespaceRolesListPaginatedRespDto result = m_JsonService.DeserializeObject<PermissionNamespaceRolesListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建数据资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateDataResourceResponseDto</returns>
        public async Task<CreateDataResourceResponseDto> CreateDataResource(CreateDataResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-data-resource", requestBody).ConfigureAwait(false);

            CreateDataResourceResponseDto result = m_JsonService.DeserializeObject<CreateDataResourceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建字符串数据资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateStringDataResourceResponseDto</returns>
        public async Task<CreateStringDataResourceResponseDto> CreateDataResourceByString(CreateStringDataResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-string-data-resource", requestBody).ConfigureAwait(false);

            CreateStringDataResourceResponseDto result = m_JsonService.DeserializeObject<CreateStringDataResourceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建数组数据资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateArrayDataResourceResponseDto</returns>
        public async Task<CreateArrayDataResourceResponseDto> CreateDataResourceByArray(CreateArrayDataResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-array-data-resource", requestBody).ConfigureAwait(false);

            CreateArrayDataResourceResponseDto result = m_JsonService.DeserializeObject<CreateArrayDataResourceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建树数据资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateTreeDataResourceResponseDto</returns>
        public async Task<CreateTreeDataResourceResponseDto> CreateDataResourceByTree(CreateTreeDataResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-tree-data-resource", requestBody).ConfigureAwait(false);

            CreateTreeDataResourceResponseDto result = m_JsonService.DeserializeObject<CreateTreeDataResourceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取数据资源列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">关键字搜索，可以是数据资源名称或者数据资源 Code</param>
        /// <param name="namespaceCodes">权限数据所属权限空间 Code 列表</param>
        ///<returns>ListDataResourcesPaginatedRespDto</returns>
        public async Task<ListDataResourcesPaginatedRespDto> ListDataResources(ListDataResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-data-resources", reqDto).ConfigureAwait(false);

            ListDataResourcesPaginatedRespDto result = m_JsonService.DeserializeObject<ListDataResourcesPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取数据资源信息
        ///</summary>
        /// <param name="namespaceCode">数据资源所属的权限空间 Code</param>
        /// <param name="resourceCode">数据资源 Code,权限空间内唯一</param>
        ///<returns>GetDataResourceResponseDto</returns>
        public async Task<GetDataResourceResponseDto> GetDataResource(GetDataResourceDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-data-resource", reqDto).ConfigureAwait(false);

            GetDataResourceResponseDto result = m_JsonService.DeserializeObject<GetDataResourceResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改数据资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UpdateDataResourceResponseDto</returns>
        public async Task<UpdateDataResourceResponseDto> UpdateDataResource(UpdateDataResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-data-resource", requestBody).ConfigureAwait(false);

            UpdateDataResourceResponseDto result = m_JsonService.DeserializeObject<UpdateDataResourceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除数据资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeleteDataResource(DeleteDataResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-data-resource", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 检查数据资源名称或者 Code 是否可用
        ///</summary>
        /// <param name="namespaceCode">数据资源所属的权限空间 Code</param>
        /// <param name="resourceName">数据资源名称,权限空间内唯一</param>
        /// <param name="resourceCode">数据资源 Code,权限空间内唯一</param>
        ///<returns>CheckParamsDataResourceResponseDto</returns>
        public async Task<CheckParamsDataResourceResponseDto> CheckDataResourceExists(CheckDataResourceExistsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/check-data-resource-exists", reqDto).ConfigureAwait(false);

            CheckParamsDataResourceResponseDto result = m_JsonService.DeserializeObject<CheckParamsDataResourceResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建数据策略
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateDataPolicyResponseDto</returns>
        public async Task<CreateDataPolicyResponseDto> CreateDataPolicy(CreateDataPolicyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-data-policy", requestBody).ConfigureAwait(false);

            CreateDataPolicyResponseDto result = m_JsonService.DeserializeObject<CreateDataPolicyResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取数据策略列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">数据策略名称关键字搜索</param>
        ///<returns>ListDataPoliciesPaginatedRespDto</returns>
        public async Task<ListDataPoliciesPaginatedRespDto> ListDataPolices(ListDataPoliciesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-data-policies", reqDto).ConfigureAwait(false);

            ListDataPoliciesPaginatedRespDto result = m_JsonService.DeserializeObject<ListDataPoliciesPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取数据策略简略信息列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">数据策略名称关键字搜索</param>
        ///<returns>ListSimpleDataPoliciesPaginatedRespDto</returns>
        public async Task<ListSimpleDataPoliciesPaginatedRespDto> ListSimpleDataPolices(ListSimpleDataPoliciesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-simple-data-policies", reqDto).ConfigureAwait(false);

            ListSimpleDataPoliciesPaginatedRespDto result = m_JsonService.DeserializeObject<ListSimpleDataPoliciesPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取数据策略信息
        ///</summary>
        /// <param name="policyId">数据策略 ID</param>
        ///<returns>GetDataPolicyResponseDto</returns>
        public async Task<GetDataPolicyResponseDto> GetDataPolicy(GetDataPolicyDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-data-policy", reqDto).ConfigureAwait(false);

            GetDataPolicyResponseDto result = m_JsonService.DeserializeObject<GetDataPolicyResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改数据策略
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UpdateDataPolicyResponseDto</returns>
        public async Task<UpdateDataPolicyResponseDto> UpdateDataPolicy(UpdateDataPolicyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-data-policy", requestBody).ConfigureAwait(false);

            UpdateDataPolicyResponseDto result = m_JsonService.DeserializeObject<UpdateDataPolicyResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除数据策略
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeleteDataPolicy(DeleteDataPolicyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-data-policy", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 校验数据策略名称是否存在
        ///</summary>
        /// <param name="policyName">数据策略名称，用户池唯一</param>
        ///<returns>CheckParamsDataPolicyResponseDto</returns>
        public async Task<CheckParamsDataPolicyResponseDto> CheckDataPolicyExists(CheckDataPolicyExistsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/check-data-policy-exists", reqDto).ConfigureAwait(false);

            CheckParamsDataPolicyResponseDto result = m_JsonService.DeserializeObject<CheckParamsDataPolicyResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取数据策略下所有的授权主体的信息
        ///</summary>
        /// <param name="policyId">数据策略 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">主体名称</param>
        /// <param name="targetType">主体类型,包括 USER、GROUP、ROLE、ORG 四种类型</param>
        ///<returns>ListDataPolicySubjectPaginatedRespDto</returns>
        public async Task<ListDataPolicySubjectPaginatedRespDto> ListDataPolicyTargets(ListDataPolicyTargetsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-data-policy-targets", reqDto).ConfigureAwait(false);

            ListDataPolicySubjectPaginatedRespDto result = m_JsonService.DeserializeObject<ListDataPolicySubjectPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 授权数据策略
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> AuthorizeDataPolicies(CreateAuthorizeDataPolicyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/authorize-data-policies", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 撤销数据策略
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> RevokeDataPolicy(DeleteAuthorizeDataPolicyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/revoke-data-policy", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户权限列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GetUserPermissionListRespDto</returns>
        public async Task<GetUserPermissionListRespDto> GetUserPermissionList(GetUserPermissionListDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-user-permission-list", requestBody).ConfigureAwait(false);

            GetUserPermissionListRespDto result = m_JsonService.DeserializeObject<GetUserPermissionListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 判断用户权限
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CheckPermissionRespDto</returns>
        public async Task<CheckPermissionRespDto> CheckPermission(CheckPermissionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-permission", requestBody).ConfigureAwait(false);

            CheckPermissionRespDto result = m_JsonService.DeserializeObject<CheckPermissionRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 判断外部用户权限
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CheckExternalUserPermissionRespDto</returns>
        public async Task<CheckExternalUserPermissionRespDto> CheckExternalUserPermission(CheckExternalUserPermissionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-external-user-permission", requestBody).ConfigureAwait(false);

            CheckExternalUserPermissionRespDto result = m_JsonService.DeserializeObject<CheckExternalUserPermissionRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户指定资源权限列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GetUserResourcePermissionListRespDto</returns>
        public async Task<GetUserResourcePermissionListRespDto> GetUserResourcePermissionList(GetUserResourcePermissionListDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-user-resource-permission-list", requestBody).ConfigureAwait(false);

            GetUserResourcePermissionListRespDto result = m_JsonService.DeserializeObject<GetUserResourcePermissionListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取资源被授权的用户列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ListResourceTargetsRespDto</returns>
        public async Task<ListResourceTargetsRespDto> ListResourceTargets(ListResourceTargets requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-resource-targets", requestBody).ConfigureAwait(false);

            ListResourceTargetsRespDto result = m_JsonService.DeserializeObject<ListResourceTargetsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 判断用户在同层级资源下的权限
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CheckUserSameLevelPermissionResponseDto</returns>
        public async Task<CheckUserSameLevelPermissionResponseDto> CheckUserSameLevelPermission(CheckUserSameLevelPermissionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-user-same-level-permission", requestBody).ConfigureAwait(false);

            CheckUserSameLevelPermissionResponseDto result = m_JsonService.DeserializeObject<CheckUserSameLevelPermissionResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取套餐详情
        ///</summary>
        ///<returns>CostGetCurrentPackageRespDto</returns>
        public async Task<CostGetCurrentPackageRespDto> GetCurrentPackageInfo()
        {
            string httpResponse = await Request("GET", "/api/v3/get-current-package-info").ConfigureAwait(false);

            CostGetCurrentPackageRespDto result = m_JsonService.DeserializeObject<CostGetCurrentPackageRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用量详情
        ///</summary>
        ///<returns>CostGetCurrentUsageRespDto</returns>
        public async Task<CostGetCurrentUsageRespDto> GetUsageInfo()
        {
            string httpResponse = await Request("GET", "/api/v3/get-usage-info").ConfigureAwait(false);

            CostGetCurrentUsageRespDto result = m_JsonService.DeserializeObject<CostGetCurrentUsageRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取 MAU 使用记录
        ///</summary>
        /// <param name="startTime">起始时间（年月日）</param>
        /// <param name="endTime">截止时间（年月日）</param>
        ///<returns>CostGetMauPeriodUsageHistoryRespDto</returns>
        public async Task<CostGetMauPeriodUsageHistoryRespDto> GetMauPeriodUsageHistory(GetMauPeriodUsageHistoryDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-mau-period-usage-history", reqDto).ConfigureAwait(false);

            CostGetMauPeriodUsageHistoryRespDto result = m_JsonService.DeserializeObject<CostGetMauPeriodUsageHistoryRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取所有权益
        ///</summary>
        ///<returns>CostGetAllRightItemRespDto</returns>
        public async Task<CostGetAllRightItemRespDto> GetAllRightsItem()
        {
            string httpResponse = await Request("GET", "/api/v3/get-all-rights-items").ConfigureAwait(false);

            CostGetAllRightItemRespDto result = m_JsonService.DeserializeObject<CostGetAllRightItemRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取订单列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>CostGetOrdersRespDto</returns>
        public async Task<CostGetOrdersRespDto> GetOrders(GetOrdersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-orders", reqDto).ConfigureAwait(false);

            CostGetOrdersRespDto result = m_JsonService.DeserializeObject<CostGetOrdersRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取订单详情
        ///</summary>
        /// <param name="orderNo">订单号</param>
        ///<returns>CostGetOrderDetailRespDto</returns>
        public async Task<CostGetOrderDetailRespDto> GetOrderDetail(GetOrderDetailDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-order-detail", reqDto).ConfigureAwait(false);

            CostGetOrderDetailRespDto result = m_JsonService.DeserializeObject<CostGetOrderDetailRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取订单支付明细
        ///</summary>
        /// <param name="orderNo">订单号</param>
        ///<returns>CostGetOrderPayDetailRespDto</returns>
        public async Task<CostGetOrderPayDetailRespDto> GetOrderPayDetail(GetOrderPayDetailDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-order-pay-detail", reqDto).ConfigureAwait(false);

            CostGetOrderPayDetailRespDto result = m_JsonService.DeserializeObject<CostGetOrderPayDetailRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建 Pipeline 函数
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PipelineFunctionSingleRespDto</returns>
        public async Task<PipelineFunctionSingleRespDto> CreatePipelineFunction(CreatePipelineFunctionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-pipeline-function", requestBody).ConfigureAwait(false);

            PipelineFunctionSingleRespDto result = m_JsonService.DeserializeObject<PipelineFunctionSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 Pipeline 函数详情
        ///</summary>
        /// <param name="funcId">Pipeline 函数 ID</param>
        ///<returns>PipelineFunctionSingleRespDto</returns>
        public async Task<PipelineFunctionSingleRespDto> GetPipelineFunction(GetPipelineFunctionDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-pipeline-function", reqDto).ConfigureAwait(false);

            PipelineFunctionSingleRespDto result = m_JsonService.DeserializeObject<PipelineFunctionSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 重新上传 Pipeline 函数
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PipelineFunctionSingleRespDto</returns>
        public async Task<PipelineFunctionSingleRespDto> ReuploadPipelineFunction(ReUploadPipelineFunctionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/reupload-pipeline-function", requestBody).ConfigureAwait(false);

            PipelineFunctionSingleRespDto result = m_JsonService.DeserializeObject<PipelineFunctionSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改 Pipeline 函数
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PipelineFunctionSingleRespDto</returns>
        public async Task<PipelineFunctionSingleRespDto> UpdatePipelineFunction(UpdatePipelineFunctionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-pipeline-function", requestBody).ConfigureAwait(false);

            PipelineFunctionSingleRespDto result = m_JsonService.DeserializeObject<PipelineFunctionSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改 Pipeline 函数顺序
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> UpdatePipelineOrder(UpdatePipelineOrderDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-pipeline-order", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除 Pipeline 函数
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeletePipelineFunction(DeletePipelineFunctionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-pipeline-function", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 Pipeline 函数列表
        ///</summary>
        /// <param name="scene">通过函数的触发场景进行筛选（可选，默认返回所有）：
        /// - `PRE_REGISTER`: 注册前
        /// - `POST_REGISTER`: 注册后
        /// - `PRE_AUTHENTICATION`: 认证前
        /// - `POST_AUTHENTICATION`: 认证后
        /// - `PRE_OIDC_ID_TOKEN_ISSUED`: OIDC ID Token 签发前
        /// - `PRE_OIDC_ACCESS_TOKEN_ISSUED`: OIDC Access Token 签发前
        /// - `PRE_COMPLETE_USER_INFO`: 补全用户信息前
        /// </param>
        ///<returns>PipelineFunctionPaginatedRespDto</returns>
        public async Task<PipelineFunctionPaginatedRespDto> ListPipelineFunctions(ListPipelineFunctionsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-pipeline-functions", reqDto).ConfigureAwait(false);

            PipelineFunctionPaginatedRespDto result = m_JsonService.DeserializeObject<PipelineFunctionPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取 Pipeline 日志
        ///</summary>
        /// <param name="funcId">Pipeline 函数 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>PipelineFunctionPaginatedRespDto</returns>
        public async Task<PipelineFunctionPaginatedRespDto> GetPipelineLogs(GetPipelineLogsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-pipeline-logs", reqDto).ConfigureAwait(false);

            PipelineFunctionPaginatedRespDto result = m_JsonService.DeserializeObject<PipelineFunctionPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建 Webhook
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateWebhookRespDto</returns>
        public async Task<CreateWebhookRespDto> CreateWebhook(CreateWebhookDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-webhook", requestBody).ConfigureAwait(false);

            CreateWebhookRespDto result = m_JsonService.DeserializeObject<CreateWebhookRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 Webhook 列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>GetWebhooksRespDto</returns>
        public async Task<GetWebhooksRespDto> ListWebhooks(ListWebhooksDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-webhooks", reqDto).ConfigureAwait(false);

            GetWebhooksRespDto result = m_JsonService.DeserializeObject<GetWebhooksRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改 Webhook 配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UpdateWebhooksRespDto</returns>
        public async Task<UpdateWebhooksRespDto> UpdateWebhook(UpdateWebhookDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-webhook", requestBody).ConfigureAwait(false);

            UpdateWebhooksRespDto result = m_JsonService.DeserializeObject<UpdateWebhooksRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除 Webhook
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DeleteWebhookRespDto</returns>
        public async Task<DeleteWebhookRespDto> DeleteWebhook(DeleteWebhookDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-webhook", requestBody).ConfigureAwait(false);

            DeleteWebhookRespDto result = m_JsonService.DeserializeObject<DeleteWebhookRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 Webhook 日志
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ListWebhookLogsRespDto</returns>
        public async Task<ListWebhookLogsRespDto> GetWebhookLogs(ListWebhookLogs requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-webhook-logs", requestBody).ConfigureAwait(false);

            ListWebhookLogsRespDto result = m_JsonService.DeserializeObject<ListWebhookLogsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 手动触发 Webhook 执行
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>TriggerWebhookRespDto</returns>
        public async Task<TriggerWebhookRespDto> TriggerWebhook(TriggerWebhookDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/trigger-webhook", requestBody).ConfigureAwait(false);

            TriggerWebhookRespDto result = m_JsonService.DeserializeObject<TriggerWebhookRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 Webhook 详情
        ///</summary>
        /// <param name="webhookId">Webhook ID</param>
        ///<returns>GetWebhookRespDto</returns>
        public async Task<GetWebhookRespDto> GetWebhook(GetWebhookDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-webhook", reqDto).ConfigureAwait(false);

            GetWebhookRespDto result = m_JsonService.DeserializeObject<GetWebhookRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取 Webhook 事件列表
        ///</summary>
        ///<returns>WebhookEventListRespDto</returns>
        public async Task<WebhookEventListRespDto> GetWebhookEventList()
        {
            string httpResponse = await Request("GET", "/api/v3/get-webhook-event-list").ConfigureAwait(false);

            WebhookEventListRespDto result = m_JsonService.DeserializeObject<WebhookEventListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取协作管理员 AK/SK 列表
        ///</summary>
        /// <param name="userId">用户 ID</param>
        ///<returns>ListAccessKeyResponseDto</returns>
        public async Task<ListAccessKeyResponseDto> GetAccessKeyList(ListAccessKeyDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-access-key", reqDto).ConfigureAwait(false);

            ListAccessKeyResponseDto result = m_JsonService.DeserializeObject<ListAccessKeyResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取协作管理员 AK/Sk 详细信息
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="accessKeyId">accessKeyId</param>
        ///<returns>GetAccessKeyResponseDto</returns>
        public async Task<GetAccessKeyResponseDto> GetAccessKey(GetAccessKeyDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-access-key", reqDto).ConfigureAwait(false);

            GetAccessKeyResponseDto result = m_JsonService.DeserializeObject<GetAccessKeyResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建协作管理员的 AK/SK
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateAccessKeyResponseDto</returns>
        public async Task<CreateAccessKeyResponseDto> CreateAccessKey(CreateAccessKeyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-access-key", requestBody).ConfigureAwait(false);

            CreateAccessKeyResponseDto result = m_JsonService.DeserializeObject<CreateAccessKeyResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除协作管理员的 AK/SK
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeleteAccessKey(DeleteAccessKeyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-access-key", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
    }
}