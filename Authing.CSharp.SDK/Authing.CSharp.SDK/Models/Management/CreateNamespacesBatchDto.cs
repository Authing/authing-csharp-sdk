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
/// CreateNamespacesBatchDto 的模型
/// </summary>
public partial class CreateNamespacesBatchDto
{
    /// <summary>
    ///  权限分组列表
    /// </summary>
[JsonProperty("list")]
public    List<CreateNamespacesBatchItemDto>   List    {get;set;}
}
}