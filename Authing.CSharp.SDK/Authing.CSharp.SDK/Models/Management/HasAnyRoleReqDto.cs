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
/// HasAnyRoleReqDto 的模型
/// </summary>
public partial class HasAnyRoleReqDto
{
    /// <summary>
    ///  角色列表
    /// </summary>
[JsonProperty("roles")]
public    List<HasRoleRolesDto>   Roles    {get;set;}
    /// <summary>
    ///  用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。
    /// </summary>
[JsonProperty("userId")]
public    string   UserId    {get;set;}
    /// <summary>
    ///  可选参数
    /// </summary>
[JsonProperty("options")]
public    HasAnyRoleOptionsDto   Options    {get;set;}
}
}