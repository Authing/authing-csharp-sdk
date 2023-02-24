using Jose;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Models.Authentication
{
    /// <summary>
    /// 认证 SDK 初始化参数
    /// </summary>
    public class AuthenticationClientInitOptions
    {
        /// <summary>
        /// 用户登陆后，通过认证后获取到的 AccessToken
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// 请求超时时间，单位为毫秒，默认为 10000，10秒
        /// </summary>
        public int TimeOut { get; set; } = 10 * 1000;
        /// <summary>
        /// 应用 ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 应用 Secret
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// 应用对应的用户池域名，例如 pool.authing.cn 
        /// </summary>
        public string AppHost { get; set; }

        /// <summary>
        /// 认证完成后的重定向目标 URL 
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        /// 登出完成后的重定向目标 URL
        /// </summary>
        public string LogoutRedirectUri { get; set; }
        /// <summary>
        /// 应用侧向 Authing 请求的权限，以空格分隔，默认为 'openid profile'
        ///  成功获取的权限会出现在 Access Token 的 scope 字段中
        ///  一些示例：
        /// - openid: OIDC 标准规定的权限，必须包含
        /// - profile: 获取用户的基本身份信息
        /// - offline_access: 获取用户的 Refresh Token，可用于调用 refreshLoginState 刷新用户的登录态
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// 服务端的 JWKS 公钥，用于验证 Token 签名，默认会通过网络请求从服务端的 JWKS 端点自动获取
        /// </summary>
        public JwkSet ServerJWKS { get; set; }

        /// <summary>
        /// 存储认证上下文的 Cookie 名称
        /// </summary>
        public string CookieKey { get; set; }

        /// <summary>
        /// Authing 服务器地址，默认为 https://core.authing.cn
        /// </summary>

        public string Host { get; set; }

        /// <summary>
        /// 应用身份协议
        /// </summary>
        public Protocol Protocol { get; set; } = Protocol.OIDC;

        public TokenEndPointAuthMethod TokenEndPointAuthMethod { get; set; } =
            TokenEndPointAuthMethod.CLIENT_SECRET_POST;

        public TokenEndPointAuthMethod IntrospectionEndPointAuthMethod { get; set; } =
            TokenEndPointAuthMethod.CLIENT_SECRET_POST;

        public TokenEndPointAuthMethod RevocationEndPointAuthMethod { get; set; } =
            TokenEndPointAuthMethod.CLIENT_SECRET_POST;

        /// <summary>
        /// 返回的内容语言，默认为中文
        /// </summary>
        public ClientLang Lang { get; set; } = ClientLang.CN;

        /// <summary>
        /// 是否拒绝非法的 HTTPS 请求，默认为 true；如果是私有化部署的场景且证书不被信任，可以设置为 false
        /// </summary>
        public bool rejectUnauthorized { get; set; } = true;

        /// <summary>
        /// 订阅事件地址
        /// </summary>
        public string WebsocketUri { get; set; } 
    }

    /// <summary>
    /// 返回内容的枚举
    /// </summary>
    public enum ClientLang
    {
        /// <summary>
        /// 中文
        /// </summary>
        [Description("zh-CN")]
        CN,
        /// <summary>
        /// 英文
        /// </summary>
        [Description("en-US")]
        US
    }
}
