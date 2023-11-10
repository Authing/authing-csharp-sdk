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
    /// CheckPermissionDto 的模型
    /// </summary>
    public partial class CheckPermissionDto
    {
        /// <summary>
        ///  资源路径列表,**树资源需到具体树节点**
        /// </summary>
        [JsonProperty("resources")]
        public List<string>  Resources {get;set;}
        /// <summary>
        ///  数据资源权限操作, read、get、write 等动作
        /// </summary>
        [JsonProperty("action")]
        public string  Action {get;set;}
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId {get;set;}
        /// <summary>
        ///  权限空间 Code
        /// </summary>
        [JsonProperty("namespaceCode")]
        public string  NamespaceCode {get;set;}
        /// <summary>
        ///  是否开启条件判断，默认 false 不开启
        /// </summary>
        [JsonProperty("judgeConditionEnabled")]
        public bool  JudgeConditionEnabled {get;set;}
        /// <summary>
        ///  条件环境属性，若开启条件判断则使用
        /// </summary>
        [JsonProperty("authEnvParams")]
        public AuthEnvParams  AuthEnvParams {get;set;}
    }
}