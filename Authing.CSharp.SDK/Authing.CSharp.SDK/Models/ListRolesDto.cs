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
    /// ListRolesDto 的模型
    /// </summary>
    public partial class ListRolesDto
    {
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public long  Page {get;set;} =1;
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;} =10;
        /// <summary>
        ///  用于根据角色的 code 或者名称进行模糊搜索，可选。
        /// </summary>
        [JsonProperty("keywords")]
        public string  Keywords {get;set;} 
        /// <summary>
        ///  所属权限分组(权限空间)的 code
        /// </summary>
        [JsonProperty("namespace")]
        public string  Namespace {get;set;} 
    }
}