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
/// SetCustomFieldsReqDto 的模型
/// </summary>
public partial class SetCustomFieldsReqDto
{
    /// <summary>
    ///  自定义字段列表
    /// </summary>
[JsonProperty("list")]
public    List<SetCustomFieldDto>   List    {get;set;}
}
}