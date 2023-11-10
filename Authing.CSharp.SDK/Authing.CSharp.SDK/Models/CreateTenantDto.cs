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
    /// CreateTenantDto 的模型
    /// </summary>
    public partial class CreateTenantDto
    {
        /// <summary>
        ///  租户名
        /// </summary>
        [JsonProperty("name")]
        public string  Name {get;set;}
        /// <summary>
        ///  租户关联的应用 ID
        /// </summary>
        [JsonProperty("appIds")]
        public List<string>  AppIds {get;set;}
        /// <summary>
        ///  租户 logo
        /// </summary>
        [JsonProperty("logo")]
        public List<string>  Logo {get;set;}
        /// <summary>
        ///  租户描述
        /// </summary>
        [JsonProperty("description")]
        public string  Description {get;set;}
        /// <summary>
        ///  用户被租户拒绝登录时显示的提示文案
        /// </summary>
        [JsonProperty("rejectHint")]
        public string  RejectHint {get;set;}
        /// <summary>
        ///  租户来源的应用 ID，该值不存在时代表租户来源为 Authing 控制台
        /// </summary>
        [JsonProperty("sourceAppId")]
        public string  SourceAppId {get;set;}
        /// <summary>
        ///  企业邮箱域名
        /// </summary>
        [JsonProperty("enterpriseDomains")]
        public List<string>  EnterpriseDomains {get;set;}
        /// <summary>
        ///  租户过期时间
        /// </summary>
        [JsonProperty("expireTime")]
        public string  ExpireTime {get;set;}
        /// <summary>
        ///  租户 MAU 上限
        /// </summary>
        [JsonProperty("mauAmount")]
        public long  MauAmount {get;set;}
        /// <summary>
        ///  租户成员上限
        /// </summary>
        [JsonProperty("memberAmount")]
        public long  MemberAmount {get;set;}
        /// <summary>
        ///  租户管理员上限
        /// </summary>
        [JsonProperty("adminAmount")]
        public long  AdminAmount {get;set;}
    }
}