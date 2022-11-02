using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models;

   namespace Authing.CSharp.SDK.Models
{
/// <summary>
/// CustomFieldDto 的模型
/// </summary>
public partial class CustomFieldDto
{
    /// <summary>
    ///  目标对象类型：
/// - `USER`: 用户
/// - `ROLE`: 角色
/// - `GROUP`: 分组
/// - `DEPARTMENT`: 部门
/// 
    /// </summary>
    [JsonProperty("targetType")]
    public targetType  TargetType {get;set;}
    /// <summary>
    ///  创建时间，只针对自定义字段有效，内置字段没有创建时间。
    /// </summary>
    [JsonProperty("createdAt")]
    public string  CreatedAt {get;set;}
    /// <summary>
    ///  数据类型，**设置之后将不能进行修改**。
/// - `STRING`: 字符串类型
/// - `NUMBER`: 数字类型
/// - `DATETIME`: 日期类型
/// - `BOOLEAN`: 布尔类型
/// - `ENUM`: 枚举值类型
/// 
    /// </summary>
    [JsonProperty("dataType")]
    public dataType  DataType {get;set;}
    /// <summary>
    ///  字段 key，不能和内置字段的 key 冲突，**设置之后将不能进行修改**。
    /// </summary>
    [JsonProperty("key")]
    public string  Key {get;set;}
    /// <summary>
    ///  显示名称
    /// </summary>
    [JsonProperty("label")]
    public string  Label {get;set;}
    /// <summary>
    ///  详细描述信息
    /// </summary>
    [JsonProperty("description")]
    public string  Description {get;set;}
    /// <summary>
    ///  是否加密存储。开启后，该字段的**新增数据**将被加密，此参数一旦设置不可更改。
    /// </summary>
    [JsonProperty("encrypted")]
    public bool  Encrypted {get;set;}
    /// <summary>
    ///  是否为唯一字段，开启之后，当前字段上报的值将进行唯一校验。此参数只针对数据类型为字符串和数字的字段有效。
    /// </summary>
    [JsonProperty("isUnique")]
    public bool  IsUnique {get;set;}
    /// <summary>
    ///  用户是否可编辑，如果是手机号、邮箱等特殊字段，用户不能直接修改，需要先通过验证码等方式进行验证。
    /// </summary>
    [JsonProperty("userEditable")]
    public bool  UserEditable {get;set;}
    /// <summary>
    ///  是否需要在 Authing 控制台中进行显示：
/// - 如果是用户自定义字段，控制是否在用户详情展示；
/// - 如果是部门自定义字段，控制是否在部门详情中展示；
/// - 如果是角色扩展字段，控制是否在角色详情中展示。
/// 
    /// </summary>
    [JsonProperty("visibleInAdminConsole")]
    public bool  VisibleInAdminConsole {get;set;}
    /// <summary>
    ///  是否在用户个人中心展示（此参数不控制 API 接口是否返回）。
    /// </summary>
    [JsonProperty("visibleInUserCenter")]
    public bool  VisibleInUserCenter {get;set;}
    /// <summary>
    ///  多语言显示名称
    /// </summary>
    [JsonProperty("i18n")]
    public CustomFieldI18n  I18n {get;set;}
    /// <summary>
    ///  枚举值类型选择项
    /// </summary>
    [JsonProperty("options")]
    public List<CustomFieldSelectOption>  Options {get;set;}
}
public partial class CustomFieldDto
 {
    /// <summary>
    ///  目标对象类型：
/// - `USER`: 用户
/// - `ROLE`: 角色
/// - `GROUP`: 分组
/// - `DEPARTMENT`: 部门
/// 
    /// </summary>
    public enum targetType
     {
         [EnumMember(Value="USER")]
        USER,
         [EnumMember(Value="ROLE")]
        ROLE,
         [EnumMember(Value="GROUP")]
        GROUP,
         [EnumMember(Value="DEPARTMENT")]
        DEPARTMENT,
    }
    /// <summary>
    ///  数据类型，**设置之后将不能进行修改**。
/// - `STRING`: 字符串类型
/// - `NUMBER`: 数字类型
/// - `DATETIME`: 日期类型
/// - `BOOLEAN`: 布尔类型
/// - `ENUM`: 枚举值类型
/// 
    /// </summary>
    public enum dataType
     {
         [EnumMember(Value="STRING")]
        STRING,
         [EnumMember(Value="NUMBER")]
        NUMBER,
         [EnumMember(Value="DATETIME")]
        DATETIME,
         [EnumMember(Value="BOOLEAN")]
        BOOLEAN,
         [EnumMember(Value="ENUM")]
        ENUM,
    }
}
}