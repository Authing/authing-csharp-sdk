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
/// CheckDomainAvailableDataDto 的模型
/// </summary>
public partial class CheckDomainAvailableDataDto
{
    /// <summary>
    ///  是否可用
    /// </summary>
    [JsonProperty("available")]
    public bool  Available {get;set;}
}
}