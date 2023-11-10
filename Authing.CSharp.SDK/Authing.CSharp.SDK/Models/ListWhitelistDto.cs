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
    /// ListWhitelistDto 的模型
    /// </summary>
    public partial class ListWhitelistDto
    {
        /// <summary>
        ///  白名单类型
        /// </summary>
        [JsonProperty("type")]
        public string  Type {get;set;} 
    }
}