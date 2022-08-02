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
    /// GetUserDto 的模型
    /// </summary>
    public partial class GetUserDto
    {
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public    object   UserId    {get;set;}
        /// <summary>
        ///  是否获取自定义数据
        /// </summary>
        [JsonProperty("withCustomData")]
        public    object   WithCustomData    {get;set;}
        /// <summary>
        ///  是否获取 identities
        /// </summary>
        [JsonProperty("withIdentities")]
        public    object   WithIdentities    {get;set;}
        /// <summary>
        ///  是否获取部门 ID 列表
        /// </summary>
        [JsonProperty("withDepartmentIds")]
        public    object   WithDepartmentIds    {get;set;}
        /// <summary>
        ///  手机号
        /// </summary>
        [JsonProperty("phone")]
        public    object   Phone    {get;set;}
        /// <summary>
        ///  邮箱
        /// </summary>
        [JsonProperty("email")]
        public    object   Email    {get;set;}
        /// <summary>
        ///  用户名
        /// </summary>
        [JsonProperty("username")]
        public    object   Username    {get;set;}
        /// <summary>
        ///  原系统 ID
        /// </summary>
        [JsonProperty("externalId")]
        public    object   ExternalId    {get;set;}
    }
}