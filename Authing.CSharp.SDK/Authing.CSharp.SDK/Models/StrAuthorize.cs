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
    /// StrAuthorize 的模型
    /// </summary>
    public partial class StrAuthorize
    {
        /// <summary>
        ///  字符串资源 Value
        /// </summary>
        [JsonProperty("value")]
        public string  Value {get;set;}
        /// <summary>
        ///  字符串资源操作列表
        /// </summary>
        [JsonProperty("actions")]
        public List<string>  Actions {get;set;}
    }
}