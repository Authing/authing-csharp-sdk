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
    /// OtpSecretRespDto 的模型
    /// </summary>
    public partial class OtpSecretRespDto
    {
        /// <summary>
        ///  MFA OTP 秘钥
        /// </summary>
        [JsonProperty("secret")]
        public string  Secret  {get;set;}
    }
}