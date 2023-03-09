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
    /// WebhookEventDto 的模型
    /// </summary>
    public partial class WebhookEventDto
    {
        /// <summary>
        ///  Webhook 名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name  {get;set;}
        /// <summary>
        ///  Webhook 英文名称
        /// </summary>
        [JsonProperty("nameEn")]
        public string  NameEn  {get;set;}
        /// <summary>
        ///  Webhook 事件
        /// </summary>
        [JsonProperty("value")]
        public string  Value  {get;set;}
        /// <summary>
        ///  Webhook 事件分类
        /// </summary>
        [JsonProperty("category")]
        public string  Category  {get;set;}
    }
}