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
    /// SendEmailDto 的模型
    /// </summary>
    public partial class SendEmailDto
    {
        /// <summary>
        ///  短信通道，指定发送此短信的目的：
        /// - `CHANNEL_LOGIN`: 用户用户登录
        /// - `CHANNEL_REGISTER`: 用于用户注册
        /// - `CHANNEL_RESET_PASSWORD`: 用于重置密码
        /// - `CHANNEL_VERIFY_EMAIL_LINK`: 用于验证邮箱地址
        /// - `CHANNEL_UPDATE_EMAIL`: 用于修改邮箱
        /// - `CHANNEL_BIND_EMAIL`: 用于绑定邮箱
        /// - `CHANNEL_UNBIND_EMAIL`: 用于解绑邮箱
        /// - `CHANNEL_VERIFY_MFA`: 用于验证 MFA
        /// - `CHANNEL_UNLOCK_ACCOUNT`: 用于自助解锁
        /// - `CHANNEL_COMPLETE_EMAIL`: 用于注册/登录时补全邮箱信息
        ///
        /// </summary>
        [JsonProperty("channel")]
        public    channel   Channel    {get;set;}
        /// <summary>
        ///  邮箱，不区分大小写
        /// </summary>
        [JsonProperty("email")]
        public    string   Email    {get;set;}
    }
    public partial class SendEmailDto
    {
        /// <summary>
        ///  短信通道，指定发送此短信的目的：
        /// - `CHANNEL_LOGIN`: 用户用户登录
        /// - `CHANNEL_REGISTER`: 用于用户注册
        /// - `CHANNEL_RESET_PASSWORD`: 用于重置密码
        /// - `CHANNEL_VERIFY_EMAIL_LINK`: 用于验证邮箱地址
        /// - `CHANNEL_UPDATE_EMAIL`: 用于修改邮箱
        /// - `CHANNEL_BIND_EMAIL`: 用于绑定邮箱
        /// - `CHANNEL_UNBIND_EMAIL`: 用于解绑邮箱
        /// - `CHANNEL_VERIFY_MFA`: 用于验证 MFA
        /// - `CHANNEL_UNLOCK_ACCOUNT`: 用于自助解锁
        /// - `CHANNEL_COMPLETE_EMAIL`: 用于注册/登录时补全邮箱信息
        ///
        /// </summary>
        public enum channel
        {
            [EnumMember(Value="CHANNEL_LOGIN")]
            CHANNEL_LOGIN,
            [EnumMember(Value="CHANNEL_REGISTER")]
            CHANNEL_REGISTER,
            [EnumMember(Value="CHANNEL_RESET_PASSWORD")]
            CHANNEL_RESET_PASSWORD,
            [EnumMember(Value="CHANNEL_VERIFY_EMAIL_LINK")]
            CHANNEL_VERIFY_EMAIL_LINK,
            [EnumMember(Value="CHANNEL_UPDATE_EMAIL")]
            CHANNEL_UPDATE_EMAIL,
            [EnumMember(Value="CHANNEL_BIND_EMAIL")]
            CHANNEL_BIND_EMAIL,
            [EnumMember(Value="CHANNEL_UNBIND_EMAIL")]
            CHANNEL_UNBIND_EMAIL,
            [EnumMember(Value="CHANNEL_VERIFY_MFA")]
            CHANNEL_VERIFY_MFA,
            [EnumMember(Value="CHANNEL_UNLOCK_ACCOUNT")]
            CHANNEL_UNLOCK_ACCOUNT,
            [EnumMember(Value="CHANNEL_COMPLETE_EMAIL")]
            CHANNEL_COMPLETE_EMAIL,
        }
    }
}