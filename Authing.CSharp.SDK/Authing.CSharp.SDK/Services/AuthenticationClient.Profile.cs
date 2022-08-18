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
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        public async Task<UserSingleRespDto> GetProfile()
        {
            string json = await GetAsync("/api/v3/get-profile", string.Empty,AccessToken);

            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(json);

            return result;
        }

        /// <summary>
        /// 修改用户资料
        /// </summary>
        /// <param name="updateUserReqDto"></param>
        /// <returns></returns>
        public async Task<UserSingleRespDto> UpdateProfile(UpdateUserReqDto updateUserReqDto)
        {
            string json = await PostFormAsync("/api/v3/update-profile", updateUserReqDto, AccessToken);

            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(json);

            return result;
        }

        /// <summary>
        /// 绑定邮箱
        /// </summary>
        /// <param name="bindEmailDto"></param>
        /// <returns></returns>
        public async Task<IsSuccessRespDto> BindEmail(BindEmailDto bindEmailDto)
        {
            string json = await PostFormAsync("/api/v3/bind-email", bindEmailDto, AccessToken);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(json);
            return result;
        }

        /// <summary>
        /// 绑定电话
        /// </summary>
        /// <param name="bindPhoneDto"></param>
        /// <returns></returns>
        public async Task<IsSuccessRespDto> BindPhone(BindPhoneDto bindPhoneDto)
        {
            string json = await PostFormAsync("/api/v3/bind-phone", bindPhoneDto, AccessToken);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(json);
            return result;
        }

        /// <summary>
        /// 获取我的密码强度和账号安全等级评分
        /// </summary>
        /// <returns></returns>
        public async Task<GetSecurityInfoRespDto> GetSecurityInfo()
        {
            string json = await GetAsync("/api/v3/get-security-info", string.Empty);

            GetSecurityInfoRespDto result = m_JsonService.DeserializeObject<GetSecurityInfoRespDto>(json);
            return result;
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="updatePasswordDto"></param>
        /// <returns></returns>
        public async Task<IsSuccessRespDto> UpdatePassword(UpdatePasswordDto updatePasswordDto)
        {
            string json = await PostFormAsync("/api/v3/update-password", updatePasswordDto, AccessToken);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(json);
            return result;
        }

        /// <summary>
        /// 验证修改邮箱请求
        /// </summary>
        /// <param name="updateEmailVerifyDto"></param>
        /// <returns></returns>
        public async Task<UpdateEmailVerifyRespDto> VerifyUpdateEmailRequest(UpdateEmailVerifyDto updateEmailVerifyDto)
        {
            string json = await PostFormAsync("/api/v3/veirfy-update-email-request", updateEmailVerifyDto, AccessToken);

            UpdateEmailVerifyRespDto result = m_JsonService.DeserializeObject<UpdateEmailVerifyRespDto>(json);
            return result;
        }

        /// <summary>
        /// 修改邮箱
        /// </summary>
        /// <param name="updateEmailDto"></param>
        /// <returns></returns>
        public async Task<IsSuccessRespDto> UpdateEmail(UpdateEmailDto updateEmailDto)
        {
            string json = await PostFormAsync("/api/v3/update-email", updateEmailDto, AccessToken);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(json);
            return result;
        }

        /// <summary>
        /// 验证修改手机号请求
        /// </summary>
        /// <param name="updatePhoneVerifyDto"></param>
        /// <returns></returns>
        public async Task<UpdateTokenVerifyRespDto> VerifyUpdatePhoneRequest(UpdatePhoneVerifyDto updatePhoneVerifyDto)
        {
            string json = await PostFormAsync("/api/v3/veirfy-update-phone-request", updatePhoneVerifyDto, AccessToken);

            UpdateTokenVerifyRespDto result = m_JsonService.DeserializeObject<UpdateTokenVerifyRespDto>(json);
            return result;
        }


        /// <summary>
        /// 修改手机号
        /// </summary>
        /// <param name="updatePhoneDto"></param>
        /// <returns></returns>
        public async Task<IsSuccessRespDto> UpdatePhone(UpdatePhoneDto updatePhoneDto)
        {
            string json = await PostFormAsync("/api/v3/update-phone", updatePhoneDto, AccessToken);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(json);
            return result;
        }

        /// <summary>
        /// 验证重置密码
        /// </summary>
        /// <param name="resetPasswordVerifyDto"></param>
        /// <returns></returns>
        public async Task<PasswordResetVerifyRespDto> VerifyResetPasswordRequest(ResetPasswordVerifyDto resetPasswordVerifyDto)
        {
            string json = await PostFormAsync("/api/v3/verify-reset-password-request", resetPasswordVerifyDto,AccessToken);

            PasswordResetVerifyRespDto result = m_JsonService.DeserializeObject<PasswordResetVerifyRespDto>(json);
            return result;
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <param name="resetPasswordDto"></param>
        /// <returns></returns>
        public async Task<IsSuccessRespDto> ResetPassword(ResetPasswordDto resetPasswordDto)
        {
            string json = await PostFormAsync("/api/v3/reset-password", resetPasswordDto, AccessToken);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(json);
            return result;
        }

        /// <summary>
        /// 验证注销账号
        /// </summary>
        /// <param name="deleteAccountVerifyDto"></param>
        /// <returns></returns>
        public async Task<DeleteAccountVerifyRespDto> VerifyDeleteAccountRequest(DeleteAccountVerifyDto deleteAccountVerifyDto)
        {
            string json = await PostFormAsync("/api/v3/verify-delete-account-request", deleteAccountVerifyDto, AccessToken);

            DeleteAccountVerifyRespDto result = m_JsonService.DeserializeObject<DeleteAccountVerifyRespDto>(json);
            return result;
        }

        /// <summary>
        /// 注销账户
        /// </summary>
        /// <param name="deleteAccounDto"></param>
        /// <returns></returns>
        public async Task<IsSuccessRespDto> DeleteAccount(DeleteAccounDto deleteAccounDto)
        {
            string json = await PostFormAsync("/api/v3/delete-account", deleteAccounDto, AccessToken);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(json);
            return result;
        }

    }
}
