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
    /// QRCodeStatusBriefUserInfoDto 的模型
    /// </summary>
    public partial class QRCodeStatusBriefUserInfoDto
    {
        /// <summary>
        ///  用户显示昵称
        /// </summary>
        [JsonProperty("displayName")]
        public    string   DisplayName    {get;set;}
        /// <summary>
        ///  用户头像
        /// </summary>
        [JsonProperty("photo")]
        public    string   Photo    {get;set;}
    }
}