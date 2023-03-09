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
    /// ActionAuth 的模型
    /// </summary>
    public partial class ActionAuth
    {
        /// <summary>
        ///  数据策略授权用户 ID 列表
        /// </summary>
        [JsonProperty("userIds")]
        public List<string>  UserIds  {get;set;}
        /// <summary>
        ///  数据资源权限操作
        /// </summary>
        [JsonProperty("action")]
        public string  Action  {get;set;}
    }
}