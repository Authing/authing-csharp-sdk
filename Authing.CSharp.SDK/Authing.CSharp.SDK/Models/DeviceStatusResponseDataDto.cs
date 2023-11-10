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
    /// DeviceStatusResponseDataDto 的模型
    /// </summary>
    public partial class DeviceStatusResponseDataDto
    {
        /// <summary>
        ///  设备状态:
/// - `activated`: 使用中
/// - `suspended`: 挂起
/// - `deactivated`: 停用
/// 
        /// </summary>
        [JsonProperty("status")]
        public status  Status {get;set;}
        /// <summary>
        ///  设备挂起时的剩余秒数
        /// </summary>
        [JsonProperty("diffTime")]
        public long  DiffTime {get;set;}
    }
    public partial class DeviceStatusResponseDataDto
    {
        /// <summary>
        ///  设备状态:
/// - `activated`: 使用中
/// - `suspended`: 挂起
/// - `deactivated`: 停用
/// 
        /// </summary>
        public enum status
        {
            [EnumMember(Value="activated")]
            ACTIVATED,
            [EnumMember(Value="suspended")]
            SUSPENDED,
            [EnumMember(Value="deactivated")]
            DEACTIVATED,
        }
    }
}