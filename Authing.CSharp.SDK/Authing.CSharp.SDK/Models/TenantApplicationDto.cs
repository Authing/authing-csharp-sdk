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
    /// TenantApplicationDto 的模型
    /// </summary>
    public partial class TenantApplicationDto
    {
        /// <summary>
        ///  UserPool ID
        /// </summary>
        [JsonProperty("userPoolId")]
        public string  UserPoolId {get;set;}
        /// <summary>
        ///  App ID
        /// </summary>
        [JsonProperty("tenantAppId")]
        public string  TenantAppId {get;set;}
        /// <summary>
        ///  App 名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  应用描述信息
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  App Logo
        /// </summary>
        [JsonProperty("logo")]
        public string  Logo {get;set;}
        /// <summary>
        ///  应用类型
        /// </summary>
        [JsonProperty("applicationType")]
        public string  ApplicationType {get;set;}
        /// <summary>
        ///  是否开启 SSO 单点登录
        /// </summary>
        [JsonProperty("ssoEnabled")]
        public bool  SsoEnabled {get;set;}
        /// <summary>
        ///  App ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId {get;set;}
    }
}