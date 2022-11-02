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
    /// GetManagementAccessTokenDto 的模型
    /// </summary>
    public partial class GetManagementAccessTokenDto
    {
        /// <summary>
        ///  AccessKey ID: 如果是以用户池全局 AK/SK 初始化，为用户池 ID;如果是以协作管理员的 AK/SK 初始化，为协作管理员的 AccessKey ID。
        /// </summary>
        [JsonProperty("accessKeyId")]
        public string  AccessKeyId {get;set;}
        /// <summary>
        ///  AccessKey Secret: 如果是以用户池全局 AK/SK 初始化，为用户池密钥；如果是以协作管理员的 AK/SK 初始化，为协作管理员的 SK。
        /// </summary>
        [JsonProperty("accessKeySecret")]
        public string  AccessKeySecret {get;set;}
    }
}