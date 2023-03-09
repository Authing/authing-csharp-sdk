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
    /// SyncTaskXiaoshouyiClientConfig 的模型
    /// </summary>
    public partial class SyncTaskXiaoshouyiClientConfig
    {
        /// <summary>
        ///  销售易应用的 ClientId
        /// </summary>
        [JsonProperty("client_id")]
        public string  Client_id  {get;set;}
        /// <summary>
        ///  销售易应用的 ClientSecret
        /// </summary>
        [JsonProperty("client_secret")]
        public string  Client_secret  {get;set;}
        /// <summary>
        ///  销售易应用的 UserName
        /// </summary>
        [JsonProperty("username")]
        public string  Username  {get;set;}
        /// <summary>
        ///  销售易应用的 Password
        /// </summary>
        [JsonProperty("password")]
        public string  Password  {get;set;}
    }
}