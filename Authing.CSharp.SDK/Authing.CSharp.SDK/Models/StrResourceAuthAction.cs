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
    /// StrResourceAuthAction 的模型
    /// </summary>
    public partial class StrResourceAuthAction
    {
        /// <summary>
        ///  字符串数据资源的 Value
        /// </summary>
        [JsonProperty("value")]
        public string  Value {get;set;}
        /// <summary>
        ///  字符串数据资源的 actions
        /// </summary>
        [JsonProperty("actions")]
        public List<string>  Actions {get;set;}
    }
}