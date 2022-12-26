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
    /// TreeAuthBo 的模型
    /// </summary>
    public partial class TreeAuthBo
    {
        /// <summary>
        ///  树资源节点路径
        /// </summary>
        [JsonProperty("nodePath")]
        public string  NodePath {get;set;}
        /// <summary>
        ///  树资源节点名称
        /// </summary>
        [JsonProperty("nodeName")]
        public string  NodeName {get;set;}
        /// <summary>
        ///  树资源节点操作权限列表
        /// </summary>
        [JsonProperty("nodeActions")]
        public List<string>  NodeActions {get;set;}
        /// <summary>
        ///  树资源节点 Value
        /// </summary>
        [JsonProperty("nodeValue")]
        public string  NodeValue {get;set;}
    }
}