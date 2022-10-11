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
    /// ChangeQRCodeStatusDto 的模型
    /// </summary>
    public partial class ChangeQRCodeStatusDto
    {
        /// <summary>
        ///  修改二维码状态的动作:
        /// - `SCAN`: 修改二维码状态为已扫码状态，当移动 APP 扫了码之后，应当立即执行此操作；
        /// - `CONFIRM`: 修改二维码状态为已授权，执行此操作前必须先执行 `SCAN 操作；
        /// - `CANCEL`: 修改二维码状态为已取消，执行此操作前必须先执行 `SCAN 操作；
        ///
        /// </summary>
        [JsonProperty("action")]
        public    action   Action    {get;set;}
        /// <summary>
        ///  二维码唯一 ID
        /// </summary>
        [JsonProperty("qrcodeId")]
        public    string   QrcodeId    {get;set;}
    }
    public partial class ChangeQRCodeStatusDto
    {
        /// <summary>
        ///  修改二维码状态的动作:
        /// - `SCAN`: 修改二维码状态为已扫码状态，当移动 APP 扫了码之后，应当立即执行此操作；
        /// - `CONFIRM`: 修改二维码状态为已授权，执行此操作前必须先执行 `SCAN 操作；
        /// - `CANCEL`: 修改二维码状态为已取消，执行此操作前必须先执行 `SCAN 操作；
        ///
        /// </summary>
        public enum action
        {
            [EnumMember(Value="SCAN")]
            SCAN,
            [EnumMember(Value="CONFIRM")]
            CONFIRM,
            [EnumMember(Value="CANCEL")]
            CANCEL,
        }
    }
}