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
    /// ResetPrincipalAuthenticationInfoRespDto 的模型
    /// </summary>
    public partial class ResetPrincipalAuthenticationInfoRespDto
    {
        /// <summary>
        ///  操作是否成功
        /// </summary>
        [JsonProperty("success")]
        public bool  Success  {get;set;}
    }
}