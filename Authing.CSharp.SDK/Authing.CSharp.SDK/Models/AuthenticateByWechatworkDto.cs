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
/// AuthenticateByWechatworkDto 的模型
/// </summary>
public partial class AuthenticateByWechatworkDto
{
    /// <summary>
    ///  企业微信移动端社会化登录返回的一次性临时 code
    /// </summary>
    [JsonProperty("code")]
    public string  Code {get;set;}
}
}