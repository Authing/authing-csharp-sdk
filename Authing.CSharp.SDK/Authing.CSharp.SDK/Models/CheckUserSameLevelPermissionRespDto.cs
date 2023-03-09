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
    /// CheckUserSameLevelPermissionRespDto 的模型
    /// </summary>
    public partial class CheckUserSameLevelPermissionRespDto
    {
        /// <summary>
        ///  数据资源权限操作
        /// </summary>
        [JsonProperty("action")]
        public string  Action  {get;set;}
        /// <summary>
        ///  树资源节点code
        /// </summary>
        [JsonProperty("resourceNodeCode")]
        public string  ResourceNodeCode  {get;set;}
        /// <summary>
        ///  是否拥有 action 权限
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled  {get;set;}
    }
}