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
    /// ExchangeTokenSetWithQRcodeTicketDto 的模型
    /// </summary>
    public partial class ExchangeTokenSetWithQRcodeTicketDto
    {
        /// <summary>
        ///  当二维码状态为已授权时返回。如果在控制台应用安全 - 通用安全 - 登录安全 - APP 扫码登录 Web 安全中未开启「Web 轮询接口返回完整用户信息」（默认处于关闭状态），会返回此 ticket，用于换取完整的用户信息。
        /// </summary>
        [JsonProperty("ticket")]
        public string  Ticket  {get;set;}
        /// <summary>
        ///  应用 ID。当应用的「换取 token 身份验证方式」配置为 `client_secret_post` 需要传。
        /// </summary>
        [JsonProperty("client_id")]
        public string  Client_id  {get;set;}
        /// <summary>
        ///  应用密钥。当应用的「换取 token 身份验证方式」配置为 `client_secret_post` 需要传。
        /// </summary>
        [JsonProperty("client_secret")]
        public string  Client_secret  {get;set;}
    }
}