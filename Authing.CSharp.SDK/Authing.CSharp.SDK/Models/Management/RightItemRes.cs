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
/// RightItemRes 的模型
/// </summary>
public partial class RightItemRes
{
    /// <summary>
    ///  响应数据
    /// </summary>
    [JsonProperty("rightsItems")]
    public List<RightItemDto>  RightsItems {get;set;}
}
}