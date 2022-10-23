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
/// ListChildrenDepartmentsDto 的模型
/// </summary>
public partial class ListChildrenDepartmentsDto
{
    /// <summary>
    ///  组织 code
    /// </summary>
    [JsonProperty("organizationCode")]
    public string  OrganizationCode {get;set;} 
    /// <summary>
    ///  需要获取的部门 ID
    /// </summary>
    [JsonProperty("departmentId")]
    public string  DepartmentId {get;set;} 
    /// <summary>
    ///  此次调用中使用的部门 ID 的类型
    /// </summary>
    [JsonProperty("departmentIdType")]
    public string  DepartmentIdType {get;set;} 
    /// <summary>
    ///  是否要排除虚拟组织
    /// </summary>
    [JsonProperty("excludeVirtualNode")]
    public bool  ExcludeVirtualNode {get;set;} 
    /// <summary>
    ///  是否只包含虚拟组织
    /// </summary>
    [JsonProperty("onlyVirtualNode")]
    public bool  OnlyVirtualNode {get;set;} 
    /// <summary>
    ///  是否获取自定义数据
    /// </summary>
    [JsonProperty("withCustomData")]
    public bool  WithCustomData {get;set;} 
}
}