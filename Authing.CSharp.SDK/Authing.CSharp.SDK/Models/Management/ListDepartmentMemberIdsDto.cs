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
/// ListDepartmentMemberIdsDto 的模型
/// </summary>
public partial class ListDepartmentMemberIdsDto
{
    /// <summary>
    ///  组织 code
    /// </summary>
    [JsonProperty("organizationCode")]
    public string  OrganizationCode {get;set;}
    /// <summary>
    ///  部门 ID，根部门传 `root`
    /// </summary>
    [JsonProperty("departmentId")]
    public string  DepartmentId {get;set;}
    /// <summary>
    ///  此次调用中使用的部门 ID 的类型
    /// </summary>
    [JsonProperty("departmentIdType")]
    public string  DepartmentIdType {get;set;}
}
}