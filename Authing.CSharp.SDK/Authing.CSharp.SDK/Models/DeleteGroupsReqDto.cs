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
/// DeleteGroupsReqDto 的模型
/// </summary>
public partial class DeleteGroupsReqDto
{
    /// <summary>
    ///  分组 code 列表
    /// </summary>
    [JsonProperty("codeList")]
    public List<string>  CodeList {get;set;}
}
}