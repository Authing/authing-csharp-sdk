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
    /// SendManyTenantSmsDto 的模型
    /// </summary>
    public partial class SendManyTenantSmsDto
    {
        /// <summary>
        ///  管理员名
        /// </summary>
        [JsonProperty("adminName")]
        public string  AdminName  {get;set;}
        /// <summary>
        ///  导入 id
        /// </summary>
        [JsonProperty("importId")]
        public long  ImportId  {get;set;}
        /// <summary>
        ///  需要短信通知的管理员
        /// </summary>
        [JsonProperty("users")]
        public List<SendTenantSmsDto>  Users  {get;set;}
    }
}