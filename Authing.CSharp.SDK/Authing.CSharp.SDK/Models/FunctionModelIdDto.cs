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
    /// FunctionModelIdDto 的模型
    /// </summary>
    public partial class FunctionModelIdDto
    {
        /// <summary>
        ///  功能 id 可以从控制台页面获取
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
    }
}