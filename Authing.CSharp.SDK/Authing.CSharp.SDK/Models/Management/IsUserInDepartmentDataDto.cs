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
/// IsUserInDepartmentDataDto 的模型
/// </summary>
public partial class IsUserInDepartmentDataDto
{
    /// <summary>
    ///  是否在此部门内
    /// </summary>
[JsonProperty("inDepartment")]
public    bool   InDepartment    {get;set;}
}
}