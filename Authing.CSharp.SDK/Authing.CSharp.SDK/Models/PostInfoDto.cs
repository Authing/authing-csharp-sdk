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
        /// 岗位 ID
        /// </summary>
        [JsonProperty("id")]
        public string ID { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        /// <summary>
        /// 所属用户池 ID
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolID { get; set; }
        /// <summary>
        ///  分组 code
        /// </summary>
        [JsonProperty("code")]
        public string  Code  {get;set;}
        /// <summary>
        ///  分组名称
        /// </summary>
        [JsonProperty("name")]
        public string  Name  {get;set;}
        /// <summary>
        ///  分组描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description  {get;set;}
        /// <summary>
        ///  岗位关联部门数
        /// </summary>
        [JsonProperty("departmentIdList")]
        public List<string>  DepartmentIdList  {get;set;}
    }
}