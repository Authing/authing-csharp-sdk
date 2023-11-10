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
    /// GetUsersOfPublicAccountDto 的模型
    /// </summary>
    public partial class GetUsersOfPublicAccountDto
    {
        /// <summary>
        ///  公共账号 ID
        /// </summary>
        [JsonProperty("publicAccountId")]
        public string  PublicAccountId {get;set;} 
    }
}