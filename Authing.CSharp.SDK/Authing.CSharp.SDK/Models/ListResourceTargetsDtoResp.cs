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
    /// ListResourceTargetsDtoResp 的模型
    /// </summary>
    public partial class ListResourceTargetsDtoResp
    {
        /// <summary>
        ///  资源路径
        /// </summary>
        [JsonProperty("resource")]
        public string  Resource  {get;set;}
        /// <summary>
        ///  数据资源权限操作列表
        /// </summary>
        [JsonProperty("actionAuthList")]
        public List<ActionAuth>  ActionAuthList  {get;set;}
    }
}