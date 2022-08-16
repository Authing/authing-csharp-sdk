namespace Authing.CSharp.SDK.Models.Authentication
{
    public enum EmailChannel
    {
        /// <summary>
        /// 登录
        /// </summary>
        CHANNEL_LOGIN, 
        /// <summary>
        /// 注册
        /// </summary>
        CHANNEL_REGISTER, 
        /// <summary>
        /// 重置密码
        /// </summary>
        CHANNEL_RESET_PASSWORD, 
        /// <summary>
        /// 验证邮箱
        /// </summary>
        CHANNEL_VERIFY_EMAIL_LINK, 
        /// <summary>
        /// 绑定邮箱
        /// </summary>
        CHANNEL_BIND_EMAIL, 
        /// <summary>
        /// 解绑邮箱
        /// </summary>
        CHANNEL_UNBIND_EMAIL,
        /// <summary>
        /// 验证 MFA
        /// </summary>
        CHANNEL_VERIFY_MFA,
        /// <summary>
        /// 解锁账户
        /// </summary>
        CHANNEL_UNLOCK_ACCOUNT, 
        /// <summary>
        /// 
        /// </summary>
        CHANNEL_COMPLETE_EMAIL 
    }
}