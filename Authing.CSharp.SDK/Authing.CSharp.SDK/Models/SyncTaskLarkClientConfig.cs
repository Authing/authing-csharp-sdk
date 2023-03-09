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
    /// SyncTaskLarkClientConfig 的模型
    /// </summary>
    public partial class SyncTaskLarkClientConfig
    {
        /// <summary>
        ///  飞书应用 App ID
        /// </summary>
        [JsonProperty("app_id")]
        public string  App_id  {get;set;}
        /// <summary>
        ///  飞书应用 App Secret
        /// </summary>
        [JsonProperty("app_secret")]
        public string  App_secret  {get;set;}
        /// <summary>
        ///  飞书事件订阅的 Encrypt Key，可以在飞书开放平台应用详情的「事件订阅」页面获取。如果你需要开启实时同步，此参数必填。
        /// </summary>
        [JsonProperty("encrypt_key")]
        public string  Encrypt_key  {get;set;}
        /// <summary>
        ///  飞书事件订阅的 Verification Token，可以在飞书开放平台应用详情的「事件订阅」页面获取。如果你需要开启实时同步，此参数必填。
        /// </summary>
        [JsonProperty("verification_token")]
        public string  Verification_token  {get;set;}
    }
}