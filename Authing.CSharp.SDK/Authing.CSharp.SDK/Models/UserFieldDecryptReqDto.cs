using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Authing.CSharp.SDK.Models
{
    /// <summary>
    /// UserFieldDecryptReqDto 的模型
    /// </summary>
    public partial class UserFieldDecryptReqDto
    {
        /// <summary>
        ///  用户需要解密的属性列表
        /// </summary>
        [JsonProperty("data")]
        public List<UserFieldDecryptReqItemDto>  Data {get;set;}
        /// <summary>
        ///  私钥，通过控制台安全设置-数据安全-数据加密获取
        /// </summary>
        [JsonProperty("privateKey")]
        public string  PrivateKey {get;set;}
    }
}