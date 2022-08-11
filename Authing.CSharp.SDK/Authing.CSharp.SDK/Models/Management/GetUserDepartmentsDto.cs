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
    /// GetUserDepartmentsDto 的模型
    /// </summary>
    public partial class GetUserDepartmentsDto
    {
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public object UserId { get; set; }
        /// <summary>
        ///  用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。
        /// </summary>
        [JsonProperty("userIdType")]
        public object UserIdType { get; set; }
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public object Page { get; set; }
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public object Limit { get; set; }
        /// <summary>
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public object WithCustomData { get; set; }
        /// <summary>
        ///  排序依据，如 部门创建时间、加入部门时间、部门名称、部门标志符
        /// </summary>
        [JsonProperty("sortBy")]
        public object SortBy { get; set; }
        /// <summary>
        ///  增序或降序
        /// </summary>
        [JsonProperty("orderBy")]
        public object OrderBy { get; set; }
    }
}