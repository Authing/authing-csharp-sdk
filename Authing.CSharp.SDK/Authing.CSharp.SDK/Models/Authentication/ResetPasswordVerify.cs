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
    /// ResetPasswordVerify 的模型
    /// </summary>
    public partial class ResetPasswordVerify
    {
        /// <summary>
        ///  用于重置密码 token
        /// </summary>
        [JsonProperty("passwordResetToken")]
        public string PasswordResetToken { get; set; }
        /// <summary>
        ///  过期时间
        /// </summary>
        [JsonProperty("tokenExpiresIn")]
        public long TokenExpiresIn { get; set; }
    }
}