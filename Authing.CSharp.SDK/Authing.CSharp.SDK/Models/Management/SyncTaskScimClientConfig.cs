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
/// SyncTaskScimClientConfig 的模型
/// </summary>
public partial class SyncTaskScimClientConfig
{
    /// <summary>
    ///  Group Url
    /// </summary>
    [JsonProperty("org_url")]
    public string  Org_url {get;set;}
    /// <summary>
    ///  User Url
    /// </summary>
    [JsonProperty("user_url")]
    public string  User_url {get;set;}
    /// <summary>
    ///  Token
    /// </summary>
    [JsonProperty("token")]
    public string  Token {get;set;}
    /// <summary>
    ///  Root Department Id
    /// </summary>
    [JsonProperty("root_department_id")]
    public string  Root_department_id {get;set;}
    /// <summary>
    ///  Parent Department
    /// </summary>
    [JsonProperty("parent_department")]
    public string  Parent_department {get;set;}
    /// <summary>
    ///  Department
    /// </summary>
    [JsonProperty("department")]
    public string  Department {get;set;}
}
}