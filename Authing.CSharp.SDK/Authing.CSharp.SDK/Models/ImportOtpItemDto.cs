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
/// ImportOtpItemDto 的模型
/// </summary>
public partial class ImportOtpItemDto
{
    /// <summary>
    ///  用户 ID
    /// </summary>
    [JsonProperty("userId")]
    public string  UserId {get;set;}
    /// <summary>
    ///  OTP 数据
    /// </summary>
    [JsonProperty("otp")]
    public ImportOtpItemDataDto  Otp {get;set;}
}
}