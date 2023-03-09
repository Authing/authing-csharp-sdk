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
    /// SetUserDepartmentsDto 的模型
    /// </summary>
    public partial class SetUserDepartmentsDto
    {
        /// <summary>
        ///  部门信息
        /// </summary>
        [JsonProperty("departments")]
        public List<SetUserDepartmentDto>  Departments  {get;set;}
        /// <summary>
        ///  用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId  {get;set;}
        /// <summary>
        ///  可选参数
        /// </summary>
        [JsonProperty("options")]
        public SetUserDepartmentsOptionsDto  Options  {get;set;}
    }
}