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
    /// UserConnectionPostDto 的模型
    /// </summary>
    public partial class UserConnectionPostDto
    {
        /// <summary>
        ///  用户 id
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
        /// <summary>
        ///  部门 id
        /// </summary>
        [JsonProperty("postId")]
        public string  PostId {get;set;}
    }
}