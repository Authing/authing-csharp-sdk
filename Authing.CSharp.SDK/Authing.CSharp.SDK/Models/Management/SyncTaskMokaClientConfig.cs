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
/// SyncTaskMokaClientConfig 的模型
/// </summary>
public partial class SyncTaskMokaClientConfig
{
    /// <summary>
    ///  User Name
    /// </summary>
[JsonProperty("userName")]
public    string   UserName    {get;set;}
    /// <summary>
    ///  Ent Code
    /// </summary>
[JsonProperty("entCode")]
public    string   EntCode    {get;set;}
    /// <summary>
    ///  Api Code Employee
    /// </summary>
[JsonProperty("apiCode_employee")]
public    string   ApiCode_employee    {get;set;}
    /// <summary>
    ///  Api Code Department
    /// </summary>
[JsonProperty("apiCode_department")]
public    string   ApiCode_department    {get;set;}
    /// <summary>
    ///  Private Key
    /// </summary>
[JsonProperty("privateKey")]
public    string   PrivateKey    {get;set;}
}
}