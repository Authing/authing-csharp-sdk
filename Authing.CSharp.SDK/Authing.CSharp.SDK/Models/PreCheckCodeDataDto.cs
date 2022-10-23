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
/// PreCheckCodeDataDto 的模型
/// </summary>
public partial class PreCheckCodeDataDto
{
    /// <summary>
    ///  验证码是否正确且有效
    /// </summary>
    [JsonProperty("isValid")]
    public bool  IsValid {get;set;}
    /// <summary>
    ///  如果验证码不正确或者已失效，具体的错误信息
    /// </summary>
    [JsonProperty("message")]
    public string  Message {get;set;}
}
}