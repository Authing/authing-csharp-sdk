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
    /// UserPagingDto 的模型
    /// </summary>
    public partial class UserPagingDto
    {
        /// <summary>
        ///  记录总数
        /// </summary>
        [JsonProperty("totalCount")]
        public    long   TotalCount    {get;set;}
        /// <summary>
        ///  数据列表
        /// </summary>
        [JsonProperty("list")]
        public    List<UserDto>   List    {get;set;}
    }
}