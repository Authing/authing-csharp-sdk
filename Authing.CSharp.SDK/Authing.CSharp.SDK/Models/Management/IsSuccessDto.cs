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
/// IsSuccessDto 的模型
/// </summary>
public partial class IsSuccessDto
{
    /// <summary>
    ///  操作是否成功
    /// </summary>
    [JsonProperty("success")]
    public bool  Success {get;set;}
}
}