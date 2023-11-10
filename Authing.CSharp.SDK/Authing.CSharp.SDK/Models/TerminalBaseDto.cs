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
    /// TerminalBaseDto 的模型
    /// </summary>
    public partial class TerminalBaseDto
    {
        /// <summary>
        ///  数据行 id，创建设备时返回的 `id`
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
    }
}