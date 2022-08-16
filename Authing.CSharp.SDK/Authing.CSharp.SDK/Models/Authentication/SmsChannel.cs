namespace Authing.CSharp.SDK.Models.Authentication
{
    public enum SmsChannel
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
        /// 绑定手机
        /// </summary>
        CHANNEL_BIND_PHONE, 
        /// <summary>
        /// 解绑手机
        /// </summary>
        CHANNEL_UNBIND_PHONE,
        /// <summary>
        /// 绑定 MFA
        /// </summary>
        CHANNEL_BIND_MFA,
        /// <summary>
        /// 验证 MFA-
        /// </summary>
        CHANNEL_VERIFY_MFA,
        /// <summary>
        /// 解绑 MFA
        /// </summary>
        CHANNEL_UNBIND_MFA, 
        /// <summary>
        /// 
        /// </summary>
        CHANNEL_COMPLETE_PHONE, 
        /// <summary>
        /// 
        /// </summary>
        CHANNEL_IDENTITY_VERIFICATION,
        /// <summary>
        /// 删除账户
        /// </summary>
        CHANNEL_DELETE_ACCOUNT 
    }
}