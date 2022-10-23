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
/// ListUsersRequestDto 的模型
/// </summary>
public partial class ListUsersRequestDto
{
    /// <summary>
    ///  模糊搜索关键字
    /// </summary>
    [JsonProperty("keywords")]
    public string  Keywords {get;set;}
    /// <summary>
    ///  高级搜索
    /// </summary>
    [JsonProperty("advancedFilter")]
    public List<ListUsersAdvancedFilterItemDto>  AdvancedFilter {get;set;}
    /// <summary>
    ///  可选项
    /// </summary>
    [JsonProperty("options")]
    public ListUsersOptionsDto  Options {get;set;}
}
}