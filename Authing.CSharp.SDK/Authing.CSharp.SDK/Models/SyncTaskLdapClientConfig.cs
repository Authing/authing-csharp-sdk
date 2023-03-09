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
    /// SyncTaskLdapClientConfig 的模型
    /// </summary>
    public partial class SyncTaskLdapClientConfig
    {
        /// <summary>
        ///  LDAP 链接
        /// </summary>
        [JsonProperty("url")]
        public string  Url  {get;set;}
        /// <summary>
        ///  Bind DN
        /// </summary>
        [JsonProperty("bindDn")]
        public string  BindDn  {get;set;}
        /// <summary>
        ///  Bind DN 密码
        /// </summary>
        [JsonProperty("bindCredentials")]
        public string  BindCredentials  {get;set;}
        /// <summary>
        ///  Users Base DN
        /// </summary>
        [JsonProperty("usersBaseDn")]
        public string  UsersBaseDn  {get;set;}
        /// <summary>
        ///  Groups Base Dn
        /// </summary>
        [JsonProperty("groupsBaseDn")]
        public string  GroupsBaseDn  {get;set;}
        /// <summary>
        ///  用户查询条件
        /// </summary>
        [JsonProperty("userQueryCriteria")]
        public string  UserQueryCriteria  {get;set;}
        /// <summary>
        ///  部门查询条件
        /// </summary>
        [JsonProperty("departmentQueryCriteria")]
        public string  DepartmentQueryCriteria  {get;set;}
    }
}