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
    /// VerifyConfigAppDto 的模型
    /// </summary>
    public partial class VerifyConfigAppDto
    {
        /// <summary>
        ///  搜索关键字
        /// </summary>
        [JsonProperty("keywords")]
        public string  Keywords {get;set;} 
    }
}