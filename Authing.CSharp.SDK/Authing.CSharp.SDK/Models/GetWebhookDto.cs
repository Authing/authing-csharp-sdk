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
    /// GetWebhookDto 的模型
    /// </summary>
    public partial class GetWebhookDto
    {
        /// <summary>
        ///  Webhook ID
        /// </summary>
        [JsonProperty("webhookId")]
        public string  WebhookId {get;set;} 
    }
}