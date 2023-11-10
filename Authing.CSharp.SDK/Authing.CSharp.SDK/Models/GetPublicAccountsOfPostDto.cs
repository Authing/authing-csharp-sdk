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
    /// GetPublicAccountsOfPostDto 的模型
    /// </summary>
    public partial class GetPublicAccountsOfPostDto
    {
        /// <summary>
        ///  岗位 ID
        /// </summary>
        [JsonProperty("postId")]
        public string  PostId {get;set;} 
    }
}