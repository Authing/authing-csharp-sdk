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
    /// OperateModelDto 的模型
    /// </summary>
    public partial class OperateModelDto
    {
        /// <summary>
        ///  操作 id
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
        /// <summary>
        ///  用户池 id
        /// </summary>
        [JsonProperty("userPoolId")]
        public string  UserPoolId {get;set;}
        /// <summary>
        ///  功能 id
        /// </summary>
        [JsonProperty("modelId")]
        public string  ModelId {get;set;}
        /// <summary>
        ///  操作名称
        /// </summary>
        [JsonProperty("operateName")]
        public string  OperateName {get;set;}
        /// <summary>
        ///  操作方法 key
        /// </summary>
        [JsonProperty("operateKey")]
        public string  OperateKey {get;set;}
        /// <summary>
        ///  是否展示:
/// - true: 展示
/// - false: 不展示
/// 
        /// </summary>
        [JsonProperty("show")]
        public bool  Show {get;set;}
        /// <summary>
        ///  是否为默认操作:
/// - true 是默认操作
/// - fasle 不是默认操作
/// 
        /// </summary>
        [JsonProperty("isDefault")]
        public bool  IsDefault {get;set;}
        /// <summary>
        ///  创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string  CreatedAt {get;set;}
        /// <summary>
        ///  更新时间
        /// </summary>
        [JsonProperty("updatedAt")]
        public string  UpdatedAt {get;set;}
    }
}