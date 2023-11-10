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
    /// CreatePublicAccountFromUserDto 的模型
    /// </summary>
    public partial class CreatePublicAccountFromUserDto
    {
        /// <summary>
        ///  公共账号 rowId
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
    }
}