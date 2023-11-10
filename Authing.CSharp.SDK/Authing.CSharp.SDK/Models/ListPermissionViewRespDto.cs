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
    /// ListPermissionViewRespDto 的模型
    /// </summary>
    public partial class ListPermissionViewRespDto
    {
        /// <summary>
        ///  用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
        /// <summary>
        ///  用户真实名称，不具备唯一性
        /// </summary>
        [JsonProperty("username")]
        public string  Username {get;set;}
        /// <summary>
        ///  权限空间 id
        /// </summary>
        [JsonProperty("namespaceId")]
        public string  NamespaceId {get;set;}
        /// <summary>
        ///  权限空间 Code
        /// </summary>
        [JsonProperty("namespaceCode")]
        public string  NamespaceCode {get;set;}
        /// <summary>
        ///  权限空间名称
        /// </summary>
        [JsonProperty("namespaceName")]
        public string  NamespaceName {get;set;}
        /// <summary>
        ///  数据资源 id
        /// </summary>
        [JsonProperty("dataResourceId")]
        public string  DataResourceId {get;set;}
        /// <summary>
        ///  数据资源 Code
        /// </summary>
        [JsonProperty("dataResourceCode")]
        public string  DataResourceCode {get;set;}
        /// <summary>
        ///  数据资源 名称
        /// </summary>
        [JsonProperty("dataResourceName")]
        public string  DataResourceName {get;set;}
        /// <summary>
        ///  数据策略列表
        /// </summary>
        [JsonProperty("dataPolicyList")]
        public List<PolicyBo>  DataPolicyList {get;set;}
        /// <summary>
        ///  角色列表
        /// </summary>
        [JsonProperty("roleList")]
        public List<RoleBo>  RoleList {get;set;}
        /// <summary>
        ///  用户组列表
        /// </summary>
        [JsonProperty("groupList")]
        public List<GroupBo>  GroupList {get;set;}
        /// <summary>
        ///  组织机构列表
        /// </summary>
        [JsonProperty("nodeList")]
        public List<NodeBo>  NodeList {get;set;}
    }
}