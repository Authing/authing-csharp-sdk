using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

namespace Authing.CSharp.SDK.Models.Management
{
    /// <summary>
    /// SyncTaskFxiaokeClientConfig 的模型
    /// </summary>
    public partial class SyncTaskFxiaokeClientConfig
    {
        /// <summary>
        ///  App Id
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }
        /// <summary>
        ///  App Secret
        /// </summary>
        [JsonProperty("appSecret")]
        public string AppSecret { get; set; }
        /// <summary>
        ///  Permanent Code
        /// </summary>
        [JsonProperty("permanentCode")]
        public string PermanentCode { get; set; }
        /// <summary>
        ///  Current Open User Id
        /// </summary>
        [JsonProperty("currentOpenUserId")]
        public string CurrentOpenUserId { get; set; }
    }
}