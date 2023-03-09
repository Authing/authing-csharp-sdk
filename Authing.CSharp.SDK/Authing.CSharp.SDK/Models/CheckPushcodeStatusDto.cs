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
    /// CheckPushcodeStatusDto 的模型
    /// </summary>
    public partial class CheckPushcodeStatusDto
    {
        /// <summary>
        ///  推送码（推送登录唯一 ID）
        /// </summary>
        [JsonProperty("pushCodeId")]
        public string  PushCodeId {get;set;} 
    }
}