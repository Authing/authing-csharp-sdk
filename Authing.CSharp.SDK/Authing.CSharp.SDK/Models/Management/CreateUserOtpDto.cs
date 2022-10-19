using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

   namespace Authing.CSharp.SDK.Models.Management
{
/// <summary>
/// CreateUserOtpDto 的模型
/// </summary>
public partial class CreateUserOtpDto
{
    /// <summary>
    ///  OTP 密钥
    /// </summary>
    [JsonProperty("secret")]
    public string  Secret {get;set;}
    /// <summary>
    ///  OTP Recovery Code
    /// </summary>
    [JsonProperty("recoveryCode")]
    public string  RecoveryCode {get;set;}
}
}