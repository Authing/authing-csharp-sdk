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
    /// QueryTerminalAppsDto 的模型
    /// </summary>
    public partial class QueryTerminalAppsDto
    {
        /// <summary>
        ///  设备唯一标识列表
        /// </summary>
        [JsonProperty("deviceIds")]
        public List<string>  DeviceIds {get;set;}
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
    }
}