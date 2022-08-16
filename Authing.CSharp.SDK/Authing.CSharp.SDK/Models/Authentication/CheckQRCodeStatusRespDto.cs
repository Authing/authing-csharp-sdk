using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class CheckQRCodeStatusRespDto
    {
        /// <summary>
        /// 业务状态码，可以通过此状态码判断操作是否成功，200 表示成功
        /// </summary>
        [JsonProperty("statusCode")]
        public long StatusCode { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 细分错误码，可通过此错误码得到具体的错误类型
        /// </summary>
        [JsonProperty("apicode")]
        public long ApiCode { get; set; }

        [JsonProperty("data")]
        public CheckQRCodeStatusResp Data { get; set; }
    }

    public class CheckQRCodeStatusResp
    {
        /// <summary>
        /// 二维码状态
        /// </summary>
        [JsonProperty("status")]
        public QRCodeStatus Status { get; set; }

        /// <summary>
        /// 当二维码状态为已授权时返回。如果在控制台应用安全 - 通用安全 - 登录安全 - APP 扫码登录 Web 安全中未开启「Web 轮询接口返回完整用户信息」（默认处于关闭状态），会返回此 ticket，用于换取完整的用户信息。
        /// </summary>
        public string Ticket { get; set; }

        /// <summary>
        /// 当二维码状态为已扫码、已授权、已取消授权时返回。
        /// 如果在控制台应用安全 - 通用安全 - 登录安全 - APP 扫码登录 Web 安全中未开启「Web 轮询接口返回完整用户信息」（默认处于关闭状态），
        /// 接口只会返回用户的头像和显示名称，前端可以基于此渲染用户昵称和头像，给到用户已成功扫码的提示。
        /// </summary>
        [JsonProperty("briefUserInfo")]
        public object BriefUserInfo { get; set; }

        /// <summary>
        /// 当二维码状态为已授权并且在控制台应用安全 - 通用安全 - 登录安全 - APP 扫码登录 Web 安全中开启了「Web 轮询接口返回完整用户信息」（默认处于关闭状态）开关，此数据才会返回。推荐使用 ticket 换取用户信息。
        /// </summary>
        [JsonProperty("tokenSet")]
        public object TokenSet { get; set; }
    }

    public enum QRCodeStatus
    {
        /// <summary>
        /// 二维码过期
        /// </summary>
        EXPIRED,
        /// <summary>
        /// 未扫码
        /// </summary>
        PENDING,
        /// <summary>
        /// 已扫码等待用户确认
        /// </summary>
        SCANNED,
        /// <summary>
        /// 用户同意
        /// </summary>
        AUTHORIZED,
        /// <summary>
        /// 取消授权
        /// </summary>
        CANCELLED,
        /// <summary>
        /// 未知错误
        /// </summary>
        ERROR
    }
}
