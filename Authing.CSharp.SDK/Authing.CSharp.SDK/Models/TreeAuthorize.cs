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
    /// TreeAuthorize 的模型
    /// </summary>
    public partial class TreeAuthorize
    {
        /// <summary>
        ///  树资源授权列表
        /// </summary>
        [JsonProperty("authList")]
        public List<TreeAuthBo>  AuthList {get;set;}
    }
}