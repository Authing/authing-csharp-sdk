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
/// EmailTemplateCategoryDto 的模型
/// </summary>
public partial class EmailTemplateCategoryDto
{
    /// <summary>
    ///  类别名称
    /// </summary>
    [JsonProperty("title")]
    public string  Title {get;set;}
    /// <summary>
    ///  类别英文名称
    /// </summary>
    [JsonProperty("titleEn")]
    public string  TitleEn {get;set;}
    /// <summary>
    ///  描述
    /// </summary>
    [JsonProperty("desc")]
    public string  Desc {get;set;}
    /// <summary>
    ///  英文描述
    /// </summary>
    [JsonProperty("descEn")]
    public string  DescEn {get;set;}
}
}