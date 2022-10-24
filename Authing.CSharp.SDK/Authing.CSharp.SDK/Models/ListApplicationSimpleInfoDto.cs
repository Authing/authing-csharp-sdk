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
/// ListApplicationSimpleInfoDto 的模型
/// </summary>
public partial class ListApplicationSimpleInfoDto
{
    /// <summary>
    ///  当前页数，从 1 开始
    /// </summary>
    [JsonProperty("page")]
    public long  Page {get;set;} =1;
    /// <summary>
    ///  每页数目，最大不能超过 50，默认为 10
    /// </summary>
    [JsonProperty("limit")]
    public long  Limit {get;set;} =10;
    /// <summary>
    ///  是否为集成应用
    /// </summary>
    [JsonProperty("isIntegrateApp")]
    public bool  IsIntegrateApp {get;set;} 
    /// <summary>
    ///  是否为自建应用
    /// </summary>
    [JsonProperty("isSelfBuiltApp")]
    public bool  IsSelfBuiltApp {get;set;} 
    /// <summary>
    ///  是否开启单点登录
    /// </summary>
    [JsonProperty("ssoEnabled")]
    public bool  SsoEnabled {get;set;} 
    /// <summary>
    ///  模糊搜索字符串
    /// </summary>
    [JsonProperty("keywords")]
    public string  Keywords {get;set;} 
}
}