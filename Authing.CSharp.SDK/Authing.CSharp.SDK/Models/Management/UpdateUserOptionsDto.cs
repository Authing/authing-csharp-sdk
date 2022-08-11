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
    /// UpdateUserOptionsDto 的模型
    /// </summary>
    public partial class UpdateUserOptionsDto
    {
        /// <summary>
        ///  用户 ID 类型，可以指定为用户 ID、手机号、邮箱、用户名和 externalId。
        /// </summary>
        [JsonProperty("userIdType")]
        public userIdType UserIdType { get; set; }
        /// <summary>
        ///  下次登录要求重置密码
        /// </summary>
        [JsonProperty("resetPasswordOnNextLogin")]
        public bool ResetPasswordOnNextLogin { get; set; }
        /// <summary>
        ///  是否自动生成密码
        /// </summary>
        [JsonProperty("autoGeneratePassword")]
        public bool AutoGeneratePassword { get; set; }
        /// <summary>
        ///  重置密码发送邮件和手机号选项
        /// </summary>
        [JsonProperty("sendPasswordResetedNotification")]
        public SendResetPasswordNotificationDto SendPasswordResetedNotification { get; set; }
    }
    public partial class UpdateUserOptionsDto
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