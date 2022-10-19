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
/// UserTenantListDto 的模型
/// </summary>
public partial class UserTenantListDto
{
    /// <summary>
    ///  租户 ID
    /// </summary>
    [JsonProperty("tenantId")]
    public string  TenantId {get;set;}
    /// <summary>
    ///  租户名称
    /// </summary>
    [JsonProperty("tenantName")]
    public string  TenantName {get;set;}
    /// <summary>
    ///  加入租户的时间
    /// </summary>
    [JsonProperty("joinAt")]
    public string  JoinAt {get;set;}
}
}