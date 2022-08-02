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
    /// GetUserBatchDto 的模型
    /// </summary>
    public partial class GetUserBatchDto
    {
        /// <summary>
        ///  用户 ID 数组
        /// </summary>
        [JsonProperty("userIds")]
        public    object   UserIds    {get;set;}
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
    }
}