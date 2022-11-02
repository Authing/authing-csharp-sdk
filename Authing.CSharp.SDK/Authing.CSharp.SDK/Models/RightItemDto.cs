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
    /// RightItemDto 的模型
    /// </summary>
    public partial class RightItemDto
    {
        /// <summary>
        ///  权益编码
        /// </summary>
        [JsonProperty("rightsModelCode")]
        public string  RightsModelCode {get;set;}
        /// <summary>
        ///  权益名称
        /// </summary>
        [JsonProperty("rightsModelName")]
        public string  RightsModelName {get;set;}
        /// <summary>
        ///  权益数据类型
        /// </summary>
        [JsonProperty("dataType")]
        public string  DataType {get;set;}
        /// <summary>
        ///  权益值
        /// </summary>
        [JsonProperty("dataValue")]
        public string  DataValue {get;set;}
    }
}