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
            string json = await PostAsync("/api/v3/update-profile", updateUserReqDto, AccessToken);

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
            string json = await PostAsync("/api/v3/bind-email", bindEmailDto, AccessToken);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(json);
            return result;
        }
    }
}
