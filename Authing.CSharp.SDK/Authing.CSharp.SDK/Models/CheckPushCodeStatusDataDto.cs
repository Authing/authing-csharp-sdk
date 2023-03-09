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
    /// CheckPushCodeStatusDataDto 的模型
    /// </summary>
    public partial class CheckPushCodeStatusDataDto
    {
        /// <summary>
        ///  推送码状态。按照推送登录顺序，共分为 PUSHED(已推送)、AUTHORIZED(用户已授权)、CANCELLED(取消授权)、EXPIRED(推送登录过期)以及 ERROR(未知错误)五种状态。
        /// </summary>
        [JsonProperty("status")]
        public status  Status  {get;set;}
        /// <summary>
        ///  当推送码状态为已授权，此数据才会返回。
        /// </summary>
        [JsonProperty("tokenSet")]
        public LoginTokenResponseDataDto  TokenSet  {get;set;}
    }
    public partial class CheckPushCodeStatusDataDto
    {
        /// <summary>
        ///  推送码状态。按照推送登录顺序，共分为 PUSHED(已推送)、AUTHORIZED(用户已授权)、CANCELLED(取消授权)、EXPIRED(推送登录过期)以及 ERROR(未知错误)五种状态。
        /// </summary>
        public enum status
        {
            [EnumMember(Value="PUSHED")]
            PUSHED,
            [EnumMember(Value="AUTHORIZED")]
            AUTHORIZED,
            [EnumMember(Value="CANCELLED")]
            CANCELLED,
            [EnumMember(Value="EXPIRED")]
            EXPIRED,
            [EnumMember(Value="ERROR")]
            ERROR,
        }
    }
}