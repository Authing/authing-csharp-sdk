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
/// PreCheckCodeDto 的模型
/// </summary>
public partial class PreCheckCodeDto
{
    /// <summary>
    ///  验证码类型
    /// </summary>
    [JsonProperty("codeType")]
    public codeType  CodeType {get;set;}
    /// <summary>
    ///  短信验证码检验参数
    /// </summary>
    [JsonProperty("smsCodePayload")]
    public PreCheckSmsCodeDto  SmsCodePayload {get;set;}
    /// <summary>
    ///  邮箱验证码检验参数
    /// </summary>
    [JsonProperty("emailCodePayload")]
    public PreCheckEmailCodeDto  EmailCodePayload {get;set;}
}
public partial class PreCheckCodeDto
 {
    /// <summary>
    ///  验证码类型
    /// </summary>
    public enum codeType
     {
         [EnumMember(Value="SMS")]
        SMS,
         [EnumMember(Value="EMAIL")]
        EMAIL,
    }
}
}