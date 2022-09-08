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
    /// CustomFieldI18n 的模型
    /// </summary>
    public partial class CustomFieldI18n
    {
        /// <summary>
        ///  支持多语言的字段
        /// </summary>
        [JsonProperty("label")]
        public    LangObject   Label    {get;set;}
    }
}