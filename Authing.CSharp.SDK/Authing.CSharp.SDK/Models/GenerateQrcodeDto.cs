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
/// GenerateQrcodeDto 的模型
/// </summary>
public partial class GenerateQrcodeDto
{
    /// <summary>
    ///  二维码类型。当前支持三种类型：
/// - `MOBILE_APP`: 自建移动端 APP 扫码
/// - `WECHAT_MINIPROGRAM`: 微信小程序扫码
/// - `WECHAT_OFFICIAL_ACCOUNT` 关注微信公众号扫码
    /// </summary>
    [JsonProperty("type")]
    public type  Type {get;set;}
    /// <summary>
    ///  当 `type` 为 `WECHAT_MINIPROGRAM` 或 `WECHAT_OFFICIAL_ACCOUNT` 时，可以指定身份源连接，否则默认使用应用开启的第一个对应身份源连接生成二维码。
    /// </summary>
    [JsonProperty("extIdpConnId")]
    public string  ExtIdpConnId {get;set;}
    /// <summary>
    ///  当 `type` 为 `MOBILE_APP` 时，可以传递用户的自定义数据，当用户成功扫码授权时，会将此数据存入用户的自定义数据。
    /// </summary>
    [JsonProperty("customData")]
    public object  CustomData {get;set;}
    /// <summary>
    ///  当 type 为 `WECHAT_OFFICIAL_ACCOUNT` 或 `WECHAT_MINIPROGRAM` 时，指定自定义的 pipeline 上下文，将会传递的 pipeline 的 context 中
    /// </summary>
    [JsonProperty("context")]
    public object  Context {get;set;}
    /// <summary>
    ///  当 type 为 `WECHAT_MINIPROGRAM` 时，是否将自定义的 logo 自动合并到生成的图片上，默认为 false。服务器合并二维码的过程会加大接口响应速度，推荐使用默认值，在客户端对图片进行拼接。如果你使用 Authing 的 SDK，可以省去手动拼接的过程。
    /// </summary>
    [JsonProperty("autoMergeQrCode")]
    public bool  AutoMergeQrCode {get;set;}
}
public partial class GenerateQrcodeDto
 {
    /// <summary>
    ///  二维码类型。当前支持三种类型：
/// - `MOBILE_APP`: 自建移动端 APP 扫码
/// - `WECHAT_MINIPROGRAM`: 微信小程序扫码
/// - `WECHAT_OFFICIAL_ACCOUNT` 关注微信公众号扫码
    /// </summary>
    public enum type
     {
         [EnumMember(Value="MOBILE_APP")]
        MOBILE_APP,
         [EnumMember(Value="WECHAT_MINIPROGRAM")]
        WECHAT_MINIPROGRAM,
         [EnumMember(Value="WECHAT_OFFICIAL_ACCOUNT")]
        WECHAT_OFFICIAL_ACCOUNT,
    }
}
}