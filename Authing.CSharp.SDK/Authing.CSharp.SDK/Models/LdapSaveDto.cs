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
    /// LdapSaveDto 的模型
    /// </summary>
    public partial class LdapSaveDto
    {
        /// <summary>
        ///  LDAP 域名
        /// </summary>
        [JsonProperty("ldapDomain")]
        public string  LdapDomain {get;set;}
        /// <summary>
        ///  LDAP host
        /// </summary>
        [JsonProperty("linkUrl")]
        public string  LinkUrl {get;set;}
    }
}