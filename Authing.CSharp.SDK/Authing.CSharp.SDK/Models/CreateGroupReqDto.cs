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
    /// CreateGroupReqDto 的模型
    /// </summary>
    public partial class CreateGroupReqDto
    {
        /// <summary>
        ///  分组类型
        /// </summary>
        [JsonProperty("type")]
        public string  Type {get;set;}
        /// <summary>
        ///  分组描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  分组名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  分组 code
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  自定义数据，传入的对象中的 key 必须先在用户池定义相关自定义字段
        /// </summary>
        [JsonProperty("customData")]
        public object  CustomData {get;set;}
    }
}