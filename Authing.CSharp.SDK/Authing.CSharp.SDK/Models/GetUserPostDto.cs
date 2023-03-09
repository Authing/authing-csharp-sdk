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
    /// GetUserPostDto 的模型
    /// </summary>
    public partial class GetUserPostDto
    {
        /// <summary>
        ///  用户 id
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;} 
    }
}