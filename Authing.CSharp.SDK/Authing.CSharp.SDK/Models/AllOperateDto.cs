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
    /// AllOperateDto 的模型
    /// </summary>
    public partial class AllOperateDto
    {
        /// <summary>
        ///  model Id
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;} 
    }
}