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
    /// UpdateFunctionModelDto 的模型
    /// </summary>
    public partial class UpdateFunctionModelDto
    {
        /// <summary>
        ///  详情页配置
        /// </summary>
        [JsonProperty("config")]
        public object  Config {get;set;}
        /// <summary>
        ///  字段序
        /// </summary>
        [JsonProperty("fieldOrder")]
        public string  FieldOrder {get;set;}
        /// <summary>
        ///  功能类型
        /// </summary>
        [JsonProperty("type")]
        public type  Type {get;set;}
        /// <summary>
        ///  父级菜单
        /// </summary>
        [JsonProperty("parentKey")]
        public string  ParentKey {get;set;}
        /// <summary>
        ///  功能是否启用
        /// </summary>
        [JsonProperty("enable")]
        public bool  Enable {get;set;}
        /// <summary>
        ///  功能描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  功能名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  功能 id
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
    }
    public partial class UpdateFunctionModelDto
    {
        /// <summary>
        ///  功能类型
        /// </summary>
        public enum type
        {
            [EnumMember(Value="ueba")]
            UEBA,
            [EnumMember(Value="user")]
            USER,
            [EnumMember(Value="post")]
            POST,
            [EnumMember(Value="group")]
            GROUP,
            [EnumMember(Value="department")]
            DEPARTMENT,
            [EnumMember(Value="organization")]
            ORGANIZATION,
            [EnumMember(Value="device")]
            DEVICE,
            [EnumMember(Value="device_rely")]
            DEVICE_RELY,
            [EnumMember(Value="custom")]
            CUSTOM,
        }
    }
}