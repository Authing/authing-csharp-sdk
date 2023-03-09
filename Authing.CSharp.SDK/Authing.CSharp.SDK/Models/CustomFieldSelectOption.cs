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
    /// CustomFieldSelectOption 的模型
    /// </summary>
    public partial class CustomFieldSelectOption
    {
        /// <summary>
        ///  枚举值 value
        /// </summary>
        [JsonProperty("value")]
        public string  Value  {get;set;}
        /// <summary>
        ///  枚举值 label
        /// </summary>
        [JsonProperty("label")]
        public string  Label  {get;set;}
    }
}