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
    /// AuthorizeApplicationAccessDto 的模型
    /// </summary>
    public partial class AuthorizeApplicationAccessDto
    {
        /// <summary>
        ///  应用 ID
        /// </summary>
        [JsonProperty("appId")]
        public string  AppId  {get;set;}
        /// <summary>
        ///  授权主体列表，最多 10 条
        /// </summary>
        [JsonProperty("list")]
        public List<ApplicationPermissionRecordItem>  List  {get;set;}
    }
}