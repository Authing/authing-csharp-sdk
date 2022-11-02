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
    /// SyncTaskWechatworkClientConfig 的模型
    /// </summary>
    public partial class SyncTaskWechatworkClientConfig
    {
        /// <summary>
        ///  企业 ID（CorpId）
        /// </summary>
        [JsonProperty("corpID")]
        public string  CorpID {get;set;}
        /// <summary>
        ///  企业微信通讯录密钥 Secret
        /// </summary>
        [JsonProperty("secret")]
        public string  Secret {get;set;}
        /// <summary>
        ///  通讯录事件同步 Token
        /// </summary>
        [JsonProperty("token")]
        public string  Token {get;set;}
        /// <summary>
        ///  通讯录事件同步 EncodingAESKey
        /// </summary>
        [JsonProperty("encodingAESKey")]
        public string  EncodingAESKey {get;set;}
        /// <summary>
        ///  代理地址
        /// </summary>
        [JsonProperty("agentUrl")]
        public string  AgentUrl {get;set;}
    }
}