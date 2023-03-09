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
    /// SyncTaskDingtalkClientConfig 的模型
    /// </summary>
    public partial class SyncTaskDingtalkClientConfig
    {
        /// <summary>
        ///  企业 ID（CorpId）
        /// </summary>
        [JsonProperty("corpId")]
        public string  CorpId  {get;set;}
        /// <summary>
        ///  钉钉应用的 AppKey
        /// </summary>
        [JsonProperty("appKey")]
        public string  AppKey  {get;set;}
        /// <summary>
        ///  钉钉应用的 AppSecret
        /// </summary>
        [JsonProperty("appSecret")]
        public string  AppSecret  {get;set;}
        /// <summary>
        ///  加密 aes_key
        /// </summary>
        [JsonProperty("aes_key")]
        public string  Aes_key  {get;set;}
        /// <summary>
        ///  签名 token
        /// </summary>
        [JsonProperty("token")]
        public string  Token  {get;set;}
    }
}