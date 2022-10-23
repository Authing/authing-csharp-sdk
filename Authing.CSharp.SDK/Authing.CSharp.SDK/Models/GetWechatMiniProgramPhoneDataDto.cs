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
/// GetWechatMiniProgramPhoneDataDto 的模型
/// </summary>
public partial class GetWechatMiniProgramPhoneDataDto
{
    /// <summary>
    ///  包含区号的手机号
    /// </summary>
    [JsonProperty("phoneNumber")]
    public string  PhoneNumber {get;set;}
    /// <summary>
    ///  不包含区号的手机号
    /// </summary>
    [JsonProperty("purePhoneNumber")]
    public string  PurePhoneNumber {get;set;}
    /// <summary>
    ///  区号
    /// </summary>
    [JsonProperty("countryCode")]
    public string  CountryCode {get;set;}
}
}