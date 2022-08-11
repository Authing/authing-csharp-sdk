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
    /// SearchDepartmentsReqDto 的模型
    /// </summary>
    public partial class SearchDepartmentsReqDto
    {
        /// <summary>
        ///  搜索关键词，如组织名称等
        /// </summary>
        [JsonProperty("keywords")]
        public string Keywords { get; set; }
        /// <summary>
        ///  组织 code
        /// </summary>
        [JsonProperty("organizationCode")]
        public string OrganizationCode { get; set; }
        /// <summary>
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public bool WithCustomData { get; set; }
    }
}