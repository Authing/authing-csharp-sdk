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
    /// ChangePushCodeStatusDto 的模型
    /// </summary>
    public partial class ChangePushCodeStatusDto
    {
        /// <summary>
        ///  修改推送码状态的动作:
/// - `CONFIRM`: 修改推送码状态为已授权；
/// - `CANCEL`: 修改推送码状态为已取消；
/// 
        /// </summary>
        [JsonProperty("action")]
        public action  Action  {get;set;}
        /// <summary>
        ///  推送码（推送登录唯一 ID）
        /// </summary>
        [JsonProperty("pushCodeId")]
        public string  PushCodeId  {get;set;}
    }
    public partial class ChangePushCodeStatusDto
    {
        /// <summary>
        ///  修改推送码状态的动作:
/// - `CONFIRM`: 修改推送码状态为已授权；
/// - `CANCEL`: 修改推送码状态为已取消；
/// 
        /// </summary>
        public enum action
        {
            [EnumMember(Value="CONFIRM")]
            CONFIRM,
            [EnumMember(Value="CANCEL")]
            CANCEL,
        }
    }
}