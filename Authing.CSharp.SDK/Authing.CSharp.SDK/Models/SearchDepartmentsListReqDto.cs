using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Authing.CSharp.SDK.Models
{
    /// <summary>
    /// SearchDepartmentsListReqDto 的模型
    /// </summary>
    public partial class SearchDepartmentsListReqDto
    {
        /// <summary>
        ///  组织 code
        /// </summary>
        [JsonProperty("organizationCode")]
        public string  OrganizationCode {get;set;}
        /// <summary>
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public bool  WithCustomData {get;set;}
        /// <summary>
        ///  是否获取 部门信息
        /// </summary>
        [JsonProperty("withPost")]
        public bool  WithPost {get;set;}
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;}
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;}
        /// <summary>
        ///  高级搜索
        /// </summary>
        [JsonProperty("advancedFilter")]
        public List<SearchDepartmentsFilterItemDto>  AdvancedFilter {get;set;}
        /// <summary>
        ///  排序依据，如 更新时间或创建时间
        /// </summary>
        [JsonProperty("sortBy")]
        public sortBy  SortBy {get;set;}
        /// <summary>
        ///  增序或降序
        /// </summary>
        [JsonProperty("orderBy")]
        public orderBy  OrderBy {get;set;}
        /// <summary>
        ///  排序设置，可以设置多项按照多个字段进行排序
        /// </summary>
        [JsonProperty("sort")]
        public List<DepartmentSortingDto>  Sort {get;set;}
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;}
    }
    public partial class SearchDepartmentsListReqDto
    {
        /// <summary>
        ///  排序依据，如 更新时间或创建时间
        /// </summary>
        public enum sortBy
        {
            [EnumMember(Value="updatedAt")]
            UPDATED_AT,
            [EnumMember(Value="createdAt")]
            CREATED_AT,
        }
        /// <summary>
        ///  增序或降序
        /// </summary>
        public enum orderBy
        {
            [EnumMember(Value="ASC")]
            ASC,
            [EnumMember(Value="DESC")]
            DESC,
        }
    }
}