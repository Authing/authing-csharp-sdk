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
    /// Result 的模型
    /// </summary>
    public partial class Result
    {
        /// <summary>
        ///  新增用户数
        /// </summary>
        [JsonProperty("addUser")]
        public long  AddUser {get;set;}
        /// <summary>
        ///  更新用户数
        /// </summary>
        [JsonProperty("updateUser")]
        public long  UpdateUser {get;set;}
        /// <summary>
        ///  新增部门数
        /// </summary>
        [JsonProperty("addDepartment")]
        public long  AddDepartment {get;set;}
        /// <summary>
        ///  更新部门数
        /// </summary>
        [JsonProperty("updateDepartment")]
        public long  UpdateDepartment {get;set;}
    }
}