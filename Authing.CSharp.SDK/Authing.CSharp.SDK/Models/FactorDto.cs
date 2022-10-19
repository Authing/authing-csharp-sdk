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
/// FactorDto 的模型
/// </summary>
public partial class FactorDto
{
    /// <summary>
    ///  MFA 认证要素ID
    /// </summary>
    [JsonProperty("factorId")]
    public string  FactorId {get;set;}
    /// <summary>
    ///  MFA 认证要素类型
    /// </summary>
    [JsonProperty("factorType")]
    public factorType  FactorType {get;set;}
    /// <summary>
    ///  MFA 认证要素信息
    /// </summary>
    [JsonProperty("profile")]
    public object  Profile {get;set;}
}
public partial class FactorDto
 {
    /// <summary>
    ///  MFA 认证要素类型
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