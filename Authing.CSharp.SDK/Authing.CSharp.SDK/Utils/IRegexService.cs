
namespace Authing.CSharp.SDK.Utils
{
    /// <summary>
    /// 正则表达式服务接口
    /// </summary>
    public interface IRegexService
    {
        /// <summary>
        /// 域名标准化 domain canonicalization
        /// </summary>
        /// <param name="domain">域名</param>
        /// <returns>标准化后的域名</returns>
        string DomainC14n(string domain);
       
    }
}
