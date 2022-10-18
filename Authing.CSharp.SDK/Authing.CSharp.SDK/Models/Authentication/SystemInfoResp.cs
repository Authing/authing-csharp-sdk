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
    /// SystemInfoResp 的模型
    /// </summary>
    public partial class SystemInfoResp
    {
        /// <summary>
        ///  RSA256 加密配置信息
        /// </summary>
        [JsonProperty("rsa")]
        public SystmeInfoRSAConfig Rsa { get; set; }
        /// <summary>
        ///  国密 SM2 加密配置信息
        /// </summary>
        [JsonProperty("sm2")]
        public SystmeInfoSM2Config Sm2 { get; set; }
        /// <summary>
        ///  国密 SM2 加密配置信息
        /// </summary>
        [JsonProperty("version")]
        public SystmeInfoVersion Version { get; set; }
        /// <summary>
        ///  Authing 服务对外 IP 列表
        /// </summary>
        [JsonProperty("publicIps")]
        public List<string> PublicIps { get; set; }
    }
}