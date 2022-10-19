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
/// CreateRolesBatch 的模型
/// </summary>
public partial class CreateRolesBatch
{
    /// <summary>
    ///  角色列表
    /// </summary>
    [JsonProperty("list")]
    public List<RoleListItem>  List {get;set;}
}
}