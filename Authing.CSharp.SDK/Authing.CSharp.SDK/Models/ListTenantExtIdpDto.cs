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
/// ListTenantExtIdpDto 的模型
/// </summary>
public partial class ListTenantExtIdpDto
{
    /// <summary>
    ///  租户 ID
    /// </summary>
    [JsonProperty("tenantId")]
    public string  TenantId {get;set;} 
    /// <summary>
    ///  应用 ID
    /// </summary>
    [JsonProperty("appId")]
    public string  AppId {get;set;} 
    /// <summary>
    ///  身份源类型
    /// </summary>
    [JsonProperty("type")]
    public string  Type {get;set;} 
    /// <summary>
    ///  页码
    /// </summary>
    [JsonProperty("page")]
    public string  Page {get;set;} ="1";
    /// <summary>
    ///  每页获取的数据量
    /// </summary>
    [JsonProperty("limit")]
    public string  Limit {get;set;} ="10";
}
}