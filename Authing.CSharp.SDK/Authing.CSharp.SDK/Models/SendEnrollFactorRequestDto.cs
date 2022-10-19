using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models;

   namespace Authing.CSharp.SDK.Models
{
/// <summary>
/// SendEnrollFactorRequestDto 的模型
/// </summary>
public partial class SendEnrollFactorRequestDto
{
    /// <summary>
    ///  MFA 认证要素详细信息
    /// </summary>
    [JsonProperty("profile")]
    public FactorProfile  Profile {get;set;}
    /// <summary>
    ///  MFA 认证要素类型，目前共支持短信、邮箱验证码、OTP、人脸四种类型的认证要素。
    /// </summary>
    [JsonProperty("factorType")]
    public factorType  FactorType {get;set;}
}
public partial class SendEnrollFactorRequestDto
 {
    /// <summary>
    ///  MFA 认证要素类型，目前共支持短信、邮箱验证码、OTP、人脸四种类型的认证要素。
    /// </summary>
    public enum factorType
     {
         [EnumMember(Value="OTP")]
        OTP,
         [EnumMember(Value="SMS")]
        SMS,
         [EnumMember(Value="EMAIL")]
        EMAIL,
         [EnumMember(Value="FACE")]
        FACE,
    }
}
}