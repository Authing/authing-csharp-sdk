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
/// RoleDepartmentRespDto 的模型
/// </summary>
public partial class RoleDepartmentRespDto
{
    /// <summary>
    ///  部门 ID
    /// </summary>
    [JsonProperty("id")]
    public string  Id {get;set;}
    /// <summary>
    ///  部门 code
    /// </summary>
    [JsonProperty("code")]
    public string  Code {get;set;}
    /// <summary>
    ///  部门名称
    /// </summary>
    [JsonProperty("name")]
    public string  Name {get;set;}
    /// <summary>
    ///  部门描述信息
    /// </summary>
    [JsonProperty("description")]
    public string  Description {get;set;}
}
}