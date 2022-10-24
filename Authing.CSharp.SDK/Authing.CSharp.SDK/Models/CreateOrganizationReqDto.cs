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
/// CreateOrganizationReqDto 的模型
/// </summary>
public partial class CreateOrganizationReqDto
{
    /// <summary>
    ///  组织名称
    /// </summary>
    [JsonProperty("organizationName")]
    public string  OrganizationName {get;set;}
    /// <summary>
    ///  组织 code
    /// </summary>
    [JsonProperty("organizationCode")]
    public string  OrganizationCode {get;set;}
    /// <summary>
    ///  组织描述信息
    /// </summary>
    [JsonProperty("description")]
    public string  Description {get;set;}
    /// <summary>
    ///  根节点自定义 ID
    /// </summary>
    [JsonProperty("openDepartmentId")]
    public string  OpenDepartmentId {get;set;}
    /// <summary>
    ///  多语言设置
    /// </summary>
    [JsonProperty("i18n")]
    public OrganizationNameI18nDto  I18n {get;set;}
}
}