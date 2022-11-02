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
    /// ApplicationBrandingConfigInputDto 的模型
    /// </summary>
    public partial class ApplicationBrandingConfigInputDto
    {
        /// <summary>
        ///  是否开启自定义 CSS
        /// </summary>
        [JsonProperty("customCSSEnabled")]
        public bool  CustomCSSEnabled {get;set;}
        /// <summary>
        ///  自定义 CSS 内容
        /// </summary>
        [JsonProperty("customCSS")]
        public string  CustomCSS {get;set;}
        /// <summary>
        ///  Guard 版本：
/// - `Advanced`: 高级版
/// - `Classical`: 经典版
/// 
        /// </summary>
        [JsonProperty("guardVersion")]
        public guardVersion  GuardVersion {get;set;}
        /// <summary>
        ///  自定义加载图标，当登录框加载时会展示
        /// </summary>
        [JsonProperty("customLoadingImage")]
        public string  CustomLoadingImage {get;set;}
        /// <summary>
        ///  自定义登录页背景，示例：
/// - 图片背景：`url(https://files.authing.co/user-contents/photos/6c6b3726-4a04-4ba7-b686-1a275f81a47a.png) center/cover`
/// - 纯色背景：`rgba(37,49,122,1)`
/// 
        /// </summary>
        [JsonProperty("customBackground")]
        public string  CustomBackground {get;set;}
        /// <summary>
        ///  是否显示切换语言按钮
        /// </summary>
        [JsonProperty("showChangeLanguageButton")]
        public bool  ShowChangeLanguageButton {get;set;}
        /// <summary>
        ///  展示的默认语言：
/// - `zh-CN`: 简体中文
/// - `zh-TW`: 繁体中文
/// - `en-US`: 英文
/// - `ja-JP`: 日语
///
/// 默认情况下，Authing 登录页会根据用户浏览器语言自动渲染。
/// 
        /// </summary>
        [JsonProperty("defaultLanguage")]
        public defaultLanguage  DefaultLanguage {get;set;}
        /// <summary>
        ///  是否显示忘记密码按钮
        /// </summary>
        [JsonProperty("showForgetPasswordButton")]
        public bool  ShowForgetPasswordButton {get;set;}
        /// <summary>
        ///  是否显示企业身份源登录方式
        /// </summary>
        [JsonProperty("showEnterpriseConnections")]
        public bool  ShowEnterpriseConnections {get;set;}
        /// <summary>
        ///  是否显示社会化登录方式
        /// </summary>
        [JsonProperty("showSocialConnections")]
        public bool  ShowSocialConnections {get;set;}
    }
    public partial class ApplicationBrandingConfigInputDto
    {
        /// <summary>
        ///  Guard 版本：
/// - `Advanced`: 高级版
/// - `Classical`: 经典版
/// 
        /// </summary>
        public enum guardVersion
        {
            [EnumMember(Value="Advanced")]
            ADVANCED,
            [EnumMember(Value="Classical")]
            CLASSICAL,
        }
        /// <summary>
        ///  展示的默认语言：
/// - `zh-CN`: 简体中文
/// - `zh-TW`: 繁体中文
/// - `en-US`: 英文
/// - `ja-JP`: 日语
///
/// 默认情况下，Authing 登录页会根据用户浏览器语言自动渲染。
/// 
        /// </summary>
        public enum defaultLanguage
        {
            [EnumMember(Value="zh-CN")]
            ZH_CN,
            [EnumMember(Value="en-US")]
            EN_US,
            [EnumMember(Value="zh-TW")]
            ZH_TW,
            [EnumMember(Value="ja-JP")]
            JA_JP,
        }
    }
}