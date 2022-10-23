using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using NUnit.Framework;

namespace Authing.CSharp.SDK.Framework.Test
{
    public partial class AuthenticationClientAuthTest
    {
        /// <summary>
        /// 2022-10-18 测试失败
        /// 获取用户登录日志
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserLogs()
        {
            var res = await client.GetLoginHistory();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 获取用户登录的应用
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetLoggedInAppsTest()
        {
            var res = await client.GetLoggedInApps();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 获取用户可访问的应用
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAccessibleAppsTest()
        {
            var res = await client.GetAccessibleApps();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-21 测试成功
        /// 获取用户的租户列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetGroupListTest()
        {
            var res = await client.GetGroupList();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-21 测试成功
        /// 获取用户的租户列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetRoleListTest()
        {
            var res = await client.GetRoleList();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-21 测试成功
        /// 获取用户的租户列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetTenantListTest()
        {
            var res = await client.GetTenantList();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 获取用户的部门列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetDepartmentListTest()
        {
            var res = await client.GetDepartmentList();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试失败
        /// 获取用户被授权的资源列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetAuthorizedResourcesTest()
        {
            var res = await client.GetAuthorizedResources("DATA", "iQpUp84lsd3rKcVXOcnfbofBiOrVB2");
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 获取用户资料
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetProfileTest()
        {
            var res = await client.GetProfile();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 更新用户资料
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UpdateProfileTest()
        {
            var res = await client.UpdateProfile(new UpdateUserProfileDto()
            {
                Gender = UpdateUserProfileDto.gender.M
            });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 绑定邮箱
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task BindEmailTest()
        {
            var res1 = await client.SendEmail(new SendEmailDto()
            {
                Email = "574378328@qq.com",
                Channel = SendEmailDto.channel.CHANNEL_BIND_EMAIL
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.BindEmail(new BindEmailDto()
            {
                Email = "574378328@qq.com",
                PassCode = "1787",
            });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 解绑邮箱
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UnBindEmailTest()
        {
            var res = await client.UnbindEmail(new UnbindEmailDto { });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// TODO:绑定手机
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task BindPhoneTest()
        {
            var res1 = await client.SendSms(new SendSMSDto()
            {
                PhoneNumber = "17665662048",
                Channel = SendSMSDto.channel.CHANNEL_BIND_PHONE
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.BindPhone(new BindPhoneDto()
            {
                PhoneNumber = "17665662048",
                PassCode = "1787",
            });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// TODO:解绑手机
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UnBindPhoneTest()
        {
            var res = await client.UnbindPhone(new UnbindPhoneDto { });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 获取密码强度和账号安全等级评分
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetSecurityLevelTest()
        {
            var res = await client.GetSecurityLevel();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 修改用户密码
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUpdatePasswordTest()
        {
            var res = await client.UpdatePassword(new UpdatePasswordDto()
            {
                NewPassword = "19950630@tm",
                OldPassword = "88886666",
                PasswordEncryptType = UpdatePasswordDto.passwordEncryptType.NONE
            });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 修改用户绑定邮箱
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task VerifyUpdateEmailRequestTest()
        {
            var res0 = await client.SendEmail(new SendEmailDto()
            {
                Channel = SendEmailDto.channel.CHANNEL_UPDATE_EMAIL,
                Email = "tm574378328@gmail.com"
            });
            Assert.AreEqual(200, res0.StatusCode);
            var res1 = await client.SendEmail(new SendEmailDto()
            {
                Channel = SendEmailDto.channel.CHANNEL_UPDATE_EMAIL,
                Email = "574378328@qq.com"
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.VerifyUpdateEmailRequest(new VerifyUpdateEmailRequestDto()
            {
                EmailPasscodePayload = new UpdateEmailByEmailPassCodeDto()
                {
                    NewEmail = "tm574378328@gmail.com",
                    NewEmailPassCode = "5908",
                    OldEmail = "574378328@qq.com",
                    OldEmailPassCode = "2925"
                },
                VerifyMethod = VerifyUpdateEmailRequestDto.verifyMethod.EMAIL_PASSCODE
            });
            Assert.AreEqual(200, res2.StatusCode);
            var res3 = await client.UpdateEmail(new UpdateEmailDto()
            {
                UpdateEmailToken = res2.Data.UpdateEmailToken
            });
            Assert.AreEqual(200, res3.StatusCode);
        }

        /// <summary>
        /// TODO:修改用户绑定手机号
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task VerifyUpdatePhoneRequestTest()
        {
            var res0 = await client.SendSms(new SendSMSDto()
            {
                Channel = SendSMSDto.channel.CHANNEL_UNBIND_PHONE,
                PhoneNumber = "17665662048"
            });
            Assert.AreEqual(200, res0.StatusCode);
            var res1 = await client.SendSms(new SendSMSDto()
            {
                Channel = SendSMSDto.channel.CHANNEL_UNBIND_PHONE,
                PhoneNumber = "17665662048"
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.VerifyUpdatePhoneRequest(new VerifyUpdatePhoneRequestDto()
            {
                PhonePassCodePayload = new UpdatePhoneByPhonePassCodeDto()
                {
                    NewPhoneNumber = "17665662048",
                    NewPhonePassCode = "5908",
                    OldPhoneNumber = "17665662048",
                    OldPhonePassCode = "2925"
                },
                VerifyMethod = VerifyUpdatePhoneRequestDto.verifyMethod.PHONE_PASSCODE
            });
            Assert.AreEqual(200, res2.StatusCode);
            var res3 = await client.UpdatePhone(new UpdatePhoneDto()
            {
                UpdatePhoneToken = res2.Data.UpdatePhoneToken
            });
            Assert.AreEqual(200, res3.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 忘记密码
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task VerifyResetPasswordRequestTest()
        {
            var res = await client.SendEmail(new SendEmailDto()
            {
                Channel = SendEmailDto.channel.CHANNEL_RESET_PASSWORD,
                Email = "tm574378328@gmail.com"
            });
            Assert.AreEqual(200, res.StatusCode);
            var res2 = await client.VerifyResetPasswordRequest(new VerifyResetPasswordRequestDto
            {
                VerifyMethod = VerifyResetPasswordRequestDto.verifyMethod.EMAIL_PASSCODE,
                EmailPassCodePayload = new ResetPasswordByEmailPassCodeDto()
                {
                    Email = "tm574378328@gmail.com",
                    PassCode = "5167"
                }
            });
            Assert.AreEqual(200, res2.StatusCode);
            var res3 = await client.ResetPassword(new ResetPasswordDto
            {
                Password = "88886666",
                PasswordResetToken = res2.Data.PasswordResetToken,
                PasswordEncryptType = ResetPasswordDto.passwordEncryptType.NONE,
            });
            Assert.AreEqual(200, res3.StatusCode);
        }

        /// <summary>
        /// 2022-10-21 测试成功
        /// 注销账户
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task VeirfyDeleteAccountRequestTest()
        {
            var res1 = await client.VeirfyDeleteAccountRequest(new VerifyDeleteAccountRequestDto()
            {
                VerifyMethod = VerifyDeleteAccountRequestDto.verifyMethod.PASSWORD,
                PasswordPayload = new DeleteAccountByPasswordDto
                {
                    PasswordEncryptType = DeleteAccountByPasswordDto.passwordEncryptType.NONE,
                    Password = "88886666"
                }
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.DeleteAccount(new DeleteAccounDto
            {
                DeleteAccountToken = res1.Data.DeleteAccountToken
            });
            Assert.AreEqual(200, res1.StatusCode);
        }

        /// <summary>
        /// TODO:获取应用公开配置
        /// 自动生成没有此方法
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetApplicationPublicConfig()
        {
            //  var res = await client.GetApplicationPublicConfig();
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 获取服务器公开信息
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetSystemInfoTest()
        {
            var res = await client.GetSystemInfo();
            Assert.IsNotNull(res);
        }

        /// <summary>
        /// 2022-10-19 测试失败
        /// 获取国家列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetCountryListTest()
        {
            var res = await client.GetCountryList();
            Assert.IsNotNull(res);
        }

        /// <summary>
        /// 2022-10-19 测试失败
        /// 预检验验证码是否正确
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task PreCheckCodeTest()
        {
            var res = await client.PreCheckCode(new PreCheckCodeDto
            {
                CodeType = PreCheckCodeDto.codeType.EMAIL,
                EmailCodePayload =
                {
                    Channel = PreCheckEmailCodeDto.channel.CHANNEL_VERIFY_EMAIL_LINK,
                    Email = "574378328@qq.com",
                    PassCode = ""
                }
            });
            Assert.AreEqual(200, res.StatusCode);
        }
    }
}
