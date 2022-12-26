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
    /// ListPermissionNamespaceRolesDto 的模型
    /// </summary>
    public partial class ListPermissionNamespaceRolesDto
    {
        /// <summary>
        ///  权限分组唯一标志符 Code
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;} 
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
        ///  角色 Code 或者名称
        /// </summary>
        [JsonProperty("query")]
        public string  Query {get;set;} 
    }
}