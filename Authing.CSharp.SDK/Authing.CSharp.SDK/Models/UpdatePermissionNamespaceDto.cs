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
    /// UpdatePermissionNamespaceDto 的模型
    /// </summary>
    public partial class UpdatePermissionNamespaceDto
    {
        /// <summary>
        ///  权限分组老的唯一标志符 Code
        /// </summary>
        [JsonProperty("code")]
        public string  Code  {get;set;}
        /// <summary>
        ///  权限空间名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name  {get;set;}
        /// <summary>
        ///  权限分组新的唯一标志符 Code
        /// </summary>
        [JsonProperty("newCode")]
        public string  NewCode  {get;set;}
        /// <summary>
        ///  权限空间描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description  {get;set;}
    }
}