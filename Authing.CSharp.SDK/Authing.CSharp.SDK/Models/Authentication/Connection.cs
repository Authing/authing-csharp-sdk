using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    /// <summary>
    /// 认证方式
    /// </summary>
    public enum Connection
    {
        /// <summary>
        /// 使用密码方式进行认证
        /// </summary>
        [EnumMember(Value = "PASSWORD")]
        PASSWORD,

        /// <summary>
        /// 使用一次性临时验证码进行认证
        /// </summary>
        [EnumMember(Value = "PASSCODE")]
        PASSCODE,

        /// <summary>
        /// 基于 LDAP 用户目录进行认证
        /// </summary>
        [EnumMember(Value = "LDAP")]
        LDAP,

        /// <summary>
        /// 基于 Windows AD 用户目录进行认证
        /// </summary>
        [EnumMember(Value = "AD")]
        AD
    }
}
