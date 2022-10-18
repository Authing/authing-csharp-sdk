using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

namespace Authing.CSharp.SDK.Models.Management
{
    /// <summary>
    /// CreateResourceBatchItemDto 的模型
    /// </summary>
    public partial class CreateResourceBatchItemDto
    {
        /// <summary>
        ///  资源唯一标志符
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }
        /// <summary>
        ///  资源描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }
        /// <summary>
        ///  资源名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        ///  资源类型，如数据、API、按钮、菜单
        /// </summary>
        [JsonProperty("type")]
        public type Type { get; set; }
        /// <summary>
        ///  资源定义的操作类型
        /// </summary>
        [JsonProperty("actions")]
        public List<ResourceAction> Actions { get; set; }
        /// <summary>
        ///  API 资源的 URL 标识
        /// </summary>
        [JsonProperty("apiIdentifier")]
        public string ApiIdentifier { get; set; }
    }
    public partial class CreateResourceBatchItemDto
    {
        /// <summary>
        ///  资源类型，如数据、API、按钮、菜单
        /// </summary>
        public enum type
        {
            [EnumMember(Value = "DATA")]
            DATA,
            [EnumMember(Value = "API")]
            API,
            [EnumMember(Value = "MENU")]
            MENU,
            [EnumMember(Value = "BUTTON")]
            BUTTON,
            [EnumMember(Value = "UI")]
            UI,
        }
    }
}