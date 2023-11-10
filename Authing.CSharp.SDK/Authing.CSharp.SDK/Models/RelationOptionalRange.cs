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
    /// RelationOptionalRange 的模型
    /// </summary>
    public partial class RelationOptionalRange
    {
        /// <summary>
        ///  多个搜索条件的关系：
/// - and: 且
/// - or:  或
/// 
        /// </summary>
        [JsonProperty("conjunction")]
        public string  Conjunction {get;set;}
        /// <summary>
        ///  搜索条件
        /// </summary>
        [JsonProperty("conditions")]
        public Condition  Conditions {get;set;}
    }
}