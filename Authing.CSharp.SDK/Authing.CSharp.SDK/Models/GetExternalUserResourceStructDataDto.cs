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
    /// GetExternalUserResourceStructDataDto 的模型
    /// </summary>
    public partial class GetExternalUserResourceStructDataDto
    {
        /// <summary>
        ///  权限空间 Code
        /// </summary>
        [JsonProperty("namespaceCode")]
        public string  NamespaceCode  {get;set;}
        /// <summary>
        ///  数据资源 Code
        /// </summary>
        [JsonProperty("resourceCode")]
        public string  ResourceCode  {get;set;}
        /// <summary>
        ///  数据资源类型，目前支持树结构（TREE）、字符串（STRING）、数组（ARRAY）三种类型，根据不同的类型返回不同的结构。
/// - `STRING`: 字符串类型结果 StrResourceAuthAction
/// - `ARRAY`: 数组类型 ArrResourceAuthAction
/// - `TREE`: 树类型 TreeResourceAuthAction
        /// </summary>
        [JsonProperty("resourceType")]
        public resourceType  ResourceType  {get;set;}
        /// <summary>
        ///  字符串资源授权
        /// </summary>
        [JsonProperty("strResourceAuthAction")]
        public StrResourceAuthAction  StrResourceAuthAction  {get;set;}
        /// <summary>
        ///  数组资源授权
        /// </summary>
        [JsonProperty("arrResourceAuthAction")]
        public ArrResourceAuthAction  ArrResourceAuthAction  {get;set;}
        /// <summary>
        ///  树资源授权
        /// </summary>
        [JsonProperty("treeResourceAuthAction")]
        public TreeResourceAuthAction  TreeResourceAuthAction  {get;set;}
    }
    public partial class GetExternalUserResourceStructDataDto
    {
        /// <summary>
        ///  数据资源类型，目前支持树结构（TREE）、字符串（STRING）、数组（ARRAY）三种类型，根据不同的类型返回不同的结构。
/// - `STRING`: 字符串类型结果 StrResourceAuthAction
/// - `ARRAY`: 数组类型 ArrResourceAuthAction
/// - `TREE`: 树类型 TreeResourceAuthAction
        /// </summary>
        public enum resourceType
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