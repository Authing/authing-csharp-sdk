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
    /// ArrayOrStringActionDto 的模型
    /// </summary>
    public partial class ArrayOrStringActionDto
    {
        /// <summary>
        ///  数据资源策略节点 action 动作
        /// </summary>
        [JsonProperty("action")]
        public string  Action  {get;set;}
        /// <summary>
        ///  数据资源策略节点是否开启动作
        /// </summary>
        [JsonProperty("enabled")]
        public bool  Enabled  {get;set;}
    }
}