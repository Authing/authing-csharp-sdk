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
/// ParsedUserAgent 的模型
/// </summary>
public partial class ParsedUserAgent
{
    /// <summary>
    ///  使用的设备类型
    /// </summary>
[JsonProperty("device")]
public    string   Device    {get;set;}
    /// <summary>
    ///  浏览器名称
    /// </summary>
[JsonProperty("browser")]
public    string   Browser    {get;set;}
    /// <summary>
    ///  操作系统
    /// </summary>
[JsonProperty("os")]
public    string   Os    {get;set;}
}
}