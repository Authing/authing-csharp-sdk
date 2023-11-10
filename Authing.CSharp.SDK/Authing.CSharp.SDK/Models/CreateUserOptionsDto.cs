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
    /// CreateUserOptionsDto 的模型
    /// </summary>
    public partial class CreateUserOptionsDto
    {
        /// <summary>
        ///  该参数一般在迁移旧有用户数据到 Authing 的时候会设置。开启这个开关，password 字段会直接写入 Authing 数据库，Authing 不会再次加密此字段。如果你的密码不是明文存储，你应该保持开启，并编写密码函数计算。
        /// </summary>
        [JsonProperty("keepPassword")]
        public bool  KeepPassword {get;set;}
        /// <summary>
        ///  是否自动生成密码
        /// </summary>
        [JsonProperty("autoGeneratePassword")]
        public bool  AutoGeneratePassword {get;set;}
        /// <summary>
        ///  是否强制要求用户在第一次的时候重置密码
        /// </summary>
        [JsonProperty("resetPasswordOnFirstLogin")]
        public bool  ResetPasswordOnFirstLogin {get;set;}
        /// <summary>
        ///  此次调用中使用的父部门 ID 的类型
        /// </summary>
        [JsonProperty("departmentIdType")]
        public departmentIdType  DepartmentIdType {get;set;}
        /// <summary>
        ///  重置密码发送邮件和手机号选项
        /// </summary>
        [JsonProperty("sendNotification")]
        public SendCreateAccountNotificationDto  SendNotification {get;set;}
        /// <summary>
        ///  密码加密类型，支持使用 RSA256 和国密 SM2 算法进行加密。默认为 `none` 不加密。
/// - `none`: 不对密码进行加密，使用明文进行传输。
/// - `rsa`: 使用 RSA256 算法对密码进行加密，需要使用 Authing 服务的 RSA 公钥进行加密，请阅读**介绍**部分了解如何获取 Authing 服务的 RSA256 公钥。
/// - `sm2`: 使用 [国密 SM2 算法](https://baike.baidu.com/item/SM2/15081831) 对密码进行加密，需要使用 Authing 服务的 SM2 公钥进行加密，请阅读**介绍**部分了解如何获取 Authing 服务的 SM2 公钥。
/// 
        /// </summary>
        [JsonProperty("passwordEncryptType")]
        public passwordEncryptType  PasswordEncryptType {get;set;}
    }
    public partial class CreateUserOptionsDto
    {
        /// <summary>
        ///  此次调用中使用的父部门 ID 的类型
        /// </summary>
        public enum departmentIdType
        {
            [EnumMember(Value="department_id")]
            DEPARTMENT_ID,
            [EnumMember(Value="open_department_id")]
            OPEN_DEPARTMENT_ID,
            [EnumMember(Value="sync_relation")]
            SYNC_RELATION,
            [EnumMember(Value="custom_field")]
            CUSTOM_FIELD,
            [EnumMember(Value="code")]
            CODE,
        }
        /// <summary>
        ///  密码加密类型，支持使用 RSA256 和国密 SM2 算法进行加密。默认为 `none` 不加密。
/// - `none`: 不对密码进行加密，使用明文进行传输。
/// - `rsa`: 使用 RSA256 算法对密码进行加密，需要使用 Authing 服务的 RSA 公钥进行加密，请阅读**介绍**部分了解如何获取 Authing 服务的 RSA256 公钥。
/// - `sm2`: 使用 [国密 SM2 算法](https://baike.baidu.com/item/SM2/15081831) 对密码进行加密，需要使用 Authing 服务的 SM2 公钥进行加密，请阅读**介绍**部分了解如何获取 Authing 服务的 SM2 公钥。
/// 
        /// </summary>
        public enum passwordEncryptType
        {
            [EnumMember(Value="sm2")]
            SM2,
            [EnumMember(Value="rsa")]
            RSA,
            [EnumMember(Value="none")]
            NONE,
        }
    }
}