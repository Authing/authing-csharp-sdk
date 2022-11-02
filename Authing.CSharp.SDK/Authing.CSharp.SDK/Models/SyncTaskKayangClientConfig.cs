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
    /// SyncTaskKayangClientConfig 的模型
    /// </summary>
    public partial class SyncTaskKayangClientConfig
    {
        /// <summary>
        ///  Endpoint
        /// </summary>
        [JsonProperty("endpoint")]
        public string  Endpoint {get;set;}
        /// <summary>
        ///  Account
        /// </summary>
        [JsonProperty("account")]
        public string  Account {get;set;}
        /// <summary>
        ///  Password
        /// </summary>
        [JsonProperty("password")]
        public string  Password {get;set;}
    }
}