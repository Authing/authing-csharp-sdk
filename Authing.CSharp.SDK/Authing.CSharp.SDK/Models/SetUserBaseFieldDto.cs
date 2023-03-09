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
    /// SetUserBaseFieldDto 的模型
    /// </summary>
    public partial class SetUserBaseFieldDto
    {
        /// <summary>
        ///  字段 key，不能和内置字段的 key 冲突，**设置之后将不能进行修改**。
        /// </summary>
        [JsonProperty("key")]
        public string  Key  {get;set;}
        /// <summary>
        ///  显示名称
        /// </summary>
        [JsonProperty("label")]
        public string  Label  {get;set;}
        /// <summary>
        ///  详细描述信息
        /// </summary>
        [JsonProperty("description")]
        public string  Description  {get;set;}
        /// <summary>
        ///  用户是否可编辑
        /// </summary>
        [JsonProperty("userEditable")]
        public bool  UserEditable  {get;set;}
        /// <summary>
        ///  是否需要在 Authing 控制台中进行显示：
/// - 如果是用户自定义字段，控制是否在用户详情展示；
/// - 如果是部门自定义字段，控制是否在部门详情中展示；
/// - 如果是角色扩展字段，控制是否在角色详情中展示。
/// 
        /// </summary>
        [JsonProperty("visibleInAdminConsole")]
        public bool  VisibleInAdminConsole  {get;set;}
        /// <summary>
        ///  是否在用户个人中心展示（此参数不控制 API 接口是否返回）。
        /// </summary>
        [JsonProperty("visibleInUserCenter")]
        public bool  VisibleInUserCenter  {get;set;}
        /// <summary>
        ///  多语言显示名称
        /// </summary>
        [JsonProperty("i18n")]
        public CustomFieldI18n  I18n  {get;set;}
    }
}