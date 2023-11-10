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
    /// UpdateDataResourceDto 的模型
    /// </summary>
    public partial class UpdateDataResourceDto
    {
        /// <summary>
        ///  数据资源 Code, 权限空间内唯一
        /// </summary>
        [JsonProperty("resourceCode")]
        public string  ResourceCode {get;set;}
        /// <summary>
        ///  数据资源所属的权限空间 Code
        /// </summary>
        [JsonProperty("namespaceCode")]
        public string  NamespaceCode {get;set;}
        /// <summary>
        ///  数据资源名称, 权限空间内唯一
        /// </summary>
        [JsonProperty("resourceName")]
        public string  ResourceName {get;set;}
        /// <summary>
        ///  数据资源描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  数据资源结构，支持字符串（STRING）、树结构（TREE）和数组结构（ARRAY）。
        /// </summary>
        [JsonProperty("struct")]
        public object  Struct {get;set;}
        /// <summary>
        ///  数据资源权限操作列表
        /// </summary>
        [JsonProperty("actions")]
        public List<string>  Actions {get;set;}
    }
}