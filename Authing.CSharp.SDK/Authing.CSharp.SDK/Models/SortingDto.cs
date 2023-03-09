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
    /// SortingDto 的模型
    /// </summary>
    public partial class SortingDto
    {
        /// <summary>
        ///  进行排序的字段，可选值为：
/// - `createdAt`: 创建时间
/// - `updatedAt`: 修改时间
/// - `email`: 邮箱
/// - `phone`: 手机号
/// - `username`: 用户名
/// - `externalId`: 外部 ID
/// - `status`: 用户状态
/// - `statusChangedAt`: 状态修改时间
/// - `passwordLastSetAt`: 密码修改时间
/// - `loginsCount`: 登录次数
/// - `gender`: 性别
/// - `lastLogin`: 上次登录时间
/// - `userSourceType`: 用户注册来源
/// - `lastMfaTime`: 上次 MFA 认证时间
/// - `passwordSecurityLevel`: 密码安全等级
/// - `phoneCountryCode`: 手机区号
/// - `lastIp`: 上次登录时使用的 IP
/// 
        /// </summary>
        [JsonProperty("field")]
        public field  Field  {get;set;}
        /// <summary>
        ///  排序顺序：
/// - `desc`: 按照从大到小降序。
/// - `asc`: 按照从小到大升序。
/// 
        /// </summary>
        [JsonProperty("order")]
        public order  Order  {get;set;}
    }
    public partial class SortingDto
    {
        /// <summary>
        ///  进行排序的字段，可选值为：
/// - `createdAt`: 创建时间
/// - `updatedAt`: 修改时间
/// - `email`: 邮箱
/// - `phone`: 手机号
/// - `username`: 用户名
/// - `externalId`: 外部 ID
/// - `status`: 用户状态
/// - `statusChangedAt`: 状态修改时间
/// - `passwordLastSetAt`: 密码修改时间
/// - `loginsCount`: 登录次数
/// - `gender`: 性别
/// - `lastLogin`: 上次登录时间
/// - `userSourceType`: 用户注册来源
/// - `lastMfaTime`: 上次 MFA 认证时间
/// - `passwordSecurityLevel`: 密码安全等级
/// - `phoneCountryCode`: 手机区号
/// - `lastIp`: 上次登录时使用的 IP
/// 
        /// </summary>
        public enum field
        {
            [EnumMember(Value="createdAt")]
            CREATED_AT,
            [EnumMember(Value="updatedAt")]
            UPDATED_AT,
            [EnumMember(Value="email")]
            EMAIL,
            [EnumMember(Value="username")]
            USERNAME,
            [EnumMember(Value="externalId")]
            EXTERNAL_ID,
            [EnumMember(Value="phone")]
            PHONE,
            [EnumMember(Value="status")]
            STATUS,
            [EnumMember(Value="statusChangedAt")]
            STATUS_CHANGED_AT,
            [EnumMember(Value="passwordLastSetAt")]
            PASSWORD_LAST_SET_AT,
            [EnumMember(Value="loginsCount")]
            LOGINS_COUNT,
            [EnumMember(Value="gender")]
            GENDER,
            [EnumMember(Value="lastLogin")]
            LAST_LOGIN,
            [EnumMember(Value="userSourceType")]
            USER_SOURCE_TYPE,
            [EnumMember(Value="lastMfaTime")]
            LAST_MFA_TIME,
            [EnumMember(Value="passwordSecurityLevel")]
            PASSWORD_SECURITY_LEVEL,
            [EnumMember(Value="phoneCountryCode")]
            PHONE_COUNTRY_CODE,
            [EnumMember(Value="lastIp")]
            LAST_IP,
        }
        /// <summary>
        ///  排序顺序：
/// - `desc`: 按照从大到小降序。
/// - `asc`: 按照从小到大升序。
/// 
        /// </summary>
        public enum order
        {
            [EnumMember(Value="desc")]
            DESC,
            [EnumMember(Value="asc")]
            ASC,
        }
    }
}