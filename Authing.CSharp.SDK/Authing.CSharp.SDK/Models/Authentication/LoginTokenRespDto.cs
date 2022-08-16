using Authing.CSharp.SDK.Models.Authentication;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class LoginTokenRespDto
    {
        /// <summary>
        /// 业务状态码，可以通过此状态码判断操作是否成功，200 表示成功
        /// </summary>
        [JsonProperty("statusCode")]
        public long StatusCode { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 细分错误码，可通过此错误码得到具体的错误类型
        /// </summary>
        [JsonProperty("apicode")]
        public long ApiCode { get; set; }

        [JsonProperty("data")]
        public LoginTokenResp Data { get; set; }
    }

    public class LoginTokenResp
    {
        //[JsonProperty("userId")]
        //public string UserId { get; set; }

        //[JsonProperty("createdAt")]
        //public string CreatedAt { get; set; }

        //[JsonProperty("updatedAt")]
        //public string updatedAt { get; set; }

        //[JsonProperty("status")]
        //public Status Status { get; set; }

        //public string Email { get; set; }

        //public string Phone { get; set; }
        //public string PhoneCountryCode { get; set; }

        //public string UserName { get; set; }
        //public string Name { get; set; }
        //public string NickName { get; set; }
        //public string Photo { get; set;  }
        //public int LoginCount { get; set; }
        //public string LastLogin { get; set; }
        //public string LastIp { get;set; }
        //public Gender Gender { get; set; }
        //public bool EmailVerified { get; set; }
        //public bool PhoneVerified { get; set; }
        //public string PasswordLastSetAt { get; set; }
        //public string BirthDate { get; set; }
        //public string Country { get; set; }
        //public string Province { get; set; }
        //public string City { get; set; }
        //public string Address { get; set; }
        //public string StreetAddress { get; set; }
        //public string PostalCode { get; set; }
        //public string ExternalId { get; set; }

        //public bool ResetPasswordOnNextLogin { get; set; }
        //public List<string > DepartmentIds { get; set; }

        //public List<IdentityDto> Identities { get; set; } 

        //public object CustomData { get; set; }

        //public string StatusChangedAt { get; set; }

        /// <summary>
        /// 接口调用凭据，在限制时间内被授权访问资源 API
        /// </summary>
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 用户的身份凭证，解析后会包含用户信息
        /// </summary>
        [JsonProperty("id_token")]
        public string IdToken { get; set; }

        /// <summary>
        /// refresh_token 用于获取新的 AccessToken
        /// </summary>
        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// token 类型
        /// </summary>
        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// 过期时间 单位是秒
        /// </summary>
        [JsonProperty("expire_in")]
        public string ExpireIn { get; set; }
    }

    public enum Status
    {
        Suspended,
        Resigned,
        Activated,
        Archived
    }
    




}
