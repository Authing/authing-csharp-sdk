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
/// GetCustomFieldsDto 的模型
/// </summary>
public partial class GetCustomFieldsDto
{
    /// <summary>
    ///  主体类型，目前支持用户、角色、分组、部门
    /// </summary>
    [JsonProperty("targetType")]
    public string  TargetType {get;set;} 
}
}