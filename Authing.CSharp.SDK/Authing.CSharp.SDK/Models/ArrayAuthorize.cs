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
    /// ArrayAuthorize 的模型
    /// </summary>
    public partial class ArrayAuthorize
    {
        /// <summary>
        ///  数组资源 Value 列表
        /// </summary>
        [JsonProperty("values")]
        public List<string>  Values {get;set;}
        /// <summary>
        ///  数组资源操作列表
        /// </summary>
        [JsonProperty("actions")]
        public List<string>  Actions {get;set;}
    }
}