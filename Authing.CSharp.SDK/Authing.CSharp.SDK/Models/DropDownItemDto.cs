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
    /// DropDownItemDto 的模型
    /// </summary>
    public partial class DropDownItemDto
    {
        /// <summary>
        ///  选项 id
        /// </summary>
        [JsonProperty("key")]
        public string  Key {get;set;}
        /// <summary>
        ///  选项名称
        /// </summary>
        [JsonProperty("label")]
        public string  Label {get;set;}
    }
}