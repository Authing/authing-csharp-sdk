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
    /// UpdateEmailByEmailPassCodeDto 的模型
    /// </summary>
    public partial class UpdateEmailByEmailPassCodeDto
    {
        /// <summary>
        ///  新邮箱
        /// </summary>
        [JsonProperty("newEmail")]
        public string NewEmail { get; set; }
        /// <summary>
        ///  新邮箱验证码
        /// </summary>
        [JsonProperty("newEmailPassCode")]
        public string NewEmailPassCode { get; set; }
        /// <summary>
        ///  旧邮箱，如果用户池开启了修改邮箱需要验证之前的邮箱，此参数必填。
        /// </summary>
        [JsonProperty("oldEmail")]
        public string OldEmail { get; set; }
        /// <summary>
        ///  旧邮箱验证码，如果用户池开启了修改邮箱需要验证之前的邮箱，此参数必填。
        /// </summary>
        [JsonProperty("oldEmailPassCode")]
        public string OldEmailPassCode { get; set; }
    }
}