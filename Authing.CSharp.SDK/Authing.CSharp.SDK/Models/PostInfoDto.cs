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
    /// PostInfoDto 的模型
    /// </summary>
    public partial class PostInfoDto
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
        ///  岗位关联部门数
        /// </summary>
        [JsonProperty("departmentIdList")]
        public List<string>  DepartmentIdList {get;set;}
    }
}