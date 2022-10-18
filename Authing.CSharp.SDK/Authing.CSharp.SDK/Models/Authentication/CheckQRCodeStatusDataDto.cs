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
    /// CheckQRCodeStatusDataDto 的模型
    /// </summary>
    public partial class CheckQRCodeStatusDataDto
    {
        /// <summary>
        ///  二维码状态。按照用户扫码顺序，共分为未扫码、已扫码等待用户确认、用户同意/取消授权、二维码过期以及未知错误六种状态。
        /// </summary>
        [JsonProperty("status")]
        public status Status { get; set; }
        /// <summary>
        ///  当二维码状态为已授权时返回。如果在控制台应用安全 - 通用安全 - 登录安全 - APP 扫码登录 Web 安全中未开启「Web 轮询接口返回完整用户信息」（默认处于关闭状态），会返回此 ticket，用于换取完整的用户信息。
        /// </summary>
        [JsonProperty("ticket")]
        public string Ticket { get; set; }
        [JsonProperty("briefUserInfo")]
        public QRCodeStatusBriefUserInfoDto BriefUserInfo { get; set; }
        /// <summary>
        ///  当二维码状态为已授权并且在控制台应用安全 - 通用安全 - 登录安全 - APP 扫码登录 Web 安全中开启了「Web 轮询接口返回完整用户信息」（默认处于关闭状态）开关，此数据才会返回。推荐使用 ticket 换取用户信息。
        /// </summary>
        [JsonProperty("tokenSet")]
        public LoginTokenResponseDataDto TokenSet { get; set; }
    }
    public partial class CheckQRCodeStatusDataDto
    {
        /// <summary>
        ///  二维码状态。按照用户扫码顺序，共分为未扫码、已扫码等待用户确认、用户同意/取消授权、二维码过期以及未知错误六种状态。
        /// </summary>
        public enum status
        {
            [EnumMember(Value = "EXPIRED")]
            EXPIRED,
            [EnumMember(Value = "PENDING")]
            PENDING,
            [EnumMember(Value = "SCANNED")]
            SCANNED,
            [EnumMember(Value = "AUTHORIZED")]
            AUTHORIZED,
            [EnumMember(Value = "CANCELLED")]
            CANCELLED,
            [EnumMember(Value = "ERROR")]
            ERROR,
        }
    }
}