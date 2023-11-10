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
    /// PostItemDto 的模型
    /// </summary>
    public partial class PostItemDto
    {
        /// <summary>
        ///  分组 code
        /// </summary>
        [JsonProperty("code")]
        public string  Code {get;set;}
        /// <summary>
        ///  分组名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  分组描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  岗位关联用户数，只有在 skipCount 不为 true 时才存在
        /// </summary>
        [JsonProperty("userCount")]
        public long  UserCount {get;set;}
        /// <summary>
        ///  岗位关联部门数，只有在 skipCount 不为 true 时才存在
        /// </summary>
        [JsonProperty("departmentCount")]
        public long  DepartmentCount {get;set;}
        /// <summary>
        ///  岗位元数据信息
        /// </summary>
        [JsonProperty("metadataSource")]
        public List<string>  MetadataSource {get;set;}
    }
}