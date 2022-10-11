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
/// GetNamespacesBatchDto 的模型
/// </summary>
public partial class GetNamespacesBatchDto
{
    /// <summary>
    ///  资源 code 列表，批量可以使用逗号分隔
    /// </summary>
[JsonProperty("codeList")]
public    object   CodeList    {get;set;}
}
}