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
/// DeleteNamespacesBatchDto 的模型
/// </summary>
public partial class DeleteNamespacesBatchDto
{
    /// <summary>
    ///  权限分组 code 列表
    /// </summary>
    [JsonProperty("codeList")]
    public List<string>  CodeList {get;set;}
}
}