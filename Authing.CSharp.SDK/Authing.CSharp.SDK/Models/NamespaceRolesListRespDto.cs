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
    /// NamespaceRolesListRespDto 的模型
    /// </summary>
    public partial class NamespaceRolesListRespDto
    {
        /// <summary>
        ///  角色 ID
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
        /// <summary>
        ///  角色名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  角色 Code
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  角色 描述信息
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  权限分组 Code
        /// </summary>
        [JsonProperty("namespace")]
        public string  Namespace {get;set;}
        /// <summary>
        ///  更新时间
        /// </summary>
        [JsonProperty("updatedAt")]
        public string  UpdatedAt {get;set;}
    }
}