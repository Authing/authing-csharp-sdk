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
    /// TenantRespDto 的模型
    /// </summary>
    public partial class TenantRespDto
    {
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId {get;set;}
        /// <summary>
        ///  用户池 ID
        /// </summary>
        [JsonProperty("userPoolId")]
        public string  UserPoolId {get;set;}
        /// <summary>
        ///  租户名
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  租户描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  租户 logo
        /// </summary>
        [JsonProperty("logo")]
        public List<string>  Logo {get;set;}
        /// <summary>
        ///  用户被租户拒绝登录时显示的提示文案
        /// </summary>
        [JsonProperty("rejectHint")]
        public string  RejectHint {get;set;}
        /// <summary>
        ///  租户关联的应用 ID
        /// </summary>
        [JsonProperty("appIds")]
        public List<string>  AppIds {get;set;}
        /// <summary>
        ///  创建者用户的 ID
        /// </summary>
        [JsonProperty("creator")]
        public string  Creator {get;set;}
        /// <summary>
        ///  租户来源的应用 ID，该值不存在时代表租户来源为 Authing 控制台
        /// </summary>
        [JsonProperty("sourceAppId")]
        public string  SourceAppId {get;set;}
        /// <summary>
        ///  租户来源
        /// </summary>
        [JsonProperty("source")]
        public string  Source {get;set;}
        /// <summary>
        ///  租户 Code
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  租户配置的企业域名
        /// </summary>
        [JsonProperty("enterpriseDomains")]
        public string  EnterpriseDomains {get;set;}
        /// <summary>
        ///  创建者基本信息
        /// </summary>
        [JsonProperty("creatorDetail")]
        public object  CreatorDetail {get;set;}
        /// <summary>
        ///  来源 app 基本信息
        /// </summary>
        [JsonProperty("sourceAppDetail")]
        public object  SourceAppDetail {get;set;}
    }
}