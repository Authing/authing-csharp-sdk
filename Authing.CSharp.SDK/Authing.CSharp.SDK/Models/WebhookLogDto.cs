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
    /// WebhookLogDto 的模型
    /// </summary>
    public partial class WebhookLogDto
    {
        /// <summary>
        ///  Webhook ID
        /// </summary>
        [JsonProperty("webhookId")]
        public string  WebhookId  {get;set;}
        /// <summary>
        ///  Webhook 事件名称
        /// </summary>
        [JsonProperty("eventName")]
        public string  EventName  {get;set;}
        /// <summary>
        ///  Webhook 请求体
        /// </summary>
        [JsonProperty("requestBody")]
        public object  RequestBody  {get;set;}
        /// <summary>
        ///  Webhook 请求头
        /// </summary>
        [JsonProperty("requestHeaders")]
        public object  RequestHeaders  {get;set;}
        /// <summary>
        ///  Webhook 响应码
        /// </summary>
        [JsonProperty("responseStatusCode")]
        public long  ResponseStatusCode  {get;set;}
        /// <summary>
        ///  Webhook 响应头
        /// </summary>
        [JsonProperty("responseHeaders")]
        public object  ResponseHeaders  {get;set;}
        /// <summary>
        ///  Webhook 响应体
        /// </summary>
        [JsonProperty("responseBody")]
        public object  ResponseBody  {get;set;}
        /// <summary>
        ///  时间戳
        /// </summary>
        [JsonProperty("timestamp")]
        public string  Timestamp  {get;set;}
        /// <summary>
        ///  是否请求成功
        /// </summary>
        [JsonProperty("success")]
        public bool  Success  {get;set;}
        /// <summary>
        ///  请求失败时返回的错误信息
        /// </summary>
        [JsonProperty("errorMessage")]
        public string  ErrorMessage  {get;set;}
    }
}