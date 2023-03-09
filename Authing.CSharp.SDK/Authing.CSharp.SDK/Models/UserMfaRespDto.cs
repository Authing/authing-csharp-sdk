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
    /// UserMfaRespDto 的模型
    /// </summary>
    public partial class UserMfaRespDto
    {
        /// <summary>
        ///  是否绑定了 TOTP，可选值 enabled, disabled
        /// </summary>
        [JsonProperty("totpStatus")]
        public string  TotpStatus  {get;set;}
        /// <summary>
        ///  是否绑定了人脸 MFA，可选值 enabled, disabled
        /// </summary>
        [JsonProperty("faceMfaStatus")]
        public string  FaceMfaStatus  {get;set;}
        /// <summary>
        ///  是否绑定了 SMS MFA，可选值 enabled, disabled
        /// </summary>
        [JsonProperty("smsMfaStatus")]
        public string  SmsMfaStatus  {get;set;}
        /// <summary>
        ///  是否绑定了 EMAIL MFA，可选值 enabled, disabled
        /// </summary>
        [JsonProperty("emailMfaStatus")]
        public string  EmailMfaStatus  {get;set;}
    }
}