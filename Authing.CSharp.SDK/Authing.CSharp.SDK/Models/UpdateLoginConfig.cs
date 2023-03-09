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
        [JsonProperty("ssoPageCustomizationSettings")]
        public ISsoPageCustomizationSettingsDto  SsoPageCustomizationSettings  {get;set;}
        [JsonProperty("passwordTabConfig")]
        public TabConfigDto  PasswordTabConfig  {get;set;}
        [JsonProperty("verifyCodeTabConfig")]
        public TabConfigDto  VerifyCodeTabConfig  {get;set;}
        [JsonProperty("config")]
        public LanguageCoinfigDto  Config  {get;set;}
    }
}