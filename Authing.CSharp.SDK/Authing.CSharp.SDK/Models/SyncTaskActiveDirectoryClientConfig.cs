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
    /// SyncTaskActiveDirectoryClientConfig 的模型
    /// </summary>
    public partial class SyncTaskActiveDirectoryClientConfig
    {
        /// <summary>
        ///  身份源唯一标志
        /// </summary>
        [JsonProperty("syncIdentityProviderCode")]
        public string  SyncIdentityProviderCode  {get;set;}
        /// <summary>
        ///  Provisioning Ticket Url
        /// </summary>
        [JsonProperty("ticket_url")]
        public string  Ticket_url  {get;set;}
    }
}