using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Authing.CSharp.SDK.Models.Management;

namespace Authing.CSharp.SDK.Models.Management
{
    /// <summary>
    /// AdminAuditLogDto 的模型
    /// </summary>
    public partial class AdminAuditLogDto
    {
        /// <summary>
        ///  管理员的用户 ID
        /// </summary>
        [JsonProperty("adminUserId")]
        public string AdminUserId { get; set; }
        /// <summary>
        ///  管理员用户头像
        /// </summary>
        [JsonProperty("adminUserAvatar")]
        public string AdminUserAvatar { get; set; }
        /// <summary>
        ///  管理员用户显示名称，按照以下用户字段顺序进行展示：nickname > username > name > givenName > familyName -> email -> phone -> id
        /// </summary>
        [JsonProperty("adminUserDisplayName")]
        public string AdminUserDisplayName { get; set; }
        /// <summary>
        ///  客户端 IP，可根据登录时的客户端 IP 进行筛选。默认不传获取所有登录 IP 的登录历史。
        /// </summary>
        [JsonProperty("clientIp")]
        public string ClientIp { get; set; }
        /// <summary>
        ///  操作类型：
        /// - `create`: 创建
        /// - `delete`: 删除
        /// - `import`: 导入
        /// - `export`: 导出
        /// - `update`: 修改
        /// - `refresh`: 刷新
        /// - `sync`: 同步
        /// - `invite`: 邀请
        /// - `resign`: 离职
        /// - `recover`: 恢复
        /// - `disable`: 禁用
        /// - `userEnable`: 启用
        /// 
        /// </summary>
        [JsonProperty("operationType")]
        public operationType OperationType { get; set; }
        /// <summary>
        ///  事件类型：
        /// - `user`: 用户
        /// - `userpool`: 用户池
        /// - `tenant`: 租户
        /// - `userLoginState`: 用户登录态
        /// - `userAccountState`: 用户账号状态
        /// - `userGroup`: 用户分组
        /// - `fieldEncryptState`: 字段加密状态
        /// - `syncTask`: 同步任务
        /// - `socialConnection`: 社会化身份源
        /// - `enterpriseConnection`: 社会化身份源
        /// - `customDatabase`: 自定义数据库
        /// - `org`: 组织机构
        /// - `cooperator`: 协作管理员
        /// - `application`: 应用
        /// - `resourceNamespace`: 权限分组
        /// - `resource`: 资源
        /// - `role`: 角色
        /// - `roleAssign`: 角色授权
        /// - `policy`: 策略
        /// 
        /// </summary>
        [JsonProperty("resourceType")]
        public resourceType ResourceType { get; set; }
        /// <summary>
        ///  事件详情
        /// </summary>
        [JsonProperty("eventDetail")]
        public string EventDetail { get; set; }
        /// <summary>
        ///  具体的操作参数
        /// </summary>
        [JsonProperty("operationParam")]
        public string OperationParam { get; set; }
        /// <summary>
        ///  原始值
        /// </summary>
        [JsonProperty("originValue")]
        public string OriginValue { get; set; }
        /// <summary>
        ///  新值
        /// </summary>
        [JsonProperty("targetValue")]
        public string TargetValue { get; set; }
        /// <summary>
        ///  是否成功
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
        /// <summary>
        ///  User Agent
        /// </summary>
        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }
        /// <summary>
        ///  解析过后的 User Agent
        /// </summary>
        [JsonProperty("parsedUserAgent")]
        public ParsedUserAgent ParsedUserAgent { get; set; }
        /// <summary>
        ///  地理位置
        /// </summary>
        [JsonProperty("geoip")]
        public GeoIp Geoip { get; set; }
        /// <summary>
        ///  时间
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        /// <summary>
        ///  请求 ID
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }
    public partial class AdminAuditLogDto
    {
        /// <summary>
        ///  操作类型：
        /// - `create`: 创建
        /// - `delete`: 删除
        /// - `import`: 导入
        /// - `export`: 导出
        /// - `update`: 修改
        /// - `refresh`: 刷新
        /// - `sync`: 同步
        /// - `invite`: 邀请
        /// - `resign`: 离职
        /// - `recover`: 恢复
        /// - `disable`: 禁用
        /// - `userEnable`: 启用
        /// 
        /// </summary>
        public enum operationType
        {
            [EnumMember(Value = "all")]
            ALL,
            [EnumMember(Value = "create")]
            CREATE,
            [EnumMember(Value = "delete")]
            DELETE,
            [EnumMember(Value = "import")]
            IMPORT,
            [EnumMember(Value = "export")]
            EXPORT,
            [EnumMember(Value = "update")]
            UPDATE,
            [EnumMember(Value = "refresh")]
            REFRESH,
            [EnumMember(Value = "sync")]
            SYNC,
            [EnumMember(Value = "invite")]
            INVITE,
            [EnumMember(Value = "resign")]
            RESIGN,
            [EnumMember(Value = "recover")]
            RECOVER,
            [EnumMember(Value = "disable")]
            DISABLE,
            [EnumMember(Value = "userEnable")]
            USER_ENABLE,
            [EnumMember(Value = "activate")]
            ACTIVATE,
            [EnumMember(Value = "deactivate")]
            DEACTIVATE,
        }
        /// <summary>
        ///  事件类型：
        /// - `user`: 用户
        /// - `userpool`: 用户池
        /// - `tenant`: 租户
        /// - `userLoginState`: 用户登录态
        /// - `userAccountState`: 用户账号状态
        /// - `userGroup`: 用户分组
        /// - `fieldEncryptState`: 字段加密状态
        /// - `syncTask`: 同步任务
        /// - `socialConnection`: 社会化身份源
        /// - `enterpriseConnection`: 社会化身份源
        /// - `customDatabase`: 自定义数据库
        /// - `org`: 组织机构
        /// - `cooperator`: 协作管理员
        /// - `application`: 应用
        /// - `resourceNamespace`: 权限分组
        /// - `resource`: 资源
        /// - `role`: 角色
        /// - `roleAssign`: 角色授权
        /// - `policy`: 策略
        /// 
        /// </summary>
        public enum resourceType
        {
            [EnumMember(Value = "all")]
            ALL,
            [EnumMember(Value = "user")]
            USER,
            [EnumMember(Value = "userpool")]
            USERPOOL,
            [EnumMember(Value = "tenant")]
            TENANT,
            [EnumMember(Value = "userLoginState")]
            USER_LOGIN_STATE,
            [EnumMember(Value = "userAccountState")]
            USER_ACCOUNT_STATE,
            [EnumMember(Value = "userGroup")]
            USER_GROUP,
            [EnumMember(Value = "fieldEncryptState")]
            FIELD_ENCRYPT_STATE,
            [EnumMember(Value = "syncTask")]
            SYNC_TASK,
            [EnumMember(Value = "socialConnection")]
            SOCIAL_CONNECTION,
            [EnumMember(Value = "enterpriseConnection")]
            ENTERPRISE_CONNECTION,
            [EnumMember(Value = "customDatabase")]
            CUSTOM_DATABASE,
            [EnumMember(Value = "org")]
            ORG,
            [EnumMember(Value = "cooperator")]
            COOPERATOR,
            [EnumMember(Value = "application")]
            APPLICATION,
            [EnumMember(Value = "resourceNamespace")]
            RESOURCE_NAMESPACE,
            [EnumMember(Value = "resource")]
            RESOURCE,
            [EnumMember(Value = "role")]
            ROLE,
            [EnumMember(Value = "roleAssign")]
            ROLE_ASSIGN,
            [EnumMember(Value = "policy")]
            POLICY,
        }
    }
}