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
    /// RolePermissionListDto 的模型
    /// </summary>
    public partial class RolePermissionListDto
    {
        /// <summary>
        ///  角色 ID
        /// </summary>
        [JsonProperty("roleId")]
        public string  RoleId  {get;set;}
        /// <summary>
        ///  主体状态，DISABLE-未加入角色，ENABLE-已经加入了角色
        /// </summary>
        [JsonProperty("status")]
        public string  Status  {get;set;}
        /// <summary>
        ///  主体加入时间毫秒值
        /// </summary>
        [JsonProperty("enableTime")]
        public long  EnableTime  {get;set;}
        /// <summary>
        ///  主体失效时间毫秒值，为 null 表示用不失效
        /// </summary>
        [JsonProperty("endTime")]
        public long  EndTime  {get;set;}
        /// <summary>
        ///  所属用户池 ID
        /// </summary>
        [JsonProperty("userPoolId")]
        public string  UserPoolId  {get;set;}
        /// <summary>
        ///  角色名称，最多 50 字符
        /// </summary>
        [JsonProperty("roleName")]
        public string  RoleName  {get;set;}
        /// <summary>
        ///  角色 code,只能使用字母、数字和 -_，最多 50 字符
        /// </summary>
        [JsonProperty("roleCode")]
        public string  RoleCode  {get;set;}
        /// <summary>
        ///  角色描述信息,最多两百字符
        /// </summary>
        [JsonProperty("description")]
        public string  Description  {get;set;}
        /// <summary>
        ///  创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string  CreatedAt  {get;set;}
        /// <summary>
        ///  更新时间
        /// </summary>
        [JsonProperty("updatedAt")]
        public string  UpdatedAt  {get;set;}
    }
}