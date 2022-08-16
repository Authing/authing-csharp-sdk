using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class ResetPasswordDto
    {
        /// <summary>
        /// 重置密码的 token
        /// </summary>
        public string PasswordResetToken { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }
    }
}
