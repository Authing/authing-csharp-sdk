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
    /// UserPoolTenantConfigDto 的模型
    /// </summary>
    public partial class UserPoolTenantConfigDto
    {
        /// <summary>
        ///  UserPool ID
        /// </summary>
        [JsonProperty("userPoolId")]
        public string  UserPoolId {get;set;}
        /// <summary>
        ///  用户池是否作为租户
        /// </summary>
        [JsonProperty("isUserPoolAsTenant")]
        public bool  IsUserPoolAsTenant {get;set;}
        /// <summary>
        ///  允许切换的类型
        /// </summary>
        [JsonProperty("enableSwitchType")]
        public enableSwitchType  EnableSwitchType {get;set;}
        /// <summary>
        ///  自定义 CSS
        /// </summary>
        [JsonProperty("css")]
        public string  Css {get;set;}
        /// <summary>
        ///  是否启用自定义 CSS
        /// </summary>
        [JsonProperty("cssEnabled")]
        public bool  CssEnabled {get;set;}
        /// <summary>
        ///  自定义 Loading
        /// </summary>
        [JsonProperty("customLoading")]
        public string  CustomLoading {get;set;}
        /// <summary>
        ///  是否开启 Guard 切换
        /// </summary>
        [JsonProperty("enableGuardVersionSwitch")]
        public bool  EnableGuardVersionSwitch {get;set;}
        /// <summary>
        ///  使用 Guard 的版本
        /// </summary>
        [JsonProperty("guardVersion")]
        public string  GuardVersion {get;set;}
        /// <summary>
        ///  自定义 Loading 背景
        /// </summary>
        [JsonProperty("loadingBackground")]
        public string  LoadingBackground {get;set;}
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
        /// <summary>
        ///  页面自定义配置
        /// </summary>
        [JsonProperty("ssoPageCustomizationSettings")]
        public ISsoPageCustomizationSettingsDto  SsoPageCustomizationSettings {get;set;}
        /// <summary>
        ///  是否允许选择门户登录
        /// </summary>
        [JsonProperty("enableMultipleTenantPortal")]
        public bool  EnableMultipleTenantPortal {get;set;}
        /// <summary>
        ///  登录配置
        /// </summary>
        [JsonProperty("loginConfig")]
        public ApplicationLoginConfigDto  LoginConfig {get;set;}
    }
    public partial class UserPoolTenantConfigDto
    {
        /// <summary>
        ///  允许切换的类型
        /// </summary>
        public enum enableSwitchType
        {
            [EnumMember(Value="tenant-console")]
            TENANT_CONSOLE,
            [EnumMember(Value="tenant-app")]
            TENANT_APP,
            [EnumMember(Value="tenant-launpad")]
            TENANT_LAUNPAD,
        }
    }
}