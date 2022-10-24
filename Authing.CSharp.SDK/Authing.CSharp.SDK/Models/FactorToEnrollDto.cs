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
/// FactorToEnrollDto 的模型
/// </summary>
public partial class FactorToEnrollDto
{
    /// <summary>
    ///  MFA Factor 类型
    /// </summary>
    [JsonProperty("factorType")]
    public factorType  FactorType {get;set;}
}
public partial class FactorToEnrollDto
 {
    /// <summary>
    ///  MFA Factor 类型
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