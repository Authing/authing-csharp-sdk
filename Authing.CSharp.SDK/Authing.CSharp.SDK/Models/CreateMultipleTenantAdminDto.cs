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
    /// CreateMultipleTenantAdminDto 的模型
    /// </summary>
    public partial class CreateMultipleTenantAdminDto
    {
        /// <summary>
        ///  租户 ID
        /// </summary>
        [JsonProperty("tenantIds")]
        public List<string>  TenantIds  {get;set;}
        /// <summary>
        ///  用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public string  UserId  {get;set;}
        /// <summary>
        ///  是否授权
        /// </summary>
        [JsonProperty("apiAuthorized")]
        public bool  ApiAuthorized  {get;set;}
        /// <summary>
        ///  SMS 通知
        /// </summary>
        [JsonProperty("sendPhoneNotification")]
        public bool  SendPhoneNotification  {get;set;}
        /// <summary>
        ///  Email 通知
        /// </summary>
        [JsonProperty("sendEmailNotification")]
        public bool  SendEmailNotification  {get;set;}
    }
}