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
/// GetOrganizationDto 的模型
/// </summary>
public partial class GetOrganizationDto
{
    /// <summary>
    ///  组织 Code（organizationCode）
    /// </summary>
    [JsonProperty("organizationCode")]
    public string  OrganizationCode {get;set;}
    /// <summary>
    ///  是否获取自定义数据
    /// </summary>
    [JsonProperty("withCustomData")]
    public bool  WithCustomData {get;set;}
}
}