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
/// GetApplicationPermissionStrategyDto 的模型
/// </summary>
public partial class GetApplicationPermissionStrategyDto
{
    /// <summary>
    ///  应用 ID
    /// </summary>
[JsonProperty("appId")]
public    object   AppId    {get;set;}
}
}