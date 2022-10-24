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
/// SendEnrollFactorRequestOtpDataDto 的模型
/// </summary>
public partial class SendEnrollFactorRequestOtpDataDto
{
    /// <summary>
    ///  OTP Auth Uri
    /// </summary>
    [JsonProperty("qrCodeUri")]
    public string  QrCodeUri {get;set;}
    /// <summary>
    ///  Base64 编码的 OTP 二维码，前端可以用此渲染二维码。
    /// </summary>
    [JsonProperty("qrCodeDataUrl")]
    public string  QrCodeDataUrl {get;set;}
    /// <summary>
    ///  OTP Recovery Code
    /// </summary>
    [JsonProperty("recoveryCode")]
    public string  RecoveryCode {get;set;}
}
}