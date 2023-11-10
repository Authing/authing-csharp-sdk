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
    /// BatchApplicationsAuthDto 的模型
    /// </summary>
    public partial class BatchApplicationsAuthDto
    {
        /// <summary>
        ///  授权 ID
        /// </summary>
        [JsonProperty("authIds")]
        public string  AuthIds {get;set;} 
    }
}