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
/// ListApplicationsDto 的模型
/// </summary>
public partial class ListApplicationsDto
{
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
    ///  是否为集成应用
    /// </summary>
[JsonProperty("isIntegrateApp")]
public    object   IsIntegrateApp    {get;set;}
    /// <summary>
    ///  是否为自建应用
    /// </summary>
[JsonProperty("isSelfBuiltApp")]
public    object   IsSelfBuiltApp    {get;set;}
    /// <summary>
    ///  是否开启单点登录
    /// </summary>
[JsonProperty("ssoEnabled")]
public    object   SsoEnabled    {get;set;}
    /// <summary>
    ///  模糊搜索字符串
    /// </summary>
[JsonProperty("keyword")]
public    object   Keyword    {get;set;}
}
}