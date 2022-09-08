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
    /// RemoveGroupMembersReqDto 的模型
    /// </summary>
    public partial class RemoveGroupMembersReqDto
    {
        /// <summary>
        ///  用户 ID 数组
        /// </summary>
        [JsonProperty("userIds")]
        public    List<string>   UserIds    {get;set;}
        /// <summary>
        ///  分组 code
        /// </summary>
        [JsonProperty("code")]
        public    string   Code    {get;set;}
    }
}