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
    /// CaptchaCodeDto 的模型
    /// </summary>
    public partial class CaptchaCodeDto
    {
        /// <summary>
        ///  随机字符串或者时间戳，防止浏览器缓存
        /// </summary>
        [JsonProperty("r")]
        public object R { get; set; }
    }
}