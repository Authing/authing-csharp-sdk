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
    /// FunctionModelDto 的模型
    /// </summary>
    public partial class FunctionModelDto
    {
        /// <summary>
        ///  功能 id
        /// </summary>
        [JsonProperty("id")]
        public string  Id {get;set;}
        /// <summary>
        ///  用户池 id
        /// </summary>
        [JsonProperty("userPoolId")]
        public string  UserPoolId {get;set;}
        /// <summary>
        ///  功能名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  功能描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  数据类型：
/// - list: 列表类型数据。
/// - tree: 树状结构数据。
/// 
        /// </summary>
        [JsonProperty("dataType")]
        public dataType  DataType {get;set;}
        /// <summary>
        ///  功能是否启用:
/// - true: 启用
/// - false: 不启用
/// 
        /// </summary>
        [JsonProperty("enable")]
        public bool  Enable {get;set;}
        /// <summary>
        ///  父级菜单
        /// </summary>
        [JsonProperty("parentKey")]
        public string  ParentKey {get;set;}
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
        /// <summary>
        ///  功能类型：
/// - user: 用户
/// - post: 岗位
/// - group: 用户组
/// - ueba: ueba
/// - department: 树状结构数据
/// - organization: 组织
/// - device: 设备
/// - device_rely: 设备
/// - custom: 自定义
/// 
        /// </summary>
        [JsonProperty("type")]
        public type  Type {get;set;}
        /// <summary>
        ///  字段排序
        /// </summary>
        [JsonProperty("fieldOrder")]
        public string  FieldOrder {get;set;}
        /// <summary>
        ///  详情页配置
        /// </summary>
        [JsonProperty("config")]
        public object  Config {get;set;}
    }
    public partial class FunctionModelDto
    {
        /// <summary>
        ///  数据类型：
/// - list: 列表类型数据。
/// - tree: 树状结构数据。
/// 
        /// </summary>
        public enum dataType
        {
            [EnumMember(Value="list")]
            LIST,
            [EnumMember(Value="tree")]
            TREE,
        }
        /// <summary>
        ///  功能类型：
/// - user: 用户
/// - post: 岗位
/// - group: 用户组
/// - ueba: ueba
/// - department: 树状结构数据
/// - organization: 组织
/// - device: 设备
/// - device_rely: 设备
/// - custom: 自定义
/// 
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