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
    /// ListResourceTargetsDataDto 的模型
    /// </summary>
    public partial class ListResourceTargetsDataDto
    {
        /// <summary>
        ///  用户授权列表
        /// </summary>
        [JsonProperty("authUserList")]
        public List<ListResourceTargetsDtoResp>  AuthUserList {get;set;}
    }
}