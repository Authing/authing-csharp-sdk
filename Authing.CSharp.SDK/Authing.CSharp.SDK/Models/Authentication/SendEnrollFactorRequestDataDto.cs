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
    /// SendEnrollFactorRequestDataDto 的模型
    /// </summary>
    public partial class SendEnrollFactorRequestDataDto
    {
        /// <summary>
        ///  临时凭证 enrollmentToken，有效时间为一分钟。在进行「绑定 MFA 认证要素」时，需要带上此参数。
        /// </summary>
        [JsonProperty("enrollmentToken")]
        public    string   EnrollmentToken    {get;set;}
        /// <summary>
        ///  发起绑定 OTP 类型认证要素时，接口会返回此数据。
        /// </summary>
        [JsonProperty("otpData")]
        public    SendEnrollFactorRequestOtpDataDto   OtpData    {get;set;}
    }
}