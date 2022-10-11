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
    /// GetDepartmentListDto 的模型
    /// </summary>
    public partial class GetDepartmentListDto
    {
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public    object   Page    {get;set;}
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public    object   Limit    {get;set;}
        /// <summary>
        ///  是否获取部门的自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public    object   WithCustomData    {get;set;}
        /// <summary>
        ///  排序依据，如 部门创建时间、加入部门时间、部门名称、部门标志符
        /// </summary>
        [JsonProperty("sortBy")]
        public    object   SortBy    {get;set;}
        /// <summary>
        ///  增序或降序
        /// </summary>
        [JsonProperty("orderBy")]
        public    object   OrderBy    {get;set;}
    }
}