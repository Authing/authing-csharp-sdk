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
    /// UserDepartmentRespDto 的模型
    /// </summary>
    public partial class UserDepartmentRespDto
    {
        /// <summary>
        ///  部门 ID
        /// </summary>
        [JsonProperty("departmentId")]
        public    string   DepartmentId    {get;set;}
        /// <summary>
        ///  部门名称
        /// </summary>
        [JsonProperty("name")]
        public    string   Name    {get;set;}
        /// <summary>
        ///  部门描述
        /// </summary>
        [JsonProperty("description")]
        public    string   Description    {get;set;}
        /// <summary>
        ///  是否是部门 Leader
        /// </summary>
        [JsonProperty("isLeader")]
        public    bool   IsLeader    {get;set;}
        /// <summary>
        ///  部门识别码
        /// </summary>
        [JsonProperty("code")]
        public    string   Code    {get;set;}
        /// <summary>
        ///  是否是主部门
        /// </summary>
        [JsonProperty("isMainDepartment")]
        public    bool   IsMainDepartment    {get;set;}
    }
}