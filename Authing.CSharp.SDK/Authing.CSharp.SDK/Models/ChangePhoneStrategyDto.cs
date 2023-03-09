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
    /// ChangePhoneStrategyDto 的模型
    /// </summary>
    public partial class ChangePhoneStrategyDto
    {
        /// <summary>
        ///  修改手机号时是否验证旧手机号
        /// </summary>
        [JsonProperty("verifyOldPhone")]
        public bool  VerifyOldPhone  {get;set;}
    }
}