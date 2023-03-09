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
    /// ChangeEmailStrategyDto 的模型
    /// </summary>
    public partial class ChangeEmailStrategyDto
    {
        /// <summary>
        ///  修改邮箱时是否验证旧邮箱
        /// </summary>
        [JsonProperty("verifyOldEmail")]
        public bool  VerifyOldEmail  {get;set;}
    }
}