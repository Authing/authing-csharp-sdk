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
    /// LanguageCoinfigDto 的模型
    /// </summary>
    public partial class LanguageCoinfigDto
    {
        [JsonProperty("global")]
        public LanguageCoinfigGlobalDto  Global {get;set;}
    }
}