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
/// UpdatePipelineFunctionDto 的模型
/// </summary>
public partial class UpdatePipelineFunctionDto
{
    /// <summary>
    ///  Pipeline 函数 ID
    /// </summary>
[JsonProperty("funcId")]
public    string   FuncId    {get;set;}
    /// <summary>
    ///  函数名称
    /// </summary>
[JsonProperty("funcName")]
public    string   FuncName    {get;set;}
    /// <summary>
    ///  函数描述
    /// </summary>
[JsonProperty("funcDescription")]
public    string   FuncDescription    {get;set;}
    /// <summary>
    ///  函数源代码。如果修改之后，函数会重新上传。
    /// </summary>
[JsonProperty("sourceCode")]
public    string   SourceCode    {get;set;}
    /// <summary>
    ///  是否异步执行。设置为异步执行的函数不会阻塞整个流程的执行，适用于异步通知的场景，比如飞书群通知、钉钉群通知等。
    /// </summary>
[JsonProperty("isAsynchronous")]
public    bool   IsAsynchronous    {get;set;}
    /// <summary>
    ///  函数运行超时时间，最短为 1 秒，最长为 60 秒，默认为 3 秒。
    /// </summary>
[JsonProperty("timeout")]
public    long   Timeout    {get;set;}
    /// <summary>
    ///  如果函数运行超时，是否终止整个流程，默认为否。
    /// </summary>
[JsonProperty("terminateOnTimeout")]
public    bool   TerminateOnTimeout    {get;set;}
    /// <summary>
    ///  是否启用此 Pipeline
    /// </summary>
[JsonProperty("enabled")]
public    bool   Enabled    {get;set;}
}
}