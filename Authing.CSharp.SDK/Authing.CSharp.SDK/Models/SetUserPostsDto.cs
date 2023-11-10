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
    /// SetUserPostsDto 的模型
    /// </summary>
    public partial class SetUserPostsDto
    {
        /// <summary>
        ///  岗位 id 列表
        /// </summary>
        [JsonProperty("postIds")]
        public List<string>  PostIds {get;set;}
        /// <summary>
        ///  用户 id
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
    }
}