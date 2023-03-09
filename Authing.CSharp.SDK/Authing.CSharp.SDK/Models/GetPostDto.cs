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
    /// GetPostDto 的模型
    /// </summary>
    public partial class GetPostDto
    {
        /// <summary>
        ///  岗位 code
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;} 
    }
}