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
    /// LdapConfigInfoDto 的模型
    /// </summary>
    public partial class LdapConfigInfoDto
    {
        /// <summary>
        ///  ID
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
        /// <summary>
        ///  LDAP 服务是否开启1 是、2 否
        /// </summary>
        [JsonProperty("enabled")]
        public long  Enabled {get;set;}
        /// <summary>
        ///  用户池 ID
        /// </summary>
        [JsonProperty("userPoolId")]
        public string  UserPoolId {get;set;}
        /// <summary>
        ///  LDAP host
        /// </summary>
        [JsonProperty("linkUrl")]
        public string  LinkUrl {get;set;}
        /// <summary>
        ///  LDAPS host
        /// </summary>
        [JsonProperty("ldapsLinkUrl")]
        public string  LdapsLinkUrl {get;set;}
        /// <summary>
        ///  是否是私有化的 LDAP Server 1 是、2 否
        /// </summary>
        [JsonProperty("enablePrivatization")]
        public long  EnablePrivatization {get;set;}
        /// <summary>
        ///  根据 domain 生成的 bindDN
        /// </summary>
        [JsonProperty("bindDn")]
        public string  BindDn {get;set;}
        /// <summary>
        ///  LDAP 域名，用于生成 baseDN
        /// </summary>
        [JsonProperty("ldapDomain")]
        public string  LdapDomain {get;set;}
        /// <summary>
        ///  私有化时是否开启 SSL 1 是、2 否
        /// </summary>
        [JsonProperty("enableSsl")]
        public long  EnableSsl {get;set;}
        /// <summary>
        ///  dc=ibm,dc=com,o=authing
        /// </summary>
        [JsonProperty("baseDn")]
        public string  BaseDn {get;set;}
        /// <summary>
        ///  加密存储的 bindDn 密码(16位)
        /// </summary>
        [JsonProperty("bindPwd")]
        public string  BindPwd {get;set;}
        /// <summary>
        ///  组织机构可见范围，值为组织节点 ID，用逗号分隔
        /// </summary>
        [JsonProperty("visibleOrgNodes")]
        public object  VisibleOrgNodes {get;set;}
        /// <summary>
        ///  用户基础字段可见范围
        /// </summary>
        [JsonProperty("visibleFields")]
        public object  VisibleFields {get;set;}
        /// <summary>
        ///  用户拓展字段映射到的 LDAP 字段，存储为 JSON 字符串
        /// </summary>
        [JsonProperty("udfMapping")]
        public object  UdfMapping {get;set;}
    }
}