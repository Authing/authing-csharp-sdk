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
    /// LoginPassowrdFailCheckConfigDto 的模型
    /// </summary>
    public partial class LoginPassowrdFailCheckConfigDto
    {
        /// <summary>
        ///  是否开启登录密码错误限制
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled {get;set;}
        /// <summary>
        ///  密码错误次数最大限制
        /// </summary>
        [JsonProperty("limit")]
        public long  Limit {get;set;}
        /// <summary>
        ///  限定周期时间长度，单位为秒。
        /// </summary>
        [JsonProperty("timeInterval")]
        public long  TimeInterval {get;set;}
        /// <summary>
        ///  时间长度单位。Second/Minute/Hour/Day，仅仅做显示，timeInterval的单位还是秒
        /// </summary>
        [JsonProperty("unit")]
        public string  Unit {get;set;}
    }
}