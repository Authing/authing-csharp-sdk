using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Models.Management
{
    /// <summary>
    /// 初始化 Client 的配置
    /// </summary>
    public class ManagementClientOptions
    {
        /// <summary>
        /// 用户池 ID
        /// </summary>
        public string AccessKeyId { get; set; }
        /// <summary>
        /// 用户池密钥
        /// </summary>
        public string AccessKeySecret { get; set; }
        /// <summary>
        /// 超时时间，默认为 1000 ms
        /// </summary>
        public int Timeout { get; set; } = 10000;
        /// <summary>
        /// Host 地址，默认为 https://core.authing.cn
        /// </summary>
        public string Host { get; set; } = "https://core.authing.cn";
        /// <summary>
        /// 返回的内容语言，默认为中文
        /// </summary>
        public ClientLang Lang { get; set; } = ClientLang.CN;
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
