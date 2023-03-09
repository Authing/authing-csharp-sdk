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
    /// PermissionNamespacesListRespDto 的模型
    /// </summary>
    public partial class PermissionNamespacesListRespDto
    {
        /// <summary>
        ///  权限空间 名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name  {get;set;}
        /// <summary>
        ///  权限空间 Code
        /// </summary>
        [JsonProperty("code")]
        public string  Code  {get;set;}
        /// <summary>
        ///  权限空间描述信息
        /// </summary>
        [JsonProperty("description")]
        public string  Description  {get;set;}
        /// <summary>
        ///  权限空间状态：0 -> 关闭、1 -> 开启
        /// </summary>
        [JsonProperty("status")]
        public long  Status  {get;set;}
    }
}