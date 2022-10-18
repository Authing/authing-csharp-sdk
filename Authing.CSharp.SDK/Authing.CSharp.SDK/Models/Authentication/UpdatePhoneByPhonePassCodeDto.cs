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
    /// UpdatePhoneByPhonePassCodeDto 的模型
    /// </summary>
    public partial class UpdatePhoneByPhonePassCodeDto
    {
        /// <summary>
        ///  新手机号码，不带区号。如果是国外手机号，请在 newPhoneCountryCode 参数中指定区号。
        /// </summary>
        [JsonProperty("newPhoneNumber")]
        public string NewPhoneNumber { get; set; }
        /// <summary>
        ///  验证码
        /// </summary>
        [JsonProperty("newPhonePassCode")]
        public string NewPhonePassCode { get; set; }
        /// <summary>
        ///  手机区号，中国大陆手机号可不填。Authing 短信服务暂不内置支持国际手机号，你需要在 Authing 控制台配置对应的国际短信服务。完整的手机区号列表可参阅 https://en.wikipedia.org/wiki/List_of_country_calling_codes。
        /// </summary>
        [JsonProperty("newPhoneCountryCode")]
        public string NewPhoneCountryCode { get; set; }
        /// <summary>
        ///  旧手机号码，不带区号。如果是国外手机号，请在 oldPhoneCountryCode 参数中指定区号。如果用户池开启了修改手机号需要验证之前的手机号，此参数必填。
        /// </summary>
        [JsonProperty("oldPhoneNumber")]
        public string OldPhoneNumber { get; set; }
        /// <summary>
        ///  旧手机号的验证码，如果用户池开启了修改手机号需要验证之前的手机号，此参数必填
        /// </summary>
        [JsonProperty("oldPhonePassCode")]
        public string OldPhonePassCode { get; set; }
        /// <summary>
        ///  手机区号，中国大陆手机号可不填。Authing 短信服务暂不内置支持国际手机号，你需要在 Authing 控制台配置对应的国际短信服务。完整的手机区号列表可参阅 https://en.wikipedia.org/wiki/List_of_country_calling_codes。
        /// </summary>
        [JsonProperty("oldPhoneCountryCode")]
        public string OldPhoneCountryCode { get; set; }
    }
}