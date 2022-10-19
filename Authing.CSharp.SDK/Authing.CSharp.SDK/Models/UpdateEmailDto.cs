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
/// UpdateEmailDto 的模型
/// </summary>
public partial class UpdateEmailDto
{
    /// <summary>
    ///  用于临时修改邮箱的 token，可从**发起修改邮箱的验证请求**接口获取。
    /// </summary>
    [JsonProperty("updateEmailToken")]
    public string  UpdateEmailToken {get;set;}
}
}