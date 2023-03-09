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
    /// OpenResource 的模型
    /// </summary>
    public partial class OpenResource
    {
        /// <summary>
        ///  数据策略下所授权的数据资源 Code
        /// </summary>
        [JsonProperty("resourceCode")]
        public string  ResourceCode  {get;set;}
        /// <summary>
        ///  数据策略下所授权的数据资源类型，目前支持树结构（TREE）、字符串（STRING）、数组（ARRAY）三种类型，根据不同的类型返回不同的结构。
/// - `STRING`: 字符串类型结果 StrAuthorize
/// - `ARRAY`: 数组类型 ArrayAuthorize
/// - `TREE`: 树类型 TreeAuthorize
        /// </summary>
        [JsonProperty("resourceType")]
        public resourceType  ResourceType  {get;set;}
        /// <summary>
        ///  数据策略的字符串资源
        /// </summary>
        [JsonProperty("strAuthorize")]
        public StrAuthorize  StrAuthorize  {get;set;}
        /// <summary>
        ///  数据策略的数组资源
        /// </summary>
        [JsonProperty("arrAuthorize")]
        public ArrayAuthorize  ArrAuthorize  {get;set;}
        /// <summary>
        ///  数据策略的树资源
        /// </summary>
        [JsonProperty("treeAuthorize")]
        public TreeAuthorize  TreeAuthorize  {get;set;}
    }
    public partial class OpenResource
    {
        /// <summary>
        ///  数据策略下所授权的数据资源类型，目前支持树结构（TREE）、字符串（STRING）、数组（ARRAY）三种类型，根据不同的类型返回不同的结构。
/// - `STRING`: 字符串类型结果 StrAuthorize
/// - `ARRAY`: 数组类型 ArrayAuthorize
/// - `TREE`: 树类型 TreeAuthorize
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