using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Models
{
    public class GetDepartmentListResDto
    {
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
        [JsonProperty("apiCode")]
        public string ApiCode { get; set; }
        public GetDepartmentListRes Data { get; set; }
    }

    public class GetDepartmentListRes
    {
        public int totalCount { get; set; }
        public List<Department> list { get; set; }
    }

    public class Department
    {
        /// <summary>
        /// 组织 Code
        /// </summary>
        public string OrganizationCode { get; set; }
        /// <summary>
        /// 部门 ID
        /// </summary>
        public string DepartmentId { get; set; }
        /// <summary>
        /// 部门创建时间
        /// </summary>
        public string CreatedAt { get; set; }
        /// <summary>
        /// 部门名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 部门描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 自定义部门 ID，用来存储自定义的 ID
        /// </summary>
        public string OpenDepartmentId { get; set; }
        /// <summary>
        /// 是否是部门 Leader
        /// </summary>
        public bool IsLeader { get; set; }
        /// <summary>
        /// 部门识别码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 是否是主部门
        /// </summary>
        public bool IsMainDepartment { get; set; }
        /// <summary>
        /// 加入部门时间
        /// </summary>
        public DateTime JoinedAt { get; set; }
        /// <summary>
        /// 是否是虚拟部门
        /// </summary>
        public bool IsVirtualNode { get; set; }
        /// <summary>
        /// 多语言设置
        /// </summary>
        public I18n I18n { get; set; }
        /// <summary>
        /// 部门的扩展字段数据
        /// </summary>
        public object CustomData { get; set; }
    }

    public class I18n
    {
        public Name name { get; set; }
    }

    public class Name
    {
        [JsonProperty("zh-CN")]
        public ZhCN zhCN { get; set; }
        [JsonProperty("en-US")]
        public EnUS enUS { get; set; }
        [JsonProperty("zh-TW")]
        public ZhTw ZhUs { get; set; }
    }

    public class ZhCN
    {
        /// <summary>
        /// 是否已开启。若开启，且控制台选择该语言，则展示该内容。（默认关闭）
        /// </summary>
        public bool enabled { get; set; }
        /// <summary>
        /// 多语言内容
        /// </summary>
        public string value { get; set; }
    }

    public class EnUS
    {
        /// <summary>
        /// 是否已开启。若开启，且控制台选择该语言，则展示该内容。（默认关闭）
        /// </summary>
        public bool enabled { get; set; }
        /// <summary>
        /// 多语言内容
        /// </summary>
        public string value { get; set; }
    }

    public class ZhTw
    {
        /// <summary>
        /// 是否已开启。若开启，且控制台选择该语言，则展示该内容。（默认关闭）
        /// </summary>
        public bool enabled { get; set; }
        /// <summary>
        /// 多语言内容
        /// </summary>
        public string value { get; set; }
    }
}
