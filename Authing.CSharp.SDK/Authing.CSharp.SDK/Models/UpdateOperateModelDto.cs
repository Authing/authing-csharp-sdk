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
    /// UpdateOperateModelDto 的模型
    /// </summary>
    public partial class UpdateOperateModelDto
    {
        /// <summary>
        ///  图标
        /// </summary>
        [JsonProperty("icon")]
        public string  Icon {get;set;}
        /// <summary>
        ///  操作配置
        /// </summary>
        [JsonProperty("config")]
        public object  Config {get;set;}
        /// <summary>
        ///  操作名称
        /// </summary>
        [JsonProperty("operateName")]
        public string  OperateName {get;set;}
        /// <summary>
        ///  操作 Key 值
        /// </summary>
        [JsonProperty("operateKey")]
        public string  OperateKey {get;set;}
        /// <summary>
        ///  是否展示:
/// - true: 展示
/// - true: 不展示
/// 
        /// </summary>
        [JsonProperty("show")]
        public bool  Show {get;set;}
        /// <summary>
        ///  modelId
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;}
        /// <summary>
        ///  id
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
    }
}