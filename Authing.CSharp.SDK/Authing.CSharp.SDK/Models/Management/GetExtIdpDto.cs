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
/// GetExtIdpDto 的模型
/// </summary>
public partial class GetExtIdpDto
{
    /// <summary>
    ///  身份源 ID
    /// </summary>
[JsonProperty("id")]
public    object   Id    {get;set;}
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
}
}