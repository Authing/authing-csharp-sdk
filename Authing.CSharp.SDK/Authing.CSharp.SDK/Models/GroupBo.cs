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
    /// GroupBo 的模型
    /// </summary>
    public partial class GroupBo
    {
        /// <summary>
        ///  用户组 id
        /// </summary>
        [JsonProperty("groupId")]
        public string  GroupId {get;set;}
        /// <summary>
        ///  用户组名称
        /// </summary>
        [JsonProperty("groupName")]
        public string  GroupName {get;set;}
        /// <summary>
        ///  用户组 Code
        /// </summary>
        [JsonProperty("groupCode")]
        public string  GroupCode {get;set;}
    }
}