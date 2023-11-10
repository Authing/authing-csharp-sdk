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
    /// GetPublicAccountsOfGroupDto 的模型
    /// </summary>
    public partial class GetPublicAccountsOfGroupDto
    {
        /// <summary>
        ///  分组 ID
        /// </summary>
        [JsonProperty("groupId")]
        public string  GroupId {get;set;} 
    }
}