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
    /// CreateArrayDataResourceRespDto 的模型
    /// </summary>
    public partial class CreateArrayDataResourceRespDto
    {
        /// <summary>
        ///  数据资源名称,权限空间内唯一
        /// </summary>
        [JsonProperty("resourceName")]
        public string  ResourceName {get;set;}
        /// <summary>
        ///  数据资源 Code,权限空间内唯一
        /// </summary>
        [JsonProperty("resourceCode")]
        public string  ResourceCode {get;set;}
        /// <summary>
        ///  数据资源类型，目前支持树结构（TREE）、字符串（STRING）、数组（ARRAY）
        /// </summary>
        [JsonProperty("type")]
        public type  Type {get;set;}
        /// <summary>
        ///  数据资源描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  数组数据资源节点
        /// </summary>
        [JsonProperty("struct")]
        public List<string>  Struct {get;set;}
        /// <summary>
        ///  数据资源权限操作列表
        /// </summary>
        [JsonProperty("actions")]
        public List<string>  Actions {get;set;}
    }
    public partial class CreateArrayDataResourceRespDto
    {
        /// <summary>
        ///  数据资源类型，目前支持树结构（TREE）、字符串（STRING）、数组（ARRAY）
        /// </summary>
        public enum type
        {
            [EnumMember(Value="TREE")]
            TREE,
            [EnumMember(Value="STRING")]
            STRING,
            [EnumMember(Value="ARRAY")]
            ARRAY,
        }
    }
}