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
    /// AuthorizeResourcesDto 的模型
    /// </summary>
    public partial class AuthorizeResourcesDto
    {
        /// <summary>
        ///  授权资源列表
        /// </summary>
        [JsonProperty("list")]
        public    List<AuthorizeResourceItem>   List    {get;set;}
        /// <summary>
        ///  所属权限分组的 code
        /// </summary>
        [JsonProperty("namespace")]
        public    string   Namespace    {get;set;}
    }
}