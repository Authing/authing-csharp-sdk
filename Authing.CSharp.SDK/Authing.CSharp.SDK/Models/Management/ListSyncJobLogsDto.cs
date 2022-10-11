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
/// ListSyncJobLogsDto 的模型
/// </summary>
public partial class ListSyncJobLogsDto
{
    /// <summary>
    ///  同步作业 ID
    /// </summary>
[JsonProperty("syncJobId")]
public    object   SyncJobId    {get;set;}
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
    /// <summary>
    ///  根据是否操作成功进行筛选
    /// </summary>
[JsonProperty("success")]
public    object   Success    {get;set;}
    /// <summary>
    ///  根据操作类型进行筛选：
/// - `CreateUser`: 创建用户
/// - `UpdateUser`: 修改用户信息
/// - `DeleteUser`: 删除用户
/// - `UpdateUserIdentifier`: 修改用户唯一标志符
/// - `ChangeUserDepartment`: 修改用户部门
/// - `CreateDepartment`: 创建部门
/// - `UpdateDepartment`: 修改部门信息
/// - `DeleteDepartment`: 删除部门
/// - `MoveDepartment`: 移动部门
/// - `UpdateDepartmentLeader`: 同步部门负责人
/// - `CreateGroup`: 创建分组
/// - `UpdateGroup`: 修改分组
/// - `DeleteGroup`: 删除分组
/// - `Updateless`: 无更新
/// 
    /// </summary>
[JsonProperty("action")]
public    object   Action    {get;set;}
    /// <summary>
    ///  操作对象类型:
/// - `department`: 部门
/// - `user`: 用户
/// 
    /// </summary>
[JsonProperty("objectType")]
public    object   ObjectType    {get;set;}
}
}