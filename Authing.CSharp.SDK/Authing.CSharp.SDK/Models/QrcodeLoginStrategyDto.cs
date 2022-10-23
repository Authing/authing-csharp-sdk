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
/// QrcodeLoginStrategyDto 的模型
/// </summary>
public partial class QrcodeLoginStrategyDto
{
    /// <summary>
    ///  二维码有效时间（秒）
    /// </summary>
    [JsonProperty("qrcodeExpiresIn")]
    public long  QrcodeExpiresIn {get;set;}
    /// <summary>
    ///  ticket 有效时间（秒）
    /// </summary>
    [JsonProperty("ticketExpiresIn")]
    public long  TicketExpiresIn {get;set;}
    /// <summary>
    ///  Web 轮询接口返回完整用户信息，详情见此文档：Web 轮询接口返回完整用户信息
    /// </summary>
    [JsonProperty("allowExchangeUserInfoFromBrowser")]
    public bool  AllowExchangeUserInfoFromBrowser {get;set;}
    /// <summary>
    ///  允许在浏览器使用 ticket 换取用户信息，详情见此文档：Web 轮询接口返回完整用户信息
    /// </summary>
    [JsonProperty("returnFullUserInfo")]
    public bool  ReturnFullUserInfo {get;set;}
}
}