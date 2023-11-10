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
    /// ResGroupDto 的模型
    /// </summary>
    public partial class ResGroupDto
    {
        /// <summary>
        ///  分组 ID
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
        /// <summary>
        ///  分组 code
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  分组名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  分组描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  分组类型
        /// </summary>
        [JsonProperty("type")]
        public string  Type {get;set;}
        /// <summary>
        ///  分组元数据信息
        /// </summary>
        [JsonProperty("metadataSource")]
        public List<string>  MetadataSource {get;set;}
        /// <summary>
        ///  成员列表
        /// </summary>
        [JsonProperty("members")]
        public List<UserDto>  Members {get;set;}
    }
}