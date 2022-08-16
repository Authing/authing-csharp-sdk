using Authing.CSharp.SDK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Services
{
    public partial class AuthenticationClient
    {
        public async Task Signin(LoginByCredentialsDto loginByCredentialsDto)
        {
            if (loginByCredentialsDto.Connection == Models.Authentication.Connection.PASSWORD &&
                string.IsNullOrWhiteSpace(loginByCredentialsDto.PasswordPayLoad.Password))
            {
                throw new ArgumentException("PasswodPayLoad.Password 不能为空");
            }
            else if (loginByCredentialsDto.Connection == Models.Authentication.Connection.PASSCODE &&
                string.IsNullOrWhiteSpace(loginByCredentialsDto.PassCodePayLoad.PassCode))
            {
                throw new ArgumentException("PassCodePayLoad.PassCode 不能为空");
            }
            else if (loginByCredentialsDto.Connection == Models.Authentication.Connection.AD &&
                 string.IsNullOrWhiteSpace(loginByCredentialsDto.ADPayLoad.PassCode))
            {
                throw new ArgumentException("ADPayLoad.PassCode 不能为空");
            }
            else if (loginByCredentialsDto.Connection == Models.Authentication.Connection.LDAP &&
                 string.IsNullOrWhiteSpace(loginByCredentialsDto.LDAPPayLoad.Password))
            {
                throw new ArgumentException("LDAPPayLoad.Password 不能为空");
            }

            string json = await PostAsync("Post", "api/v3/signin", loginByCredentialsDto);
        }
    }
}
