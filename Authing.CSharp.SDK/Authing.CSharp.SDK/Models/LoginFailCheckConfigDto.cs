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
/// LoginFailCheckConfigDto 的模型
/// </summary>
public partial class LoginFailCheckConfigDto
{
    /// <summary>
    ///  是否开启登录失败次数限制。
    /// </summary>
    [JsonProperty("enabled")]
    public bool  Enabled {get;set;}
    /// <summary>
    ///  在一定时间周期内，对于同一个 IP，最多登录失败多少次后会触发安全策略。
    /// </summary>
    [JsonProperty("limit")]
    public long  Limit {get;set;}
    /// <summary>
    ///  限定周期时间长度，单位为秒。
    /// </summary>
    [JsonProperty("timeInterval")]
    public long  TimeInterval {get;set;}
}
}