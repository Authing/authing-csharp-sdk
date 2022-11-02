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
/// SyncTaskProvisioningScope 的模型
/// </summary>
public partial class SyncTaskProvisioningScope
{
    /// <summary>
    ///  是否同步所选组织机构下的所有用户和部门
    /// </summary>
    [JsonProperty("all")]
    public bool  All {get;set;}
    /// <summary>
    ///  是否包含新增的用户
    /// </summary>
    [JsonProperty("includeNewUsers")]
    public bool  IncludeNewUsers {get;set;}
}
}