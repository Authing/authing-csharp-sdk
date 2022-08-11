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
    /// ResetUserPrincipalAuthenticationInfoOptionsDto 的模型
    /// </summary>
    public partial class ResetUserPrincipalAuthenticationInfoOptionsDto
    {
        /// <summary>
        ///  用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。
        /// </summary>
        [JsonProperty("userIdType")]
        public userIdType UserIdType { get; set; }
    }
    public partial class ResetUserPrincipalAuthenticationInfoOptionsDto
    {
        /// <summary>
        ///  用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。
        /// </summary>
        public enum userIdType
        {
            [EnumMember(Value = "user_id")]
            USER_ID,
            [EnumMember(Value = "external_id")]
            EXTERNAL_ID,
            [EnumMember(Value = "phone")]
            PHONE,
            [EnumMember(Value = "email")]
            EMAIL,
            [EnumMember(Value = "username")]
            USERNAME,
        }
    }
}