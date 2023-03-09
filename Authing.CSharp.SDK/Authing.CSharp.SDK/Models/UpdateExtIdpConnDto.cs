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
    /// UpdateExtIdpConnDto 的模型
    /// </summary>
    public partial class UpdateExtIdpConnDto
    {
        /// <summary>
        ///  身份源连接 ID
        /// </summary>
        [JsonProperty("id")]
        public string  Id  {get;set;}
        /// <summary>
        ///  身份源连接显示名称
        /// </summary>
        [JsonProperty("displayName")]
        public string  DisplayName  {get;set;}
        /// <summary>
        ///  身份源连接自定义参数（增量修改）
        /// </summary>
        [JsonProperty("fields")]
        public object  Fields  {get;set;}
        /// <summary>
        ///  身份源连接的图标
        /// </summary>
        [JsonProperty("logo")]
        public string  Logo  {get;set;}
        /// <summary>
        ///  是否只支持登录
        /// </summary>
        [JsonProperty("loginOnly")]
        public bool  LoginOnly  {get;set;}
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId  {get;set;}
    }
}