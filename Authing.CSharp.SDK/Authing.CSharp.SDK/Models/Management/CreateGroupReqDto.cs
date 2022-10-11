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
/// CreateGroupReqDto 的模型
/// </summary>
public partial class CreateGroupReqDto
{
    /// <summary>
    ///  分组描述
    /// </summary>
[JsonProperty("description")]
public    string   Description    {get;set;}
    /// <summary>
    ///  分组名称
    /// </summary>
[JsonProperty("name")]
public    string   Name    {get;set;}
    /// <summary>
    ///  分组 code
    /// </summary>
[JsonProperty("code")]
public    string   Code    {get;set;}
}
}