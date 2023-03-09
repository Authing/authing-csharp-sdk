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
    /// SendTenantSmsDto 的模型
    /// </summary>
    public partial class SendTenantSmsDto
    {
        /// <summary>
        ///  管理员名字
        /// </summary>
        [JsonProperty("adminName")]
        public string  AdminName  {get;set;}
        /// <summary>
        ///  用户名
        /// </summary>
        [JsonProperty("userName")]
        public string  UserName  {get;set;}
        /// <summary>
        ///  用户唯一标识
        /// </summary>
        [JsonProperty("identifier")]
        public string  Identifier  {get;set;}
        /// <summary>
        ///  管理员手机
        /// </summary>
        [JsonProperty("phone")]
        public string  Phone  {get;set;}
        /// <summary>
        ///  管理员手机地区号
        /// </summary>
        [JsonProperty("phoneCountryCode")]
        public string  PhoneCountryCode  {get;set;}
        /// <summary>
        ///  租户 id
        /// </summary>
        [JsonProperty("tenantId")]
        public string  TenantId  {get;set;}
        /// <summary>
        ///  租户名
        /// </summary>
        [JsonProperty("tenantName")]
        public string  TenantName  {get;set;}
    }
}