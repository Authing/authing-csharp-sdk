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
    /// LdapUpdateDto 的模型
    /// </summary>
    public partial class LdapUpdateDto
    {
        /// <summary>
        ///  bindDn 密码
        /// </summary>
        [JsonProperty("bindPwd")]
        public string  BindPwd {get;set;}
    }
}