using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
   public class SystemInformation
    {
        /// <summary>
        /// RSA256 加密配置信息
        /// </summary>
        public Rsa Rsa { get; set; }
        /// <summary>
        /// 国密 SM2 加密配置信息
        /// </summary>
        public Sm2 Sm2 { get; set; }
        /// <summary>
        /// Authing 版本信息
        /// </summary>
        public Version Version { get; set; }
       /// <summary>
       /// Authing 服务对外 IP 列表
       /// </summary>
        public List<string> PublicIps { get; set; }
    }

    public class Rsa
    {
        /// <summary>
        /// RAS256 公钥
        /// </summary>
        public string PublicKey { get; set; }
    }

    public class Sm2
    {
        /// <summary>
        /// SM2 公钥
        /// </summary>
        public string PublicKey { get; set; }
    }

    public class Version
    {
        /// <summary>
        /// Authing 核心服务版本号
        /// </summary>
        public string Server { get; set; }
        /// <summary>
        /// Authing 控制台版本号
        /// </summary>
        public string Console { get; set; }
        /// <summary>
        /// Authing 托管登录页版本号
        /// </summary>
        public string Login { get; set; }
    }

}
