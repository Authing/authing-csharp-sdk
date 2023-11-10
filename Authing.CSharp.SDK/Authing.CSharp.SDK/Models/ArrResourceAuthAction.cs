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
    /// ArrResourceAuthAction 的模型
    /// </summary>
    public partial class ArrResourceAuthAction
    {
        /// <summary>
        ///  数组数据资源的 values
        /// </summary>
        [JsonProperty("values")]
        public List<string>  Values {get;set;}
        /// <summary>
        ///  数组数据资源的 actions
        /// </summary>
        [JsonProperty("actions")]
        public List<string>  Actions {get;set;}
    }
}