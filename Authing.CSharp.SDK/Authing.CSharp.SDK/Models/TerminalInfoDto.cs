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
    /// TerminalInfoDto 的模型
    /// </summary>
    public partial class TerminalInfoDto
    {
        /// <summary>
        ///  主键 ID
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
        /// <summary>
        ///  设备唯一标识
        /// </summary>
        [JsonProperty("deviceUniqueId")]
        public string  DeviceUniqueId {get;set;}
    }
}