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
/// UpdateUserBatchReqDto 的模型
/// </summary>
public partial class UpdateUserBatchReqDto
{
    /// <summary>
    ///  用户列表
    /// </summary>
[JsonProperty("list")]
public    List<UpdateUserInfoDto>   List    {get;set;}
    /// <summary>
    ///  可选参数
    /// </summary>
[JsonProperty("options")]
public    UpdateUserBatchOptionsDto   Options    {get;set;}
}
}