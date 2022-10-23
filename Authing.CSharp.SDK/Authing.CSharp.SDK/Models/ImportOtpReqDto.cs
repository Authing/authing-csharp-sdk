using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


   namespace Authing.CSharp.SDK.Models
{
/// <summary>
/// ImportOtpReqDto 的模型
/// </summary>
public partial class ImportOtpReqDto
{
    /// <summary>
    ///  参数列表
    /// </summary>
    [JsonProperty("list")]
    public List<ImportOtpItemDto>  List {get;set;}
}
}