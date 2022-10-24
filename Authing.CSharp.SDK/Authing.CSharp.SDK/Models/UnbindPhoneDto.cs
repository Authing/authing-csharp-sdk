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
/// UnbindPhoneDto 的模型
/// </summary>
public partial class UnbindPhoneDto
{
    /// <summary>
    ///  短信验证码，需要先调用**发送短信**接口接收验证码。
    /// </summary>
    [JsonProperty("passCode")]
    public string  PassCode {get;set;}
}
}