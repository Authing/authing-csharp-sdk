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
    /// UpdateLoginConfig 的模型
    /// </summary>
    public partial class UpdateLoginConfig
    {
        [JsonProperty("tabMethodsSortConfig")]
        public ApplicationTabMethodsSortConfigDto  TabMethodsSortConfig {get;set;}
        [JsonProperty("qrCodeSortConfig")]
        public ApplicationTabMethodsSortConfigDto  QrCodeSortConfig {get;set;}
        [JsonProperty("ssoPageCustomizationSettings")]
        public ISsoPageCustomizationSettingsDto  SsoPageCustomizationSettings {get;set;}
        [JsonProperty("passwordTabConfig")]
        public TabConfigDto  PasswordTabConfig {get;set;}
        [JsonProperty("verifyCodeTabConfig")]
        public TabConfigDto  VerifyCodeTabConfig {get;set;}
        [JsonProperty("config")]
        public LanguageCoinfigDto  Config {get;set;}
        /// <summary>
        ///  是否允许创建租户
        /// </summary>
        [JsonProperty("enableCreateTenant")]
        public bool  EnableCreateTenant {get;set;}
        /// <summary>
        ///  允许创建租户的场景
        /// </summary>
        [JsonProperty("createTenantScenes")]
        public List<string>  CreateTenantScenes {get;set;}
        /// <summary>
        ///  是否允许加入租户
        /// </summary>
        [JsonProperty("enableJoinTenant")]
        public bool  EnableJoinTenant {get;set;}
        /// <summary>
        ///  允许创建加入的场景
        /// </summary>
        [JsonProperty("joinTenantScenes")]
        public List<string>  JoinTenantScenes {get;set;}
        /// <summary>
        ///  是否校验企业域名
        /// </summary>
        [JsonProperty("enableVerifyDomain")]
        public bool  EnableVerifyDomain {get;set;}
        /// <summary>
        ///  校验企业域名的场景
        /// </summary>
        [JsonProperty("verifyDomainScenes")]
        public List<string>  VerifyDomainScenes {get;set;}
    }
}