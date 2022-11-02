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
    /// ResourceAction 的模型
    /// </summary>
    public partial class ResourceAction
    {
        /// <summary>
        ///  资源操作名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  资源操作描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
    }
}