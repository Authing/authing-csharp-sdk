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
/// AddGroupMembersReqDto 的模型
/// </summary>
public partial class AddGroupMembersReqDto
{
    /// <summary>
    ///  用户 ID 数组
    /// </summary>
    [JsonProperty("userIds")]
    public List<string>  UserIds {get;set;}
    /// <summary>
    ///  分组 code
    /// </summary>
    [JsonProperty("code")]
    public string  Code {get;set;}
}
}