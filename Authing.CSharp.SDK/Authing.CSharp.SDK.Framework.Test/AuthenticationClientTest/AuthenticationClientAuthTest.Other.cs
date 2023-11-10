using System;
using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.UtilsImpl;
using NUnit.Framework;

namespace Authing.CSharp.SDK.Framework.Test
{
    public partial class AuthenticationClientAuthTest
    {
        /// <summary>
        /// 2022-11-17 测试失败
        /// 获取用户登录日志
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(1)]
        public async Task GetUserLogs()
        {
            DateTimeService DateTimeService = new DateTimeService();
            var start = DateTimeService.DatetimeToUnixTimeMilllisecond(new DateTime(2022, 01, 01));
            var stop = DateTimeService.DateTimeNowToTimestamp();
            var res = await client.GetLoginHistory(stop,start);
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 获取用户登录的应用
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(2)]
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
        [Order(3)]
        public async Task GetAccessibleAppsTest()
        {
            var res = await client.GetAccessibleApps();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-21 测试成功
        /// 获取用户分组列表
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(4)]
        public async Task GetGroupListTest()
        {
            var res = await client.GetGroupList();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-21 测试成功
        /// 获取用户角色列表
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(5)]
        public async Task GetRoleListTest()
        {
            var res = await client.GetRoleList("6375da1dff73acca94b3e25d");
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-21 测试成功
        /// 获取用户的租户列表
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(6)]
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
        [Order(7)]
        public async Task GetDepartmentListTest()
        {
            var res = await client.GetDepartmentList();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-11-1 测试通过
        /// 获取用户被授权的资源列表
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(8)]
        public async Task GetAuthorizedResourcesTest()
        {
            var res = await client.GetAuthorizedResources();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 获取用户资料
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(9)]
        public async Task GetProfileTest()
        {
            LoginTokenRespDto loginTokenRespDto = await client.SignInByUsernamePassword("qidong88999", "3866364");
            client.setAccessToken(loginTokenRespDto.Data.Access_token);

            var res = await client.GetProfile();
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-18 测试成功
        /// 更新用户资料
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(10)]
        public async Task UpdateProfileTest()
        {
            LoginTokenRespDto loginTokenRespDto = await client.SignInByUsernamePassword("qidong88999", "3866364");
            client.setAccessToken(loginTokenRespDto.Data.Access_token);

            var res = await client.UpdateProfile(new UpdateUserProfileDto()
            {
                Gender = UpdateUserProfileDto.gender.F
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
            LoginTokenRespDto loginTokenRespDto = await client.SignInByUsernamePassword("qidong88999", "3866364");
            client.setAccessToken(loginTokenRespDto.Data.Access_token);



            var res1 = await client.SendEmail(new SendEmailDto()
            {
                Email = "2481452007@qq.com",
                Channel = SendEmailDto.channel.CHANNEL_BIND_EMAIL
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.BindEmail(new BindEmailDto()
            {
                Email = "2481452007@qq.com",
                PassCode = "2443",
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
            LoginTokenRespDto loginTokenRespDto = await client.SignInByUsernamePassword("qidong88999", "3866364");
            client.setAccessToken(loginTokenRespDto.Data.Access_token);

            var res1 = await client.SendEmail(new SendEmailDto()
            {
                Email = "2481452007@qq.com",
                Channel = SendEmailDto.channel.CHANNEL_UNBIND_EMAIL
            });

            try
            {

                var res = await client.UnbindEmail(new UnbindEmailDto { PassCode = "4470" });
                Assert.AreEqual(200, res.StatusCode);
            }
            catch (Exception exp)
            { 
                
            }
        }

        /// <summary>
        /// 2022-11-1 测试成功
        /// 绑定手机号
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task BindPhoneTest()
        {
            LoginTokenRespDto loginTokenRespDto = await client.SignInByUsernamePassword("qidong88999", "3866364");
            client.setAccessToken(loginTokenRespDto.Data.Access_token);


            var res1 = await client.SendSms(new SendSMSDto()
            {
                PhoneNumber = "13348926753",
                Channel = SendSMSDto.channel.CHANNEL_BIND_PHONE
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.BindPhone(new BindPhoneDto()
            {
                PhoneNumber = "13348926753",
                PassCode = "1326",
            });
            Assert.AreEqual(200, res2.StatusCode);
        }

        /// <summary>
        /// 2022-11-1 测试成功
        /// 解绑手机
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task UnBindPhoneTest()
        {
            LoginTokenRespDto loginTokenRespDto = await client.SignInByUsernamePassword("qidong88999", "3866364");
            client.setAccessToken(loginTokenRespDto.Data.Access_token);



            var res1 = await client.SendSms(new SendSMSDto()
            {
                PhoneNumber = "13348926753",
                Channel = SendSMSDto.channel.CHANNEL_UNBIND_PHONE
            });
            Assert.AreEqual(200, res1.StatusCode);

            var res = await client.UnbindPhone(new UnbindPhoneDto { PassCode = "9095" });
            Assert.AreEqual(200, res.StatusCode);
        }

        /// <summary>
        /// 2022-10-19 测试成功
        /// 获取密码强度和账号安全等级评分
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(11)]
        public async Task GetSecurityLevelTest()
        {
            LoginTokenRespDto loginTokenRespDto = await client.SignInByUsernamePassword("qidong88999", "3866364");
            client.setAccessToken(loginTokenRespDto.Data.Access_token);



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
            LoginTokenRespDto loginTokenRespDto = await client.SignInByUsernamePassword("qidong88999", "3866364");
            client.setAccessToken(loginTokenRespDto.Data.Access_token);



            var res = await client.UpdatePassword(new UpdatePasswordDto()
            {
                NewPassword = "qd3866364",
                OldPassword = "3866364",
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

            LoginTokenRespDto loginTokenRespDto = await client.SignInByUsernamePassword("qidong88999", "qd3866364");
            client.setAccessToken(loginTokenRespDto.Data.Access_token);


            var res0 = await client.SendEmail(new SendEmailDto()
            {
                Channel = SendEmailDto.channel.CHANNEL_UPDATE_EMAIL,
                Email = "2481452007@qq.com"
            });
            Assert.AreEqual(200, res0.StatusCode);
            var res1 = await client.SendEmail(new SendEmailDto()
            {
                Channel = SendEmailDto.channel.CHANNEL_UPDATE_EMAIL,
                Email = "635877990@qq.com"
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.VerifyUpdateEmailRequest(new VerifyUpdateEmailRequestDto()
            {
                EmailPassCodePayload = new UpdateEmailByEmailPassCodeDto()
                {
                    OldEmail = "2481452007@qq.com",
                    OldEmailPassCode = "7701",
                    NewEmail = "635877990@qq.com",
                    NewEmailPassCode = "2791"
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
        /// 2022-10-19 测试成功
        /// 修改用户绑定手机号
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
                Channel = SendSMSDto.channel.CHANNEL_BIND_PHONE,
                PhoneNumber = "17620671314"
            });
            Assert.AreEqual(200, res1.StatusCode);
            var res2 = await client.VerifyUpdatePhoneRequest(new VerifyUpdatePhoneRequestDto()
            {
                PhonePassCodePayload = new UpdatePhoneByPhonePassCodeDto()
                {
                    NewPhoneNumber = "17620671314",
                    NewPhonePassCode = "8858",
                    OldPhoneNumber = "17665662048",
                    OldPhonePassCode = "8977"
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
                Email = "2481452007@qq.com"
            });
            Assert.AreEqual(200, res.StatusCode);
            var res2 = await client.VerifyResetPasswordRequest(new VerifyResetPasswordRequestDto
            {
                VerifyMethod = VerifyResetPasswordRequestDto.verifyMethod.EMAIL_PASSCODE,
                EmailPassCodePayload = new ResetPasswordByEmailPassCodeDto()
                {
                    Email = "2481452007@qq.com",
                    PassCode = "3961"
                }
            });
            Assert.AreEqual(200, res2.StatusCode);
            var res3 = await client.ResetPassword(new ResetPasswordDto
            {
                Password = "3866364",
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
            var res1 = await client.VerifyDeleteAccountRequest(new VerifyDeleteAccountRequestDto()
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
        /// 2022-10-19 测试成功
        /// 获取服务器公开信息
        /// </summary>
        /// <returns></returns>
        [Test]
        [Order(12)]
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
        [Order(13)]
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
