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
    /// DataResourceTreeStructs 的模型
    /// </summary>
    public partial class DataResourceTreeStructs
    {
        /// <summary>
        ///  数据资源节点 Code, 同层级唯一
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  数据资源节点名称 ，同层级唯一
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  数据资源节点 Value
        /// </summary>
        [JsonProperty("value")]
        public string  Value {get;set;}
        /// <summary>
        ///  数据资源节点的子节点,子节点层级最多支持五个层级
        /// </summary>
        [JsonProperty("children")]
        public List<object>  Children {get;set;}
    }
}