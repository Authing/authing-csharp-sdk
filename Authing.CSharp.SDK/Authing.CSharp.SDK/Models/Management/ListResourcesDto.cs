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
    /// ListResourcesDto 的模型
    /// </summary>
    public partial class ListResourcesDto
    {
        /// <summary>
        ///  所属权限分组的 code
        /// </summary>
        [JsonProperty("namespace")]
        public    object   Namespace    {get;set;}
        /// <summary>
        ///  资源类型
        /// </summary>
        [JsonProperty("type")]
        public    object   Type    {get;set;}
        /// <summary>
        ///  当前页数，从 1 开始
        /// </summary>
        [JsonProperty("page")]
        public    object   Page    {get;set;}
        /// <summary>
        ///  每页数目，最大不能超过 50，默认为 10
        /// </summary>
        [JsonProperty("limit")]
        public    object   Limit    {get;set;}
    }
}