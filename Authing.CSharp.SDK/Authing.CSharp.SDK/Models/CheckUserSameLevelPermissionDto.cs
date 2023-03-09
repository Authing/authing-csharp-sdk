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
    /// CheckUserSameLevelPermissionDto 的模型
    /// </summary>
    public partial class CheckUserSameLevelPermissionDto
    {
        /// <summary>
        ///  当前树资源路径子节点 Code
        /// </summary>
        [JsonProperty("resourceNodeCodes")]
        public List<string>  ResourceNodeCodes  {get;set;}
        /// <summary>
        ///  树资源路径,允许多层级路径，示例如下所示
/// - treeResourceCode
/// - treeResourceCode/structCode
/// - treeResourceCode/structCode/struct1Code
/// - treeResourceCode/.../structCode
        /// </summary>
        [JsonProperty("resource")]
        public string  Resource  {get;set;}
        /// <summary>
        ///  数据资源权限操作
        /// </summary>
        [JsonProperty("action")]
        public string  Action  {get;set;}
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId  {get;set;}
        /// <summary>
        ///  权限空间 Code
        /// </summary>
        [JsonProperty("namespaceCode")]
        public string  NamespaceCode  {get;set;}
        /// <summary>
        ///  是否开启条件判断，默认 false 不开启
        /// </summary>
        [JsonProperty("judgeConditionEnabled")]
        public bool  JudgeConditionEnabled  {get;set;}
        /// <summary>
        ///  条件环境属性，若开启条件判断则使用
        /// </summary>
        [JsonProperty("authEnvParams")]
        public AuthEnvParams  AuthEnvParams  {get;set;}
    }
}