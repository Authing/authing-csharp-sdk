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
/// ListArchivedUsersRespDto 的模型
/// </summary>
public partial class ListArchivedUsersRespDto
{
    /// <summary>
    ///  用户 ID
    /// </summary>
[JsonProperty("userId")]
public    string   UserId    {get;set;}
    /// <summary>
    ///  归档时间
    /// </summary>
[JsonProperty("archivedAt")]
public    string   ArchivedAt    {get;set;}
}
}