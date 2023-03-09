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
    /// CurrentUsageDto 的模型
    /// </summary>
    public partial class CurrentUsageDto
    {
        /// <summary>
        ///  权益总量
        /// </summary>
        [JsonProperty("amount")]
        public string  Amount  {get;set;}
        /// <summary>
        ///  权益当前使用量
        /// </summary>
        [JsonProperty("current")]
        public string  Current  {get;set;}
        /// <summary>
        ///  是否是体验期权益
        /// </summary>
        [JsonProperty("experience")]
        public bool  Experience  {get;set;}
        /// <summary>
        ///  权益编码
        /// </summary>
        [JsonProperty("modelCode")]
        public string  ModelCode  {get;set;}
        /// <summary>
        ///  权益名称
        /// </summary>
        [JsonProperty("modelName")]
        public string  ModelName  {get;set;}
    }
}