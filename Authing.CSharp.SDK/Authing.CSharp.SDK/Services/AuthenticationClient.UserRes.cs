using System.Collections.Generic;
using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Models.Authentication;
using static Authing.CSharp.SDK.Models.AuthorizedResourceDto;

namespace Authing.CSharp.SDK.Services
{
    public partial class AuthenticationClient
    {
        /// <summary>
        /// 获取登录日志
        /// </summary>
        /// <param name="param">获取登录日志参数类</param>
        /// <returns></returns>
        public async Task<GetLoginHistoryResDto> GetLoginHistory(GetLoginHistoryDto param)
        {
            Dictionary<string, string> dic = m_JsonService.DeserializeObject<Dictionary<string, string>>(m_JsonService.SerializeObject(param));

            string json = await GetAsync("/api/v3/get-login-history", dic, AccessToken).ConfigureAwait(false);
            GetLoginHistoryResDto res = m_JsonService.DeserializeObject<GetLoginHistoryResDto>(json);
            return res;
        }

        /// <summary>
        /// 获取登录应用
        /// </summary>
        /// <returns></returns>
        public async Task<GetLoggedInAppsResDto> GetLoggedInApps()
        {
            string json = await GetAsync("/api/v3/get-logged-in-apps", "", AccessToken);

            GetLoggedInAppsResDto result = m_JsonService.DeserializeObject<GetLoggedInAppsResDto>(json);

            return result;
        }

        /// <summary>
        /// 获取具备访问权限的应用
        /// </summary>
        /// <returns></returns>
        public async Task<GetAccessibleAppsResDto> GetAccessibleApps()
        {
            string json = await GetAsync("/api/v3/get-accessible-apps", "", AccessToken);

            GetAccessibleAppsResDto result = m_JsonService.DeserializeObject<GetAccessibleAppsResDto>(json);

            return result;
        }

        /// <summary>
        /// 获取租户列表
        /// </summary>
        /// <returns></returns>
        public async Task<GetTenantListResDto> GetTenantList()
        {
            string json = await GetAsync("/api/v3/get-tenant-list", "", AccessToken);

            GetTenantListResDto result = m_JsonService.DeserializeObject<GetTenantListResDto>(json);

            return result;
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <returns></returns>
        public async Task<GetRoleListResDto> GetRoleList()
        {
            string json = await GetAsync("/api/v3/get-role-list", "", AccessToken);

            GetRoleListResDto result = m_JsonService.DeserializeObject<GetRoleListResDto>(json);

            return result;
        }

        /// <summary>
        /// 获取分组列表
        /// </summary>
        /// <returns></returns>
        public async Task<GetGroupListResDto> GetGroupList()
        {
            string json = await GetAsync("/api/v3/get-group-list", "", AccessToken);

            GetGroupListResDto result = m_JsonService.DeserializeObject<GetGroupListResDto>(json);

            return result;
        }

        /// <summary>
        /// 获取部门列表
        /// </summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取部门自定义数据</param>
        /// <param name="departmentSortBy">排序依据</param>
        /// <param name="departmentOrderBy">增序或降序</param>
        /// <returns></returns>
        public async Task<GetDepartmentListResDto> GetDepartmentList(int page=1,int limit=10,bool withCustomData=false, DepartmentSortBy departmentSortBy= DepartmentSortBy.JoinDepartmentAt,DepartmentOrderBy departmentOrderBy=DepartmentOrderBy.Desc)
        {
            var dic = new 
            {
                page=page,
                limit= limit,
                withCustomData=withCustomData,
                sortBy= departmentSortBy,
                orderBy= departmentOrderBy,
            };

            string json = await GetAsync("/api/v3/get-department-list", m_JsonService.SerializeObject(dic), AccessToken);

            GetDepartmentListResDto result = m_JsonService.DeserializeObject<GetDepartmentListResDto>(json);
            return result;
        }

        /// <summary>
        /// 获取用户被授权的资源列表。
        /// </summary>
        /// <param name="nameSpace">所属权限分组的 code</param>
        /// <param name="resourceType">资源类型，如 数据、API、菜单、按钮</param>
        /// <returns></returns>
        public async Task<GetAuthorizedResourcesResDto> GetAuthorizedResources(string nameSpace, ResourceType resourceType )
        {
            var param = new 
            {
                @namespace=nameSpace,
                resourceType=resourceType
            };

            string json = await GetAsync("/api/v3/get-authorized-resources", m_JsonService.SerializeObject(param), AccessToken);

            GetAuthorizedResourcesResDto result = m_JsonService.DeserializeObject<GetAuthorizedResourcesResDto>(json);
            return result;
        }
    }
}
