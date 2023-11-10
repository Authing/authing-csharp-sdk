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
    /// CreateOperateModelDto 的模型
    /// </summary>
    public partial class CreateOperateModelDto
    {
        /// <summary>
        ///  是否展示:
/// - true: 展示
/// - true: 不展示
/// 
        /// </summary>
        [JsonProperty("show")]
        public bool  Show {get;set;}
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
        ///  操作类型:
/// - openPage: 打开一个网页
/// 
        /// </summary>
        [JsonProperty("operateKey")]
        public string  OperateKey {get;set;}
        /// <summary>
        ///  modelId
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;}
    }
}