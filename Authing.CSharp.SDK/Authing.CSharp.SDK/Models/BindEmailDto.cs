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
/// BindEmailDto 的模型
/// </summary>
public partial class BindEmailDto
{
    /// <summary>
    ///  邮箱验证码，一个邮箱验证码只能使用一次，且有一定有效时间。
    /// </summary>
    [JsonProperty("passCode")]
    public string  PassCode {get;set;}
    /// <summary>
    ///  邮箱，不区分大小写。
    /// </summary>
    [JsonProperty("email")]
    public string  Email {get;set;}
}
}