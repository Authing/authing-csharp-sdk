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
    /// DataStatementPermissionDto 的模型
    /// </summary>
    public partial class DataStatementPermissionDto
    {
        /// <summary>
        ///  数据资源权限操作：ALLOW（允许）/DENY（拒绝）
        /// </summary>
        [JsonProperty("effect")]
        public effect  Effect  {get;set;}
        /// <summary>
        ///  资源权限列表，字符串数据资源和数组数据资源，没有 path 路径
        /// </summary>
        [JsonProperty("permissions")]
        public List<string>  Permissions  {get;set;}
    }
    public partial class DataStatementPermissionDto
    {
        /// <summary>
        ///  数据资源权限操作：ALLOW（允许）/DENY（拒绝）
        /// </summary>
        public enum effect
        {
            [EnumMember(Value="DENY")]
            DENY,
            [EnumMember(Value="ALLOW")]
            ALLOW,
        }
    }
}