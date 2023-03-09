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
    /// CommonResourceDto 的模型
    /// </summary>
    public partial class CommonResourceDto
    {
        /// <summary>
        ///  资源唯一标志符
        /// </summary>
        [JsonProperty("code")]
        public string  Code  {get;set;}
        /// <summary>
        ///  资源描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description  {get;set;}
        /// <summary>
        ///  资源名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name  {get;set;}
        /// <summary>
        ///  资源类型，如数据、API、按钮、菜单
        /// </summary>
        [JsonProperty("type")]
        public type  Type  {get;set;}
        /// <summary>
        ///  资源定义的操作类型
        /// </summary>
        [JsonProperty("actions")]
        public List<ResourceAction>  Actions  {get;set;}
        /// <summary>
        ///  API 资源的 URL 标识
        /// </summary>
        [JsonProperty("apiIdentifier")]
        public string  ApiIdentifier  {get;set;}
        /// <summary>
        ///  所属权限分组(权限空间)的 Code
        /// </summary>
        [JsonProperty("namespace")]
        public string  Namespace  {get;set;}
        /// <summary>
        ///  租户应用是否关联自建应用资源
        /// </summary>
        [JsonProperty("linkedToTenant")]
        public bool  LinkedToTenant  {get;set;}
        /// <summary>
        ///  资源id
        /// </summary>
        [JsonProperty("id")]
        public string  Id  {get;set;}
        /// <summary>
        ///  权限应用id
        /// </summary>
        [JsonProperty("namespaceId")]
        public long  NamespaceId  {get;set;}
        /// <summary>
        ///  权限应用名称
        /// </summary>
        [JsonProperty("namespaceName")]
        public string  NamespaceName  {get;set;}
        /// <summary>
        ///  UserPool ID
        /// </summary>
        [JsonProperty("userPoolId")]
        public string  UserPoolId  {get;set;}
        /// <summary>
        ///  创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string  CreatedAt  {get;set;}
        /// <summary>
        ///  更新时间
        /// </summary>
        [JsonProperty("updatedAt")]
        public string  UpdatedAt  {get;set;}
    }
    public partial class CommonResourceDto
    {
        /// <summary>
        ///  资源类型，如数据、API、按钮、菜单
        /// </summary>
        public enum type
        {
            [EnumMember(Value="DATA")]
            DATA,
            [EnumMember(Value="API")]
            API,
            [EnumMember(Value="MENU")]
            MENU,
            [EnumMember(Value="BUTTON")]
            BUTTON,
            [EnumMember(Value="UI")]
            UI,
        }
    }
}