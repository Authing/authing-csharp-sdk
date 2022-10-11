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
/// DepartmentDto 的模型
/// </summary>
public partial class DepartmentDto
{
    /// <summary>
    ///  组织 Code（organizationCode）
    /// </summary>
[JsonProperty("organizationCode")]
public    string   OrganizationCode    {get;set;}
    /// <summary>
    ///  部门系统 ID（为 Authing 系统自动生成，不可修改）
    /// </summary>
[JsonProperty("departmentId")]
public    string   DepartmentId    {get;set;}
    /// <summary>
    ///  部门创建时间
    /// </summary>
[JsonProperty("createdAt")]
public    string   CreatedAt    {get;set;}
    /// <summary>
    ///  修改时间
    /// </summary>
[JsonProperty("updatedAt")]
public    string   UpdatedAt    {get;set;}
    /// <summary>
    ///  自定义部门 ID，用于存储自定义的 ID
    /// </summary>
[JsonProperty("openDepartmentId")]
public    string   OpenDepartmentId    {get;set;}
    /// <summary>
    ///  部门名称
    /// </summary>
[JsonProperty("name")]
public    string   Name    {get;set;}
    /// <summary>
    ///  部门负责人 ID
    /// </summary>
[JsonProperty("leaderUserIds")]
public    List<string>   LeaderUserIds    {get;set;}
    /// <summary>
    ///  部门描述
    /// </summary>
[JsonProperty("description")]
public    string   Description    {get;set;}
    /// <summary>
    ///  父部门 id
    /// </summary>
[JsonProperty("parentDepartmentId")]
public    string   ParentDepartmentId    {get;set;}
    /// <summary>
    ///  部门识别码
    /// </summary>
[JsonProperty("code")]
public    string   Code    {get;set;}
    /// <summary>
    ///  部门人数（仅包含直属成员）
    /// </summary>
[JsonProperty("membersCount")]
public    long   MembersCount    {get;set;}
    /// <summary>
    ///  是否包含子部门
    /// </summary>
[JsonProperty("hasChildren")]
public    bool   HasChildren    {get;set;}
    /// <summary>
    ///  是否是虚拟部门
    /// </summary>
[JsonProperty("isVirtualNode")]
public    bool   IsVirtualNode    {get;set;}
    /// <summary>
    ///  多语言设置
    /// </summary>
[JsonProperty("i18n")]
public    DepartmentI18nDto   I18n    {get;set;}
    /// <summary>
    ///  部门的扩展字段数据
    /// </summary>
[JsonProperty("customData")]
public    object   CustomData    {get;set;}
}
}