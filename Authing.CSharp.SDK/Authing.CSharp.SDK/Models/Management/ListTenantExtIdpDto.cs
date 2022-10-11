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
/// ListTenantExtIdpDto 的模型
/// </summary>
public partial class ListTenantExtIdpDto
{
    /// <summary>
    ///  租户 ID
    /// </summary>
[JsonProperty("tenantId")]
public    object   TenantId    {get;set;}
    /// <summary>
    ///  应用 ID
    /// </summary>
[JsonProperty("appId")]
public    object   AppId    {get;set;}
    /// <summary>
    ///  身份源类型
    /// </summary>
[JsonProperty("type")]
public    object   Type    {get;set;}
    /// <summary>
    ///  页码
    /// </summary>
[JsonProperty("page")]
public    object   Page    {get;set;}
    /// <summary>
    ///  每页获取的数据量
    /// </summary>
[JsonProperty("limit")]
public    object   Limit    {get;set;}
}
}