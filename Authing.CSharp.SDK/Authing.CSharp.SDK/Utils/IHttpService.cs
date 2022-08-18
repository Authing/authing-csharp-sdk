using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.IServices
{
    public interface IHttpService
    {
        /// <summary>
        /// Get 请求
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="apiPath"></param>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="bearerToken">临时 Token，只这一次</param>
        /// <returns></returns>
        Task<string> GetAsync(string baseUrl, string apiPath, Dictionary<string, string> param, CancellationToken cancellationToken, string bearerToken = null);

        /// <summary>
        /// Post 请求
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="apiPath"></param>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="bearerToken">临时 Token，只这一次</param>
        /// <returns></returns>
        Task<string> PostAsync(string baseUrl, string apiPath, Dictionary<string, string> param, CancellationToken cancellationToken, string bearerToken = null);

        /// <summary>
        ///  Post 请求
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="apiPath"></param>
        /// <param name="jsonParam"></param>
        /// <param name="cancellationToken"></param>
        /// <param name="bearerToken"></param>
        /// <returns></returns>
        Task<string> PostAsync(string baseUrl, string apiPath, string jsonParam, CancellationToken cancellationToken, string bearerToken = null);

        /// <summary>
        /// 设置Token，以后每次请求都带这个token
        /// </summary>
        /// <param name="token"></param>
        void SetBearerToken(string token);

        /// <summary>
        /// 向请求的 Header 添加键值对
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void SetHeader(string key, string value);
    }
}
