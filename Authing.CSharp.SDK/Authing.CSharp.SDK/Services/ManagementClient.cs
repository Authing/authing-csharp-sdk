using Authing.CSharp.SDK.Extensions;
using Authing.CSharp.SDK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Services
{
    public class ManagementClient : BaseManagementService
    {
        /// <summary>
        /// 初始化管理服务
        /// </summary>
        /// <param name="accessKeyId ">用户池 ID</param>
        /// <param name="accessKeySecret ">用户池密钥</param>
        public ManagementClient(ManagementClientOptions options) : base(options)
        {
        }

        /// <summary>
        /// 订阅事件
        /// </summary>
        /// <param name="eventName">事件名称</param>
        /// <param name="messageCallback">事件回调方法</param>
        /// <param name="errorCallback">事件错误回调方法</param>
        public void Sub(string eventName, Action<string> messageCallback, Action<string> errorCallback)
        {
            BaseSub(eventName, messageCallback, errorCallback);
        }

        /// <summary>
        /// 发布事件
        /// </summary>
        /// <param name="eventcode"></param>
        /// <param name="eventData"></param>
        /// <returns></returns>
        public async Task<IsSuccessRespDto> PubEvent(EventRequestDto eventRequestDto)
        {
            string httpResponse = await Request("POST", "/api/v3/pub-event", eventRequestDto).ConfigureAwait(false);
            IsSuccessRespDto commonResponseDto = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return commonResponseDto;
        }

        ///<summary>
        /// 数据对象高级搜索
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>FunctionModelValueListResDto</returns>
        public async Task<FunctionModelValueListResDto> ListRow(FilterDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/filter", requestBody).ConfigureAwait(false);

            FunctionModelValueListResDto result = m_JsonService.DeserializeObject<FunctionModelValueListResDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取数据对象行信息
        ///</summary>
        /// <param name="modelId">功能 id</param>
        /// <param name="rowId">行 id</param>
        /// <param name="showFieldId">返回结果中是否使用字段 id 作为 key</param>
        ///<returns>FunctionModelValueResDto</returns>
        public async Task<FunctionModelValueResDto> GetRow(GetRowDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/metadata/get-row", reqDto).ConfigureAwait(false);

            FunctionModelValueResDto result = m_JsonService.DeserializeObject<FunctionModelValueResDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 根据属性值获取数据对象行信息
        ///</summary>
        /// <param name="modelId">功能 id</param>
        /// <param name="key">字段 key</param>
        /// <param name="value">字段值</param>
        /// <param name="showFieldId">返回结果中是否使用字段 id 作为 key</param>
        ///<returns>FunctionModelValueResDto</returns>
        public async Task<FunctionModelValueResDto> GetRowByValue(GetRowByValueDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/metadata/get-row-by-value", reqDto).ConfigureAwait(false);

            FunctionModelValueResDto result = m_JsonService.DeserializeObject<FunctionModelValueResDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取行信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>MetadataListResDto</returns>
        public async Task<MetadataListResDto> GetRowBatch(GetRowBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/get-row-batch", requestBody).ConfigureAwait(false);

            MetadataListResDto result = m_JsonService.DeserializeObject<MetadataListResDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 添加行
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>FunctionModelValueResDto</returns>
        public async Task<FunctionModelValueResDto> CreateRow(CreateRowDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/create-row", requestBody).ConfigureAwait(false);

            FunctionModelValueResDto result = m_JsonService.DeserializeObject<FunctionModelValueResDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新行
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>FunctionModelValueResDto</returns>
        public async Task<FunctionModelValueResDto> UpdateRow(UpdateRowDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/update-row", requestBody).ConfigureAwait(false);

            FunctionModelValueResDto result = m_JsonService.DeserializeObject<FunctionModelValueResDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除行
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> RemoveRow(RemoveRowDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/remove-row", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建数据对象
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>FunctionModelResDto</returns>
        public async Task<FunctionModelResDto> CreateModel(CreateFunctionModelDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/create-model", requestBody).ConfigureAwait(false);

            FunctionModelResDto result = m_JsonService.DeserializeObject<FunctionModelResDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取数据对象详情
        ///</summary>
        /// <param name="id">功能 id 可以从控制台页面获取</param>
        ///<returns>FunctionModelResDto</returns>
        public async Task<FunctionModelResDto> GetModel(GetModelDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/metadata/get-model", reqDto).ConfigureAwait(false);

            FunctionModelResDto result = m_JsonService.DeserializeObject<FunctionModelResDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取数据对象列表
        ///</summary>
        ///<returns>FunctionModelListDto</returns>
        public async Task<FunctionModelListDto> ListModel()
        {
            string httpResponse = await Request("GET", "/api/v3/metadata/list-model").ConfigureAwait(false);

            FunctionModelListDto result = m_JsonService.DeserializeObject<FunctionModelListDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 删除数据对象
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> RemoveModel(FunctionModelIdDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/remove-model", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新数据对象
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>FunctionModelResDto</returns>
        public async Task<FunctionModelResDto> UpdateModel(UpdateFunctionModelDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/update-model", requestBody).ConfigureAwait(false);

            FunctionModelResDto result = m_JsonService.DeserializeObject<FunctionModelResDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建数据对象的字段
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>FunctionModelFieldResDto</returns>
        public async Task<FunctionModelFieldResDto> CreateField(CreateFunctionModelFieldDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/create-field", requestBody).ConfigureAwait(false);

            FunctionModelFieldResDto result = m_JsonService.DeserializeObject<FunctionModelFieldResDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新数据对象的字段
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>FunctionModelFieldResDto</returns>
        public async Task<FunctionModelFieldResDto> UpdateField(UpdateFunctionModelFieldDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/update-field", requestBody).ConfigureAwait(false);

            FunctionModelFieldResDto result = m_JsonService.DeserializeObject<FunctionModelFieldResDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除数据对象的字段
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> RemoteField(FunctionModelFieldIdDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/remove-field", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取数据对象字段列表
        ///</summary>
        /// <param name="modelId">功能 id</param>
        ///<returns>FunctionFieldListResDto</returns>
        public async Task<FunctionFieldListResDto> ListField(ListFieldDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/metadata/list-field", reqDto).ConfigureAwait(false);

            FunctionFieldListResDto result = m_JsonService.DeserializeObject<FunctionFieldListResDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 导出全部数据
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> ExportMeatdata(ExportModelDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/export", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 导入数据
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> ImportMetadata(ImportModelDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/import", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取导入模板
        ///</summary>
        /// <param name="modelId">功能 id</param>
        ///<returns>GetImportTemplateResDto</returns>
        public async Task<GetImportTemplateResDto> GetImportTemplate(GetImportTemplateDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/metadata/get-import-template", reqDto).ConfigureAwait(false);

            GetImportTemplateResDto result = m_JsonService.DeserializeObject<GetImportTemplateResDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建自定义操作
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> CreateOperate(CreateOperateModelDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/create-operate", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 移除自定义操作
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> RemoveOperate(FunctionModelOperateIdDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/remove-operate", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 执行自定义操作
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> ExecuteOperate(FunctionModelOperateIdDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/execute-operate", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 复制自定义操作
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> CopyOperate(FunctionModelOperateIdDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/copy-operate", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 操作管理列表(分页)
        ///</summary>
        /// <param name="modelId">model Id</param>
        /// <param name="keywords">搜索功能名称</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>OperateModelDto</returns>
        public async Task<OperateModelDto> ListOperate(ListOperateDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/metadata/list-operate", reqDto).ConfigureAwait(false);

            OperateModelDto result = m_JsonService.DeserializeObject<OperateModelDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 全部操作管理列表
        ///</summary>
        /// <param name="modelId">model Id</param>
        ///<returns>OperateModelDto</returns>
        public async Task<OperateModelDto> ListOperateAll(AllOperateDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/metadata/all-operate", reqDto).ConfigureAwait(false);

            OperateModelDto result = m_JsonService.DeserializeObject<OperateModelDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 更新操作管理
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> UpdateOperate(UpdateOperateModelDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/update-operate", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取关联数据详情
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> GetRelationInfo(GetRelationInfoDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/get-relation-info", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建行关联数据
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> CreateRowRelation(CreateRelationValueDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/create-row-relation", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取行关联数据
        ///</summary>
        /// <param name="modelId">功能 id</param>
        /// <param name="fieldId">字段 id</param>
        /// <param name="rowId">行 id</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>RelationValueListResDto</returns>
        public async Task<RelationValueListResDto> GetRelationValue(GetRowRelationDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/metadata/get-row-relation", reqDto).ConfigureAwait(false);

            RelationValueListResDto result = m_JsonService.DeserializeObject<RelationValueListResDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 删除行关联数据
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> RemoveRelationValue(RemoveRelationValueDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/remove-row-relation", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 导出数据对象
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> ExportModel(ExportMetadataDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/export/model", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 导入数据对象
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> ImportModel(ImportMetadataDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/import/model", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// UEBA 上传
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateUEBARespDto</returns>
        public async Task<CreateUEBARespDto> Capture(CreateUEBADto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/metadata/ueba/capture", requestBody).ConfigureAwait(false);

            CreateUEBARespDto result = m_JsonService.DeserializeObject<CreateUEBARespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 岗位列表
        ///</summary>
        /// <param name="keywords">搜索岗位 code 或名称</param>
        /// <param name="skipCount">是否统计岗位关联的部门数和用户数</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withMetadata">是否展示元数据内容</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="flatCustomData">是否拍平扩展字段</param>
        ///<returns>PostPaginatedRespDto</returns>
        public async Task<PostPaginatedRespDto> PostList(ListPostDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-post", reqDto).ConfigureAwait(false);

            PostPaginatedRespDto result = m_JsonService.DeserializeObject<PostPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取岗位
        ///</summary>
        /// <param name="code">岗位 code</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>CreatePostDto</returns>
        public async Task<CreatePostDto> GetPost(GetPostDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-post", reqDto).ConfigureAwait(false);

            CreatePostDto result = m_JsonService.DeserializeObject<CreatePostDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户关联岗位
        ///</summary>
        /// <param name="userId">用户 id</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>PostListRespDto</returns>
        public async Task<PostListRespDto> GetUserPosts(GetUserPostsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-posts", reqDto).ConfigureAwait(false);

            PostListRespDto result = m_JsonService.DeserializeObject<PostListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户关联岗位
        ///</summary>
        /// <param name="userId">用户 id</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>CreatePostDto</returns>
        public async Task<CreatePostDto> GetUserPost(GetUserPostDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-post", reqDto).ConfigureAwait(false);

            CreatePostDto result = m_JsonService.DeserializeObject<CreatePostDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取岗位信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PostRespDto</returns>
        public async Task<PostRespDto> GetPostById(GetPostByIdListDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-post-by-id", requestBody).ConfigureAwait(false);

            PostRespDto result = m_JsonService.DeserializeObject<PostRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建岗位
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreatePostRespDto</returns>
        public async Task<CreatePostRespDto> CreatePost(CreatePostDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-post", requestBody).ConfigureAwait(false);

            CreatePostRespDto result = m_JsonService.DeserializeObject<CreatePostRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新岗位信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreatePostRespDto</returns>
        public async Task<CreatePostRespDto> UpdatePost(CreatePostDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-post", requestBody).ConfigureAwait(false);

            CreatePostRespDto result = m_JsonService.DeserializeObject<CreatePostRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除岗位
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> RemovePost(RemovePostDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/remove-post", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 用户设置岗位
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> SetUserPosts(SetUserPostsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-user-posts", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 用户关联岗位
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> UserConnectionPost(UserConnectionPostDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/user-connection-post", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 移除绑定(用户详情页)
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeleteDevice(DeleteTerminalUserDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-device-by-user", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 挂起设备(用户详情页)
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> SuspendDevice(SuspendTerminalUserDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/suspend-device-by-user", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 停用设备(用户详情页)
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DisableDevice(UpdateTerminalUserDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/disable-device-by-user", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 启用设备(用户详情页)
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> EnableDevice(UpdateTerminalUserDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/enable-device-by-user", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取设备状态
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DeviceStatusRespDto</returns>
        public async Task<DeviceStatusRespDto> GetDeviceStatus(TerminalBaseDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/device-status", requestBody).ConfigureAwait(false);

            DeviceStatusRespDto result = m_JsonService.DeserializeObject<DeviceStatusRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 移除设备
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeleteDevice1(DeleteTerminalDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-device", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 挂起设备
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> SuspendDevice1(SuspendTerminalDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/suspend-device", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 停用设备
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DisableDevice1(UpdateTerminalDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/disable-device", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 启用设备
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> EnableDevice1(UpdateTerminalDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/enable-device", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取/搜索公共账号列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PublicAccountPaginatedRespDto</returns>
        public async Task<PublicAccountPaginatedRespDto> ListPublicAccounts(ListPublicAccountsRequestDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-public-accounts", requestBody).ConfigureAwait(false);

            PublicAccountPaginatedRespDto result = m_JsonService.DeserializeObject<PublicAccountPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取公共账号信息
        ///</summary>
        /// <param name="userId">公共账号用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// </param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>PublicAccountSingleRespDto</returns>
        public async Task<PublicAccountSingleRespDto> GetPublicAccount(GetPublicAccountDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-public-account", reqDto).ConfigureAwait(false);

            PublicAccountSingleRespDto result = m_JsonService.DeserializeObject<PublicAccountSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取公共账号信息
        ///</summary>
        /// <param name="userIds">公共账号用户 ID 数组</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// </param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>PublicAccountListRespDto</returns>
        public async Task<PublicAccountListRespDto> GetPublicAccountBatch(GetPublicAccountBatchDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-public-account-batch", reqDto).ConfigureAwait(false);

            PublicAccountListRespDto result = m_JsonService.DeserializeObject<PublicAccountListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建公共账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PublicAccountSingleRespDto</returns>
        public async Task<PublicAccountSingleRespDto> CreatePublicAccount(CreatePublicAccountReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-public-account", requestBody).ConfigureAwait(false);

            PublicAccountSingleRespDto result = m_JsonService.DeserializeObject<PublicAccountSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建公共账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PublicAccountListRespDto</returns>
        public async Task<PublicAccountListRespDto> CreatePublicAccountsBatch(CreatePublicAccountBatchReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-public-accounts-batch", requestBody).ConfigureAwait(false);

            PublicAccountListRespDto result = m_JsonService.DeserializeObject<PublicAccountListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改公共账号资料
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PublicAccountSingleRespDto</returns>
        public async Task<PublicAccountSingleRespDto> UpdatePublicAccount(UpdatePublicAccountReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-public-account", requestBody).ConfigureAwait(false);

            PublicAccountSingleRespDto result = m_JsonService.DeserializeObject<PublicAccountSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量修改公共账号资料
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PublicAccountListRespDto</returns>
        public async Task<PublicAccountListRespDto> UpdatePublicAccountBatch(UpdatePublicAccountBatchReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-public-account-batch", requestBody).ConfigureAwait(false);

            PublicAccountListRespDto result = m_JsonService.DeserializeObject<PublicAccountListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除公共账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeletePublicAccountsBatch(DeletePublicAccountsBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-public-accounts-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 强制下线公共账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> KickPublicAccounts(KickPublicAccountsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/kick-public-accounts", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 个人账号转换为公共账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> ChangeIntoPublicAccount(CreatePublicAccountFromUserDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/transfer-into-public-account", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户的公共账号列表
        ///</summary>
        /// <param name="userId">用户 ID</param>
        ///<returns>PublicAccountPaginatedRespDto</returns>
        public async Task<PublicAccountPaginatedRespDto> GetPublicAccountsOfUser(GetPublicAccountsOfUserDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-public-accounts-of-user", reqDto).ConfigureAwait(false);

            PublicAccountPaginatedRespDto result = m_JsonService.DeserializeObject<PublicAccountPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 公共账号的用户列表
        ///</summary>
        /// <param name="publicAccountId">公共账号 ID</param>
        ///<returns>PublicAccountPaginatedRespDto</returns>
        public async Task<PublicAccountPaginatedRespDto> GetUsersOfPublicAccount(GetUsersOfPublicAccountDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-users-of-public-account", reqDto).ConfigureAwait(false);

            PublicAccountPaginatedRespDto result = m_JsonService.DeserializeObject<PublicAccountPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 公共账号绑定批量用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> BindUsersPublicAccount(SetPublicAccountBatchReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-public-account-of-users", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 用户绑定批量公共账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> SetuserOfPublicAccount(SetUserOfPublicAccountBatchReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-user-of-public-accounts", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 公共账号解绑用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UnbindUsersPublicAccount(UnbindPublicAccountBatchReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/unbind-public-account-of-user", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取组织机构详情
        ///</summary>
        /// <param name="organizationCode">组织 Code（organizationCode）</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withPost">是否获取 部门信息</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>OrganizationSingleRespDto</returns>
        public async Task<OrganizationSingleRespDto> GetOrganization(GetOrganizationDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-organization", reqDto).ConfigureAwait(false);

            OrganizationSingleRespDto result = m_JsonService.DeserializeObject<OrganizationSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取组织机构详情
        ///</summary>
        /// <param name="organizationCode">组织 Code（organizationCode）</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withPost">是否获取 部门信息</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>OrganizationSingleRespDto</returns>
        public async Task<OrganizationSingleRespDto> GetOrganization1(GetOrganizationDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-organization", reqDto).ConfigureAwait(false);

            OrganizationSingleRespDto result = m_JsonService.DeserializeObject<OrganizationSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取组织机构详情
        ///</summary>
        /// <param name="organizationCodeList">组织 Code（organizationCode）列表</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withPost">是否获取 部门信息</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>OrganizationListRespDto</returns>
        public async Task<OrganizationListRespDto> GetOrganizationsBatch(GetOrganizationBatchDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-organization-batch", reqDto).ConfigureAwait(false);

            OrganizationListRespDto result = m_JsonService.DeserializeObject<OrganizationListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取组织机构列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="fetchAll">拉取所有</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withPost">是否获取 部门信息</param>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="status">组织的状态</param>
        ///<returns>OrganizationPaginatedRespDto</returns>
        public async Task<OrganizationPaginatedRespDto> ListOrganizations(ListOrganizationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-organizations", reqDto).ConfigureAwait(false);

            OrganizationPaginatedRespDto result = m_JsonService.DeserializeObject<OrganizationPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取组织机构列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="fetchAll">拉取所有</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withPost">是否获取 部门信息</param>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="status">组织的状态</param>
        ///<returns>OrganizationPaginatedRespDto</returns>
        public async Task<OrganizationPaginatedRespDto> ListOrganizations1(ListOrganizationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-organizations", reqDto).ConfigureAwait(false);

            OrganizationPaginatedRespDto result = m_JsonService.DeserializeObject<OrganizationPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建组织机构
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>OrganizationSingleRespDto</returns>
        public async Task<OrganizationSingleRespDto> CreateOrganization(CreateOrganizationReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-organization", requestBody).ConfigureAwait(false);

            OrganizationSingleRespDto result = m_JsonService.DeserializeObject<OrganizationSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改组织机构
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>OrganizationSingleRespDto</returns>
        public async Task<OrganizationSingleRespDto> UpdateOrganization(UpdateOrganizationReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-organization", requestBody).ConfigureAwait(false);

            OrganizationSingleRespDto result = m_JsonService.DeserializeObject<OrganizationSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除组织机构
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteOrganization(DeleteOrganizationReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-organization", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 搜索组织机构列表
        ///</summary>
        /// <param name="keywords">搜索关键词，如组织机构名称</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>OrganizationPaginatedRespDto</returns>
        public async Task<OrganizationPaginatedRespDto> SearchOrganizations(SearchOrganizationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/search-organizations", reqDto).ConfigureAwait(false);

            OrganizationPaginatedRespDto result = m_JsonService.DeserializeObject<OrganizationPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 更新组织机构状态
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UpdateOrganizationStatus(UpdateOrganizationStatusReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-organization-status", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取部门信息
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`。departmentId 和 departmentCode 必传其一。</param>
        /// <param name="departmentCode">部门 code。departmentId 和 departmentCode 必传其一。</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="flatCustomData">是否拍平扩展字段</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> GetDepartment(GetDepartmentDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-department", reqDto).ConfigureAwait(false);

            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取部门信息
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`。departmentId 和 departmentCode 必传其一。</param>
        /// <param name="departmentCode">部门 code。departmentId 和 departmentCode 必传其一。</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="flatCustomData">是否拍平扩展字段</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> GetDepartment1(GetDepartmentDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-department", reqDto).ConfigureAwait(false);

            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> CreateDepartment(CreateDepartmentReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-department", requestBody).ConfigureAwait(false);

            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> CreateDepartment1(CreateDepartmentReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-department", requestBody).ConfigureAwait(false);

            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> UpdateDepartment(UpdateDepartmentReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-department", requestBody).ConfigureAwait(false);

            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> UpdateDepartment1(UpdateDepartmentReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-department", requestBody).ConfigureAwait(false);

            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteDepartment(DeleteDepartmentReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-department", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteDepartment1(DeleteDepartmentReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-department", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 搜索部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DepartmentListRespDto</returns>
        public async Task<DepartmentListRespDto> SearchDepartments(SearchDepartmentsReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/search-departments", requestBody).ConfigureAwait(false);

            DepartmentListRespDto result = m_JsonService.DeserializeObject<DepartmentListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 搜索部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DepartmentListRespDto</returns>
        public async Task<DepartmentListRespDto> SearchDepartmentsList(SearchDepartmentsListReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/search-departments-list", requestBody).ConfigureAwait(false);

            DepartmentListRespDto result = m_JsonService.DeserializeObject<DepartmentListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取子部门列表
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">需要获取的部门 ID</param>
        /// <param name="status">部门的状态</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="excludeVirtualNode">是否要排除虚拟组织</param>
        /// <param name="onlyVirtualNode">是否只包含虚拟组织</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>DepartmentPaginatedRespDto</returns>
        public async Task<DepartmentPaginatedRespDto> ListChildrenDepartments(ListChildrenDepartmentsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-children-departments", reqDto).ConfigureAwait(false);

            DepartmentPaginatedRespDto result = m_JsonService.DeserializeObject<DepartmentPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取子部门列表
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">需要获取的部门 ID</param>
        /// <param name="status">部门的状态</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="excludeVirtualNode">是否要排除虚拟组织</param>
        /// <param name="onlyVirtualNode">是否只包含虚拟组织</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>DepartmentPaginatedRespDto</returns>
        public async Task<DepartmentPaginatedRespDto> ListChildrenDepartments1(ListChildrenDepartmentsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-children-departments", reqDto).ConfigureAwait(false);

            DepartmentPaginatedRespDto result = m_JsonService.DeserializeObject<DepartmentPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取所有部门列表
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，不填写默认为 `root` 根部门 ID</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>DepartmentPaginatedRespDto</returns>
        public async Task<DepartmentPaginatedRespDto> GetAllDepartments(GetAllDepartmentsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-all-departments", reqDto).ConfigureAwait(false);

            DepartmentPaginatedRespDto result = m_JsonService.DeserializeObject<DepartmentPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取部门成员列表
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`</param>
        /// <param name="sortBy">排序依据</param>
        /// <param name="orderBy">增序还是倒序</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="includeChildrenDepartments">是否包含子部门的成员</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListDepartmentMembers(ListDepartmentMembersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-department-members", reqDto).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取部门成员列表
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`</param>
        /// <param name="sortBy">排序依据</param>
        /// <param name="orderBy">增序还是倒序</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="includeChildrenDepartments">是否包含子部门的成员</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListDepartmentMembers1(ListDepartmentMembersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-department-members", reqDto).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取部门直属成员 ID 列表
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>UserIdListRespDto</returns>
        public async Task<UserIdListRespDto> ListDepartmentMemberIds(ListDepartmentMemberIdsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-department-member-ids", reqDto).ConfigureAwait(false);

            UserIdListRespDto result = m_JsonService.DeserializeObject<UserIdListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 搜索部门下的成员
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`</param>
        /// <param name="keywords">搜索关键词，如成员名称</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="includeChildrenDepartments">是否包含子部门的成员</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> SearchDepartmentMembers(SearchDepartmentMembersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/search-department-members", reqDto).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 部门下添加成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AddDepartmentMembers(AddDepartmentMembersReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/add-department-members", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 部门下删除成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> RemoveDepartmentMembers(RemoveDepartmentMembersReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/remove-department-members", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取父部门信息
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> GetParentDepartment(GetParentDepartmentDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-parent-department", reqDto).ConfigureAwait(false);

            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 判断用户是否在某个部门下
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`。departmentId 和 departmentCode 必传其一。</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="includeChildrenDepartments">是否包含子部门</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>IsUserInDepartmentRespDto</returns>
        public async Task<IsUserInDepartmentRespDto> IsUserInDepartment(IsUserInDepartmentDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/is-user-in-department", reqDto).ConfigureAwait(false);

            IsUserInDepartmentRespDto result = m_JsonService.DeserializeObject<IsUserInDepartmentRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 根据部门id查询部门
        ///</summary>
        /// <param name="departmentId">部门 ID</param>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>DepartmentSingleRespDto</returns>
        public async Task<DepartmentSingleRespDto> GetDepartmentById(GetDepartmentByIdDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-department-by-id", reqDto).ConfigureAwait(false);

            DepartmentSingleRespDto result = m_JsonService.DeserializeObject<DepartmentSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 根据组织树批量创建部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateDepartmentTreeRespDto</returns>
        public async Task<CreateDepartmentTreeRespDto> CreateDepartmentTree(CreateDepartmentTreeReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-department-tree", requestBody).ConfigureAwait(false);

            CreateDepartmentTreeRespDto result = m_JsonService.DeserializeObject<CreateDepartmentTreeRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取部门绑定的第三方同步关系
        ///</summary>
        /// <param name="organizationCode">组织 code</param>
        /// <param name="departmentId">部门 ID，根部门传 `root`。departmentId 和 departmentCode 必传其一。</param>
        /// <param name="departmentIdType">此次调用中使用的部门 ID 的类型</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>SyncRelationListRespDto</returns>
        public async Task<SyncRelationListRespDto> GetDepartmentSyncRelations(GetDepartmentSyncRelationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-department-sync-relations", reqDto).ConfigureAwait(false);

            SyncRelationListRespDto result = m_JsonService.DeserializeObject<SyncRelationListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 删除部门同步关联关系
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteDepartmentSyncRelations(DeleteDepartmentSyncRelationReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-department-sync-relations", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新部门状态
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>Node</returns>
        public async Task<Node> UpdateNodeStatus(UpdateDepartmentStatusReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-department-status", requestBody).ConfigureAwait(false);

            Node result = m_JsonService.DeserializeObject<Node>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取/搜索用户列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListUsers(ListUsersRequestDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-users", requestBody).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="status">账户当前状态，如 已停用、已离职、正常状态、已归档</param>
        /// <param name="updatedAtStart">用户创建、修改开始时间，为精确到秒的 UNIX 时间戳；支持获取从某一段时间之后的增量数据</param>
        /// <param name="updatedAtEnd">用户创建、修改终止时间，为精确到秒的 UNIX 时间戳；支持获取某一段时间内的增量数据。默认为当前时间</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withPost">是否获取 部门信息</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListUsersLegacy(ListUsersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-users", reqDto).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户信息
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="flatCustomData">是否拍平扩展字段</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withPost">是否获取 部门信息</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserSingleRespDto</returns>
        public async Task<UserSingleRespDto> GetUser(GetUserDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user", reqDto).ConfigureAwait(false);

            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取用户信息
        ///</summary>
        /// <param name="userIds">用户 ID 数组</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="flatCustomData">是否拍平扩展字段</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserListRespDto</returns>
        public async Task<UserListRespDto> GetUserBatch(GetUserBatchDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-batch", reqDto).ConfigureAwait(false);

            UserListRespDto result = m_JsonService.DeserializeObject<UserListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 用户属性解密
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserFieldDecryptRespDto</returns>
        public async Task<UserFieldDecryptRespDto> UserFieldDecrypt(UserFieldDecryptReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/users/field/decrypt", requestBody).ConfigureAwait(false);

            UserFieldDecryptRespDto result = m_JsonService.DeserializeObject<UserFieldDecryptRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserSingleRespDto</returns>
        public async Task<UserSingleRespDto> CreateUser(CreateUserReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-user", requestBody).ConfigureAwait(false);

            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserListRespDto</returns>
        public async Task<UserListRespDto> CreateUsersBatch(CreateUserBatchReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-users-batch", requestBody).ConfigureAwait(false);

            UserListRespDto result = m_JsonService.DeserializeObject<UserListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改用户资料
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserSingleRespDto</returns>
        public async Task<UserSingleRespDto> UpdateUser(UpdateUserReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-user", requestBody).ConfigureAwait(false);

            UserSingleRespDto result = m_JsonService.DeserializeObject<UserSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量修改用户资料
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserListRespDto</returns>
        public async Task<UserListRespDto> UpdateUserBatch(UpdateUserBatchReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-user-batch", requestBody).ConfigureAwait(false);

            UserListRespDto result = m_JsonService.DeserializeObject<UserListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteUsersBatch(DeleteUsersBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-users-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户的外部身份源
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>IdentityListRespDto</returns>
        public async Task<IdentityListRespDto> GetUserIdentities(GetUserIdentitiesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-identities", reqDto).ConfigureAwait(false);

            IdentityListRespDto result = m_JsonService.DeserializeObject<IdentityListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户角色列表
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        ///<returns>RolePaginatedRespDto</returns>
        public async Task<RolePaginatedRespDto> GetUserRoles(GetUserRolesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-roles", reqDto).ConfigureAwait(false);

            RolePaginatedRespDto result = m_JsonService.DeserializeObject<RolePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户实名认证信息
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>PrincipalAuthenticationInfoPaginatedRespDto</returns>
        public async Task<PrincipalAuthenticationInfoPaginatedRespDto> GetUserPrincipalAuthenticationInfo(GetUserPrincipalAuthenticationInfoDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-principal-authentication-info", reqDto).ConfigureAwait(false);

            PrincipalAuthenticationInfoPaginatedRespDto result = m_JsonService.DeserializeObject<PrincipalAuthenticationInfoPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 删除用户实名认证信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> ResetUserPrincipalAuthenticationInfo(ResetUserPrincipalAuthenticationInfoDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/reset-user-principal-authentication-info", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户部门列表
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withDepartmentPaths">是否获取部门路径</param>
        /// <param name="sortBy">排序依据，如 部门创建时间、加入部门时间、部门名称、部门标志符</param>
        /// <param name="orderBy">增序或降序</param>
        ///<returns>UserDepartmentPaginatedRespDto</returns>
        public async Task<UserDepartmentPaginatedRespDto> GetUserDepartments(GetUserDepartmentsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-departments", reqDto).ConfigureAwait(false);

            UserDepartmentPaginatedRespDto result = m_JsonService.DeserializeObject<UserDepartmentPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 设置用户所在部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> SetUserDepartments(SetUserDepartmentsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-user-departments", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户分组列表
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>GroupPaginatedRespDto</returns>
        public async Task<GroupPaginatedRespDto> GetUserGroups(GetUserGroupsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-groups", reqDto).ConfigureAwait(false);

            GroupPaginatedRespDto result = m_JsonService.DeserializeObject<GroupPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户 MFA 绑定信息
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>UserMfaSingleRespDto</returns>
        public async Task<UserMfaSingleRespDto> GetUserMfaInfo(GetUserMfaInfoDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-mfa-info", reqDto).ConfigureAwait(false);

            UserMfaSingleRespDto result = m_JsonService.DeserializeObject<UserMfaSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取已归档的用户列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="startAt">开始时间，为精确到秒的 UNIX 时间戳，默认不指定</param>
        ///<returns>ListArchivedUsersSingleRespDto</returns>
        public async Task<ListArchivedUsersSingleRespDto> ListArchivedUsers(ListArchivedUsersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-archived-users", reqDto).ConfigureAwait(false);

            ListArchivedUsersSingleRespDto result = m_JsonService.DeserializeObject<ListArchivedUsersSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 强制下线用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> KickUsers(KickUsersDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/kick-users", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 判断用户是否存在
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsUserExistsRespDto</returns>
        public async Task<IsUserExistsRespDto> IsUserExists(IsUserExistsReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/is-user-exists", requestBody).ConfigureAwait(false);

            IsUserExistsRespDto result = m_JsonService.DeserializeObject<IsUserExistsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户可访问的应用
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>AppListRespDto</returns>
        public async Task<AppListRespDto> GetUserAccessibleApps(GetUserAccessibleAppsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-accessible-apps", reqDto).ConfigureAwait(false);

            AppListRespDto result = m_JsonService.DeserializeObject<AppListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户授权的应用
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>AppListRespDto</returns>
        public async Task<AppListRespDto> GetUserAuthorizedApps(GetUserAuthorizedAppsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-authorized-apps", reqDto).ConfigureAwait(false);

            AppListRespDto result = m_JsonService.DeserializeObject<AppListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 判断用户是否有某个角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>HasAnyRoleRespDto</returns>
        public async Task<HasAnyRoleRespDto> HasAnyRole(HasAnyRoleReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/has-any-role", requestBody).ConfigureAwait(false);

            HasAnyRoleRespDto result = m_JsonService.DeserializeObject<HasAnyRoleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户的登录历史记录
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="appId">应用 ID</param>
        /// <param name="clientIp">客户端 IP</param>
        /// <param name="start">开始时间戳（毫秒）</param>
        /// <param name="end">结束时间戳（毫秒）</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>UserLoginHistoryPaginatedRespDto</returns>
        public async Task<UserLoginHistoryPaginatedRespDto> GetUserLoginHistory(GetUserLoginHistoryDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-login-history", reqDto).ConfigureAwait(false);

            UserLoginHistoryPaginatedRespDto result = m_JsonService.DeserializeObject<UserLoginHistoryPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户曾经登录过的应用
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>UserLoggedInAppsListRespDto</returns>
        public async Task<UserLoggedInAppsListRespDto> GetUserLoggedinApps(GetUserLoggedinAppsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-loggedin-apps", reqDto).ConfigureAwait(false);

            UserLoggedInAppsListRespDto result = m_JsonService.DeserializeObject<UserLoggedInAppsListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户曾经登录过的身份源
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>UserLoggedInIdentitiesRespDto</returns>
        public async Task<UserLoggedInIdentitiesRespDto> GetUserLoggedinIdentities(GetUserLoggedInIdentitiesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-logged-in-identities", reqDto).ConfigureAwait(false);

            UserLoggedInIdentitiesRespDto result = m_JsonService.DeserializeObject<UserLoggedInIdentitiesRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 离职用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ResignUserRespDto</returns>
        public async Task<ResignUserRespDto> ResignUser(ResignUserReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/resign-user", requestBody).ConfigureAwait(false);

            ResignUserRespDto result = m_JsonService.DeserializeObject<ResignUserRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量离职用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ResignUserRespDto</returns>
        public async Task<ResignUserRespDto> ResignUserBatch(ResignUserBatchReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/resign-user-batch", requestBody).ConfigureAwait(false);

            ResignUserRespDto result = m_JsonService.DeserializeObject<ResignUserRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户被授权的所有资源
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        /// <param name="resourceType">资源类型，如 数据、API、菜单、按钮</param>
        ///<returns>AuthorizedResourcePaginatedRespDto</returns>
        public async Task<AuthorizedResourcePaginatedRespDto> GetUserAuthorizedResources(GetUserAuthorizedResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-authorized-resources", reqDto).ConfigureAwait(false);

            AuthorizedResourcePaginatedRespDto result = m_JsonService.DeserializeObject<AuthorizedResourcePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 检查某个用户在应用下是否具备 Session 登录态
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CheckSessionStatusRespDto</returns>
        public async Task<CheckSessionStatusRespDto> CheckSessionStatus(CheckSessionStatusDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-session-status", requestBody).ConfigureAwait(false);

            CheckSessionStatusRespDto result = m_JsonService.DeserializeObject<CheckSessionStatusRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 导入用户的 OTP
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> ImportOtp(ImportOtpReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/import-otp", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户绑定 OTP 的秘钥
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>GetOtpSecretRespDto</returns>
        public async Task<GetOtpSecretRespDto> GetOtpSecretByUser(GetOtpSecretByUserDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-otp-secret-by-user", reqDto).ConfigureAwait(false);

            GetOtpSecretRespDto result = m_JsonService.DeserializeObject<GetOtpSecretRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户自定义加密的密码
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GetUserPasswordCiphertextRespDto</returns>
        public async Task<GetUserPasswordCiphertextRespDto> GetUserPasswordCiphertext(GetUserPasswordCiphertextDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-user-password-ciphertext", requestBody).ConfigureAwait(false);

            GetUserPasswordCiphertextRespDto result = m_JsonService.DeserializeObject<GetUserPasswordCiphertextRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 给用户绑定一个身份信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>LinkIdentityResDto</returns>
        public async Task<LinkIdentityResDto> LinkIdentity(LinkIdentityDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/link-identity", requestBody).ConfigureAwait(false);

            LinkIdentityResDto result = m_JsonService.DeserializeObject<LinkIdentityResDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 解除绑定用户在身份源下的所有身份信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UnlinkIdentityResDto</returns>
        public async Task<UnlinkIdentityResDto> UnlinkIdentity(UnlinkIdentity requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/unlink-identity", requestBody).ConfigureAwait(false);

            UnlinkIdentityResDto result = m_JsonService.DeserializeObject<UnlinkIdentityResDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 设置用户 MFA 状态
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> SetUsersMfaStatus(SetMfaStatusDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-mfa-status", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户 MFA 状态
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>GetMapInfoRespDto</returns>
        public async Task<GetMapInfoRespDto> GetUserMfaStatus(GetMfaStatusDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-mfa-status", reqDto).ConfigureAwait(false);

            GetMapInfoRespDto result = m_JsonService.DeserializeObject<GetMapInfoRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户绑定的第三方同步关系
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>SyncRelationListRespDto</returns>
        public async Task<SyncRelationListRespDto> GetUserSyncRelations(GetUserSyncRelationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-sync-relations", reqDto).ConfigureAwait(false);

            SyncRelationListRespDto result = m_JsonService.DeserializeObject<SyncRelationListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 删除用户同步关联关系
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteUserSyncRelations(DeleteUserSyncRelationReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-user-sync-relations", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取公共账号的角色列表
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 code</param>
        ///<returns>PublicAccountPaginatedRespDto</returns>
        public async Task<PublicAccountPaginatedRespDto> GetPublicAccountRoles(GetRolesOfPublicAccountDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-roles-of-public-account", reqDto).ConfigureAwait(false);

            PublicAccountPaginatedRespDto result = m_JsonService.DeserializeObject<PublicAccountPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取角色的公共账号列表
        ///</summary>
        /// <param name="roleId">角色 ID</param>
        ///<returns>PublicAccountPaginatedRespDto</returns>
        public async Task<PublicAccountPaginatedRespDto> GetPublicAccountsOfRole(GetPublicAccountsOfRoleDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-public-accounts-of-role", reqDto).ConfigureAwait(false);

            PublicAccountPaginatedRespDto result = m_JsonService.DeserializeObject<PublicAccountPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 公共账号绑定批量角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> BindPublicAccountOfRoles(SetUserRolesDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-public-account-of-roles", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取分组的公共账号列表
        ///</summary>
        /// <param name="groupId">分组 ID</param>
        ///<returns>PublicAccountPaginatedRespDto</returns>
        public async Task<PublicAccountPaginatedRespDto> GetPublicAccountsOfGroup(GetPublicAccountsOfGroupDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-public-accounts-of-group", reqDto).ConfigureAwait(false);

            PublicAccountPaginatedRespDto result = m_JsonService.DeserializeObject<PublicAccountPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取公共账号分组列表
        ///</summary>
        /// <param name="userId">用户唯一标志，可以是用户 ID、用户名、邮箱、手机号、外部 ID、在外部身份源的 ID。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>GroupPaginatedRespDto</returns>
        public async Task<GroupPaginatedRespDto> GetGroupsOfPublicAccount(GetGroupsOfPublicAccountDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-groups-of-public-account", reqDto).ConfigureAwait(false);

            GroupPaginatedRespDto result = m_JsonService.DeserializeObject<GroupPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 公共账号添加批量分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> GetPublicAccountOfGroups(SetUserGroupsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-public-account-of-groups", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取部门的公共账号列表
        ///</summary>
        /// <param name="departmentId">部门 ID</param>
        ///<returns>PublicAccountPaginatedRespDto</returns>
        public async Task<PublicAccountPaginatedRespDto> GetPublicAccountsOfDepartment(GetPublicAccountsOfDepartmentDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-public-accounts-of-department", reqDto).ConfigureAwait(false);

            PublicAccountPaginatedRespDto result = m_JsonService.DeserializeObject<PublicAccountPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取公共账号的部门列表
        ///</summary>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withDepartmentPaths">是否获取部门路径</param>
        /// <param name="sortBy">排序依据，如 部门创建时间、加入部门时间、部门名称、部门标志符</param>
        /// <param name="orderBy">增序或降序</param>
        ///<returns>UserDepartmentPaginatedRespDto</returns>
        public async Task<UserDepartmentPaginatedRespDto> GetPublicAccountDepartments(GetDepartmentsOfPublicAccountDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-departments-of-public-account", reqDto).ConfigureAwait(false);

            UserDepartmentPaginatedRespDto result = m_JsonService.DeserializeObject<UserDepartmentPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 设置公共账号所在部门
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> SetPublicAccountOfDepartments(SetUserDepartmentsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-public-account-of-departments", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量离职用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ResignUserRespDto</returns>
        public async Task<ResignUserRespDto> ResignPublicAccountBatch(ResignUserBatchReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/resign-public-account-batch", requestBody).ConfigureAwait(false);

            ResignUserRespDto result = m_JsonService.DeserializeObject<ResignUserRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取公共账号的岗位
        ///</summary>
        /// <param name="userId">用户 id</param>
        ///<returns>CreatePostDto</returns>
        public async Task<CreatePostDto> GetPostOfPublicUser(GetPostOfPublicAccountDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-post-of-public-account", reqDto).ConfigureAwait(false);

            CreatePostDto result = m_JsonService.DeserializeObject<CreatePostDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取岗位的公共账号列表
        ///</summary>
        /// <param name="postId">岗位 ID</param>
        ///<returns>PublicAccountPaginatedRespDto</returns>
        public async Task<PublicAccountPaginatedRespDto> GetPublicAccountsOfPost(GetPublicAccountsOfPostDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-public-accounts-of-post", reqDto).ConfigureAwait(false);

            PublicAccountPaginatedRespDto result = m_JsonService.DeserializeObject<PublicAccountPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 设置公共账号的岗位
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> SetPublicAccountOfnPost(UserConnectionPostDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-public-account-of-post", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 解绑公共账号关联岗位
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UnbindPublicAccountOfPost(UserConnectionPostDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/unbind-public-account-of-post", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取同步任务详情
        ///</summary>
        /// <param name="syncTaskId">同步任务 ID</param>
        ///<returns>SyncTaskSingleRespDto</returns>
        public async Task<SyncTaskSingleRespDto> GetSyncTask(GetSyncTaskDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-sync-task", reqDto).ConfigureAwait(false);

            SyncTaskSingleRespDto result = m_JsonService.DeserializeObject<SyncTaskSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取同步任务列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>SyncTaskPaginatedRespDto</returns>
        public async Task<SyncTaskPaginatedRespDto> ListSyncTasks(ListSyncTasksDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-sync-tasks", reqDto).ConfigureAwait(false);

            SyncTaskPaginatedRespDto result = m_JsonService.DeserializeObject<SyncTaskPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建同步任务
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>SyncTaskPaginatedRespDto</returns>
        public async Task<SyncTaskPaginatedRespDto> CreateSyncTask(CreateSyncTaskDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-sync-task", requestBody).ConfigureAwait(false);

            SyncTaskPaginatedRespDto result = m_JsonService.DeserializeObject<SyncTaskPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改同步任务
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>SyncTaskPaginatedRespDto</returns>
        public async Task<SyncTaskPaginatedRespDto> UpdateSyncTask(UpdateSyncTaskDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-sync-task", requestBody).ConfigureAwait(false);

            SyncTaskPaginatedRespDto result = m_JsonService.DeserializeObject<SyncTaskPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 执行同步任务
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>TriggerSyncTaskRespDto</returns>
        public async Task<TriggerSyncTaskRespDto> TriggerSyncTask(TriggerSyncTaskDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/trigger-sync-task", requestBody).ConfigureAwait(false);

            TriggerSyncTaskRespDto result = m_JsonService.DeserializeObject<TriggerSyncTaskRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取同步作业详情
        ///</summary>
        /// <param name="syncJobId">同步作业 ID</param>
        ///<returns>SyncJobSingleRespDto</returns>
        public async Task<SyncJobSingleRespDto> GetSyncJob(GetSyncJobDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-sync-job", reqDto).ConfigureAwait(false);

            SyncJobSingleRespDto result = m_JsonService.DeserializeObject<SyncJobSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取同步作业详情
        ///</summary>
        /// <param name="syncTaskId">同步任务 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="syncTrigger">同步任务触发类型：
        /// - `manually`: 手动触发执行
        /// - `timed`: 定时触发
        /// - `automatic`: 根据事件自动触发
        /// </param>
        ///<returns>SyncJobPaginatedRespDto</returns>
        public async Task<SyncJobPaginatedRespDto> ListSyncJobs(ListSyncJobsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-sync-jobs", reqDto).ConfigureAwait(false);

            SyncJobPaginatedRespDto result = m_JsonService.DeserializeObject<SyncJobPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取同步作业详情
        ///</summary>
        /// <param name="syncJobId">同步作业 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="success">根据是否操作成功进行筛选</param>
        /// <param name="action">根据操作类型进行筛选：
        /// - `CreateUser`: 创建用户
        /// - `UpdateUser`: 修改用户信息
        /// - `DeleteUser`: 删除用户
        /// - `UpdateUserIdentifier`: 修改用户唯一标志符
        /// - `ChangeUserDepartment`: 修改用户部门
        /// - `CreateDepartment`: 创建部门
        /// - `UpdateDepartment`: 修改部门信息
        /// - `DeleteDepartment`: 删除部门
        /// - `MoveDepartment`: 移动部门
        /// - `UpdateDepartmentLeader`: 同步部门负责人
        /// - `CreateGroup`: 创建分组
        /// - `UpdateGroup`: 修改分组
        /// - `DeleteGroup`: 删除分组
        /// - `Updateless`: 无更新
        /// </param>
        /// <param name="objectType">操作对象类型:
        /// - `department`: 部门
        /// - `user`: 用户
        /// </param>
        ///<returns>TriggerSyncTaskRespDto</returns>
        public async Task<TriggerSyncTaskRespDto> ListSyncJobLogs(ListSyncJobLogsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-sync-job-logs", reqDto).ConfigureAwait(false);

            TriggerSyncTaskRespDto result = m_JsonService.DeserializeObject<TriggerSyncTaskRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取同步风险操作列表
        ///</summary>
        /// <param name="syncTaskId">同步任务 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="status">根据执行状态筛选</param>
        /// <param name="objectType">根据操作对象类型，默认获取所有类型的记录：
        /// - `department`: 部门
        /// - `user`: 用户
        /// </param>
        ///<returns>SyncRiskOperationPaginatedRespDto</returns>
        public async Task<SyncRiskOperationPaginatedRespDto> ListSyncRiskOperations(ListSyncRiskOperationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-sync-risk-operations", reqDto).ConfigureAwait(false);

            SyncRiskOperationPaginatedRespDto result = m_JsonService.DeserializeObject<SyncRiskOperationPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 执行同步风险操作
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>TriggerSyncRiskOperationsRespDto</returns>
        public async Task<TriggerSyncRiskOperationsRespDto> TriggerSyncRiskOperations(TriggerSyncRiskOperationDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/trigger-sync-risk-operations", requestBody).ConfigureAwait(false);

            TriggerSyncRiskOperationsRespDto result = m_JsonService.DeserializeObject<TriggerSyncRiskOperationsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 取消同步风险操作
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CancelSyncRiskOperationsRespDto</returns>
        public async Task<CancelSyncRiskOperationsRespDto> CancelSyncRiskOperation(CancelSyncRiskOperationDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/cancel-sync-risk-operation", requestBody).ConfigureAwait(false);

            CancelSyncRiskOperationsRespDto result = m_JsonService.DeserializeObject<CancelSyncRiskOperationsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取分组详情
        ///</summary>
        /// <param name="code">分组 code</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>GroupSingleRespDto</returns>
        public async Task<GroupSingleRespDto> GetGroup(GetGroupDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-group", reqDto).ConfigureAwait(false);

            GroupSingleRespDto result = m_JsonService.DeserializeObject<GroupSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取分组列表
        ///</summary>
        /// <param name="keywords">搜索分组 code 或分组名称</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withMetadata">是否展示元数据内容</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="flatCustomData">是否拍平扩展字段</param>
        ///<returns>GroupPaginatedRespDto</returns>
        public async Task<GroupPaginatedRespDto> ListGroups(ListGroupsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-groups", reqDto).ConfigureAwait(false);

            GroupPaginatedRespDto result = m_JsonService.DeserializeObject<GroupPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取所有分组
        ///</summary>
        /// <param name="fetchMembers">是否获取成员列表</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        ///<returns>GroupListRespDto</returns>
        public async Task<GroupListRespDto> GetAllGroups(GetAllGroupsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-all-groups", reqDto).ConfigureAwait(false);

            GroupListRespDto result = m_JsonService.DeserializeObject<GroupListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GroupSingleRespDto</returns>
        public async Task<GroupSingleRespDto> CreateGroup(CreateGroupReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-group", requestBody).ConfigureAwait(false);

            GroupSingleRespDto result = m_JsonService.DeserializeObject<GroupSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建或修改分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateOrUpdateGroupRespDto</returns>
        public async Task<CreateOrUpdateGroupRespDto> CreateOrUpdateGroup(CreateOrUpdateGroupReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-or-update-group", requestBody).ConfigureAwait(false);

            CreateOrUpdateGroupRespDto result = m_JsonService.DeserializeObject<CreateOrUpdateGroupRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GroupListRespDto</returns>
        public async Task<GroupListRespDto> CreateGroupsBatch(CreateGroupBatchReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-groups-batch", requestBody).ConfigureAwait(false);

            GroupListRespDto result = m_JsonService.DeserializeObject<GroupListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GroupSingleRespDto</returns>
        public async Task<GroupSingleRespDto> UpdateGroup(UpdateGroupReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-group", requestBody).ConfigureAwait(false);

            GroupSingleRespDto result = m_JsonService.DeserializeObject<GroupSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteGroupsBatch(DeleteGroupsReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-groups-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 添加分组成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AddGroupMembers(AddGroupMembersReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/add-group-members", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量移除分组成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> RemoveGroupMembers(RemoveGroupMembersReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/remove-group-members", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取分组成员列表
        ///</summary>
        /// <param name="code">分组 code</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListGroupMembers(ListGroupMembersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-group-members", reqDto).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取分组被授权的资源列表
        ///</summary>
        /// <param name="code">分组 code</param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        /// <param name="resourceType">资源类型</param>
        ///<returns>AuthorizedResourceListRespDto</returns>
        public async Task<AuthorizedResourceListRespDto> GetGroupAuthorizedResources(GetGroupAuthorizedResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-group-authorized-resources", reqDto).ConfigureAwait(false);

            AuthorizedResourceListRespDto result = m_JsonService.DeserializeObject<AuthorizedResourceListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取角色详情
        ///</summary>
        /// <param name="code">权限分组(权限空间)内角色的唯一标识符</param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        ///<returns>RoleSingleRespDto</returns>
        public async Task<RoleSingleRespDto> GetRole(GetRoleDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-role", reqDto).ConfigureAwait(false);

            RoleSingleRespDto result = m_JsonService.DeserializeObject<RoleSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 单个角色批量授权
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AssignRole(AssignRoleDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/assign-role", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量分配角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AssignRoleBatch(AssignRoleBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/assign-role-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 移除分配的角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> RevokeRole(RevokeRoleDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/revoke-role", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量移除分配的角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> RevokeRoleBatch(RevokeRoleBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/revoke-role-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取角色被授权的资源列表
        ///</summary>
        /// <param name="code">权限分组内角色的唯一标识符</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        /// <param name="resourceType">资源类型，如 数据、API、按钮、菜单</param>
        ///<returns>RoleAuthorizedResourcePaginatedRespDto</returns>
        public async Task<RoleAuthorizedResourcePaginatedRespDto> GetRoleAuthorizedResources(GetRoleAuthorizedResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-role-authorized-resources", reqDto).ConfigureAwait(false);

            RoleAuthorizedResourcePaginatedRespDto result = m_JsonService.DeserializeObject<RoleAuthorizedResourcePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取角色成员列表
        ///</summary>
        /// <param name="code">权限分组内角色的唯一标识符</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="withCustomData">是否获取自定义数据</param>
        /// <param name="withIdentities">是否获取 identities</param>
        /// <param name="withDepartmentIds">是否获取部门 ID 列表</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListRoleMembers(ListRoleMembersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-role-members", reqDto).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取角色的部门列表
        ///</summary>
        /// <param name="code">权限分组内角色的唯一标识符</param>
        /// <param name="nameSpace">所属权限分组的 code</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>RoleDepartmentListPaginatedRespDto</returns>
        public async Task<RoleDepartmentListPaginatedRespDto> ListRoleDepartments(ListRoleDepartmentsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-role-departments", reqDto).ConfigureAwait(false);

            RoleDepartmentListPaginatedRespDto result = m_JsonService.DeserializeObject<RoleDepartmentListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>RoleSingleRespDto</returns>
        public async Task<RoleSingleRespDto> CreateRole(CreateRoleDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-role", requestBody).ConfigureAwait(false);

            RoleSingleRespDto result = m_JsonService.DeserializeObject<RoleSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取角色列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="keywords">用于根据角色的 code 或者名称进行模糊搜索，可选。</param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 code</param>
        ///<returns>RolePaginatedRespDto</returns>
        public async Task<RolePaginatedRespDto> ListRoles(ListRolesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-roles", reqDto).ConfigureAwait(false);

            RolePaginatedRespDto result = m_JsonService.DeserializeObject<RolePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 单个权限分组（权限空间）内删除角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteRolesBatch(DeleteRoleDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-roles-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> CreateRolesBatch(CreateRolesBatch requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-roles-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UpdateRole(UpdateRoleDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-role", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 跨权限分组（空间）删除角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteRoles(DeleteRoleBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/multiple-namespace-delete-roles-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 校验角色 Code 或者名称是否可用
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>RoleCheckParamsRespDto</returns>
        public async Task<RoleCheckParamsRespDto> CheckParamsNamespace(CheckRoleParamsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-role-params", requestBody).ConfigureAwait(false);

            RoleCheckParamsRespDto result = m_JsonService.DeserializeObject<RoleCheckParamsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取角色授权列表
        ///</summary>
        /// <param name="roleCode">角色 code,只能使用字母、数字和 -_，最多 50 字符</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">按角色 Code 或者角色名称查询</param>
        /// <param name="namespaceCode">权限空间code</param>
        /// <param name="targetType">目标类型，接受用户，部门</param>
        ///<returns>RoleListPageRespDto</returns>
        public async Task<RoleListPageRespDto> ListRoleAssignments(ListRoleAssignmentsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-role-assignments", reqDto).ConfigureAwait(false);

            RoleListPageRespDto result = m_JsonService.DeserializeObject<RoleListPageRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建管理员角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>RoleCheckParamsRespDto</returns>
        public async Task<RoleCheckParamsRespDto> CreateAdminRole(CreateAdminRoleDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-admin-role", requestBody).ConfigureAwait(false);

            RoleCheckParamsRespDto result = m_JsonService.DeserializeObject<RoleCheckParamsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除管理员自定义角色
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteAdminRolesBatch(DeleteAdminRoleDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-admin-roles", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取身份源列表
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="appId">应用 ID</param>
        ///<returns>ExtIdpListPaginatedRespDto</returns>
        public async Task<ExtIdpListPaginatedRespDto> ListExtIdp(ListExtIdpDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-ext-idp", reqDto).ConfigureAwait(false);

            ExtIdpListPaginatedRespDto result = m_JsonService.DeserializeObject<ExtIdpListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取身份源列表
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="appId">应用 ID</param>
        ///<returns>ExtIdpListPaginatedRespDto</returns>
        public async Task<ExtIdpListPaginatedRespDto> ListExtIdp1(ListExtIdpDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-ext-idp", reqDto).ConfigureAwait(false);

            ExtIdpListPaginatedRespDto result = m_JsonService.DeserializeObject<ExtIdpListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取身份源详情
        ///</summary>
        /// <param name="id">身份源 ID</param>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="appId">应用 ID</param>
        /// <param name="type">身份源类型</param>
        ///<returns>ExtIdpDetailSingleRespDto</returns>
        public async Task<ExtIdpDetailSingleRespDto> GetExtIdp(GetExtIdpDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-ext-idp", reqDto).ConfigureAwait(false);

            ExtIdpDetailSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpDetailSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取身份源详情
        ///</summary>
        /// <param name="id">身份源 ID</param>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="appId">应用 ID</param>
        /// <param name="type">身份源类型</param>
        ///<returns>ExtIdpDetailSingleRespDto</returns>
        public async Task<ExtIdpDetailSingleRespDto> GetExtIdp1(GetExtIdpDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-ext-idp", reqDto).ConfigureAwait(false);

            ExtIdpDetailSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpDetailSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建身份源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpSingleRespDto</returns>
        public async Task<ExtIdpSingleRespDto> CreateExtIdp(CreateExtIdpDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-ext-idp", requestBody).ConfigureAwait(false);

            ExtIdpSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建身份源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpSingleRespDto</returns>
        public async Task<ExtIdpSingleRespDto> CreateExtIdp1(CreateExtIdpDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-ext-idp", requestBody).ConfigureAwait(false);

            ExtIdpSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新身份源配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpSingleRespDto</returns>
        public async Task<ExtIdpSingleRespDto> UpdateExtIdp(UpdateExtIdpDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-ext-idp", requestBody).ConfigureAwait(false);

            ExtIdpSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新身份源配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpSingleRespDto</returns>
        public async Task<ExtIdpSingleRespDto> UpdateExtIdp1(UpdateExtIdpDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-ext-idp", requestBody).ConfigureAwait(false);

            ExtIdpSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除身份源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteExtIdp(DeleteExtIdpDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-ext-idp", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除身份源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteExtIdp1(DeleteExtIdpDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-ext-idp", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 在某个已有身份源下创建新连接
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpConnDetailSingleRespDto</returns>
        public async Task<ExtIdpConnDetailSingleRespDto> CreateExtIdpConn(CreateExtIdpConnDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-ext-idp-conn", requestBody).ConfigureAwait(false);

            ExtIdpConnDetailSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpConnDetailSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 在某个已有身份源下创建新连接
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpConnDetailSingleRespDto</returns>
        public async Task<ExtIdpConnDetailSingleRespDto> CreateExtIdpConn1(CreateExtIdpConnDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-ext-idp-conn", requestBody).ConfigureAwait(false);

            ExtIdpConnDetailSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpConnDetailSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新身份源连接
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpConnDetailSingleRespDto</returns>
        public async Task<ExtIdpConnDetailSingleRespDto> UpdateExtIdpConn(UpdateExtIdpConnDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-ext-idp-conn", requestBody).ConfigureAwait(false);

            ExtIdpConnDetailSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpConnDetailSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新身份源连接
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ExtIdpConnDetailSingleRespDto</returns>
        public async Task<ExtIdpConnDetailSingleRespDto> UpdateExtIdpConn1(UpdateExtIdpConnDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-ext-idp-conn", requestBody).ConfigureAwait(false);

            ExtIdpConnDetailSingleRespDto result = m_JsonService.DeserializeObject<ExtIdpConnDetailSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除身份源连接
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteExtIdpConn(DeleteExtIdpConnDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-ext-idp-conn", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除身份源连接
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteExtIdpConn1(DeleteExtIdpConnDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-ext-idp-conn", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 身份源连接开关
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> ChangeExtIdpConnState(ChangeExtIdpConnStateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/change-ext-idp-conn-state", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 身份源连接开关
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> ChangeExtIdpConnState1(ChangeExtIdpConnStateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/change-ext-idp-conn-state", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 租户关联身份源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> ChangeExtIdpConnAssociationState(ChangeExtIdpAssociationStateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/change-ext-idp-conn-association-state", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 租户关联身份源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> ChangeExtIdpConnAssociationState1(ChangeExtIdpAssociationStateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/change-ext-idp-conn-association-state", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 租户控制台获取身份源列表
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="appId">应用 ID</param>
        /// <param name="type">身份源类型</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>ExtIdpListPaginatedRespDto</returns>
        public async Task<ExtIdpListPaginatedRespDto> ListTenantExtIdp(ListTenantExtIdpDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-tenant-ext-idp", reqDto).ConfigureAwait(false);

            ExtIdpListPaginatedRespDto result = m_JsonService.DeserializeObject<ExtIdpListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 租户控制台获取身份源列表
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="appId">应用 ID</param>
        /// <param name="type">身份源类型</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>ExtIdpListPaginatedRespDto</returns>
        public async Task<ExtIdpListPaginatedRespDto> ListTenantExtIdp1(ListTenantExtIdpDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-tenant-ext-idp", reqDto).ConfigureAwait(false);

            ExtIdpListPaginatedRespDto result = m_JsonService.DeserializeObject<ExtIdpListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 身份源下应用的连接详情
        ///</summary>
        /// <param name="id">身份源 ID</param>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="appId">应用 ID</param>
        /// <param name="type">身份源类型</param>
        ///<returns>ExtIdpListPaginatedRespDto</returns>
        public async Task<ExtIdpListPaginatedRespDto> ExtIdpConnStateByApps(ExtIdpConnAppsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/ext-idp-conn-apps", reqDto).ConfigureAwait(false);

            ExtIdpListPaginatedRespDto result = m_JsonService.DeserializeObject<ExtIdpListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 身份源下应用的连接详情
        ///</summary>
        /// <param name="id">身份源 ID</param>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="appId">应用 ID</param>
        /// <param name="type">身份源类型</param>
        ///<returns>ExtIdpListPaginatedRespDto</returns>
        public async Task<ExtIdpListPaginatedRespDto> ExtIdpConnStateByApps1(ExtIdpConnAppsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/ext-idp-conn-apps", reqDto).ConfigureAwait(false);

            ExtIdpListPaginatedRespDto result = m_JsonService.DeserializeObject<ExtIdpListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户内置字段列表
        ///</summary>
        ///<returns>CustomFieldListRespDto</returns>
        public async Task<CustomFieldListRespDto> GetUserBaseFields()
        {
            string httpResponse = await Request("GET", "/api/v3/get-user-base-fields").ConfigureAwait(false);

            CustomFieldListRespDto result = m_JsonService.DeserializeObject<CustomFieldListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用户内置字段列表
        ///</summary>
        /// <param name="targetType">目标对象类型：
        /// - `USER`: 用户
        /// - `ROLE`: 角色
        /// - `GROUP`: 分组
        /// - `DEPARTMENT`: 部门
        /// ;该接口暂不支持分组(GROUP)</param>
        /// <param name="dataType">字段类型</param>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="userVisible">用户是否可见</param>
        /// <param name="adminVisible">管理员是否可见</param>
        /// <param name="accessControl">访问控制</param>
        /// <param name="keyword">搜索关键词</param>
        /// <param name="lang">搜索语言</param>
        ///<returns>ListCistomFieldsResDto</returns>
        public async Task<ListCistomFieldsResDto> ListUserBaseFields(ListUserBaseFieldsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-user-base-fields", reqDto).ConfigureAwait(false);

            ListCistomFieldsResDto result = m_JsonService.DeserializeObject<ListCistomFieldsResDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改用户内置字段配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CustomFieldListRespDto</returns>
        public async Task<CustomFieldListRespDto> SetUserBaseFields(SetUserBaseFieldsReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-user-base-fields", requestBody).ConfigureAwait(false);

            CustomFieldListRespDto result = m_JsonService.DeserializeObject<CustomFieldListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取自定义字段列表
        ///</summary>
        /// <param name="targetType">目标对象类型：
        /// - `USER`: 用户
        /// - `ROLE`: 角色
        /// - `GROUP`: 分组
        /// - `DEPARTMENT`: 部门
        /// ;该接口暂不支持分组(GROUP)</param>
        /// <param name="tenantId">租户 ID</param>
        ///<returns>CustomFieldListRespDto</returns>
        public async Task<CustomFieldListRespDto> GetCustomFields(GetCustomFieldsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-custom-fields", reqDto).ConfigureAwait(false);

            CustomFieldListRespDto result = m_JsonService.DeserializeObject<CustomFieldListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取自定义字段列表
        ///</summary>
        /// <param name="targetType">目标对象类型：
        /// - `USER`: 用户
        /// - `ROLE`: 角色
        /// - `GROUP`: 分组
        /// - `DEPARTMENT`: 部门
        /// ;该接口暂不支持分组(GROUP)</param>
        /// <param name="dataType">字段类型</param>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="userVisible">用户是否可见</param>
        /// <param name="adminVisible">管理员是否可见</param>
        /// <param name="accessControl">访问控制</param>
        /// <param name="keyword">搜索关键词</param>
        /// <param name="lang">搜索语言</param>
        ///<returns>ListCistomFieldsResDto</returns>
        public async Task<ListCistomFieldsResDto> ListCustFields(ListCustomFieldsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-custom-fields", reqDto).ConfigureAwait(false);

            ListCistomFieldsResDto result = m_JsonService.DeserializeObject<ListCistomFieldsResDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建/修改自定义字段定义
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CustomFieldListRespDto</returns>
        public async Task<CustomFieldListRespDto> SetCustomFields(SetCustomFieldsReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-custom-fields", requestBody).ConfigureAwait(false);

            CustomFieldListRespDto result = m_JsonService.DeserializeObject<CustomFieldListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除自定义字段定义
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteCustomFields(DeleteCustomFieldsReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-custom-fields", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 设置自定义字段的值
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> SetCustomData(SetCustomDataReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-custom-data", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户、分组、角色、组织机构的自定义字段值
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="targetType">目标对象类型：
        /// - `USER`: 用户
        /// - `ROLE`: 角色
        /// - `GROUP`: 分组
        /// - `DEPARTMENT`: 部门
        /// </param>
        /// <param name="targetIdentifier">目标对象的唯一标志符：
        /// - 如果是用户，为用户的 ID，如 `6343b98b7cfxxx9366e9b7c`
        /// - 如果是角色，为角色的 code，如 `admin`
        /// - 如果是分组，为分组的 code，如 `developer`
        /// - 如果是部门，为部门的 ID，如 `6343bafc019xxxx889206c4c`
        /// </param>
        /// <param name="nameSpace">所属权限分组的 code，当 targetType 为角色的时候需要填写，否则可以忽略</param>
        ///<returns>GetCustomDataRespDto</returns>
        public async Task<GetCustomDataRespDto> GetCustomData(GetCustomDataDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-custom-data", reqDto).ConfigureAwait(false);

            GetCustomDataRespDto result = m_JsonService.DeserializeObject<GetCustomDataRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ResourceRespDto</returns>
        public async Task<ResourceRespDto> CreateResource(CreateResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-resource", requestBody).ConfigureAwait(false);

            ResourceRespDto result = m_JsonService.DeserializeObject<ResourceRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> CreateResourcesBatch(CreateResourcesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-resources-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取资源详情
        ///</summary>
        /// <param name="code">资源唯一标志符</param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        ///<returns>ResourceRespDto</returns>
        public async Task<ResourceRespDto> GetResource(GetResourceDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-resource", reqDto).ConfigureAwait(false);

            ResourceRespDto result = m_JsonService.DeserializeObject<ResourceRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取资源详情
        ///</summary>
        /// <param name="codeList">资源 code 列表，批量可以使用逗号分隔</param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        ///<returns>ResourceListRespDto</returns>
        public async Task<ResourceListRespDto> GetResourcesBatch(GetResourcesBatchDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-resources-batch", reqDto).ConfigureAwait(false);

            ResourceListRespDto result = m_JsonService.DeserializeObject<ResourceListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 分页获取常规资源列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="keyword">查询条件</param>
        /// <param name="namespaceCodeList">权限空间列表</param>
        ///<returns>CommonResourcePaginatedRespDto</returns>
        public async Task<CommonResourcePaginatedRespDto> ListCommonResource(ListCommonResourceDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-common-resource", reqDto).ConfigureAwait(false);

            CommonResourcePaginatedRespDto result = m_JsonService.DeserializeObject<CommonResourcePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 分页获取常规资源列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="keyword">查询条件</param>
        /// <param name="namespaceCodeList">权限空间列表</param>
        ///<returns>CommonResourcePaginatedRespDto</returns>
        public async Task<CommonResourcePaginatedRespDto> ListCommonResource1(ListCommonResourceDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-common-resource", reqDto).ConfigureAwait(false);

            CommonResourcePaginatedRespDto result = m_JsonService.DeserializeObject<CommonResourcePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 分页获取资源列表
        ///</summary>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        /// <param name="type">资源类型</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>ResourcePaginatedRespDto</returns>
        public async Task<ResourcePaginatedRespDto> ListResources(ListResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-resources", reqDto).ConfigureAwait(false);

            ResourcePaginatedRespDto result = m_JsonService.DeserializeObject<ResourcePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 分页获取资源列表
        ///</summary>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        /// <param name="type">资源类型</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>ResourcePaginatedRespDto</returns>
        public async Task<ResourcePaginatedRespDto> ListResources1(ListResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-resources", reqDto).ConfigureAwait(false);

            ResourcePaginatedRespDto result = m_JsonService.DeserializeObject<ResourcePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ResourceRespDto</returns>
        public async Task<ResourceRespDto> UpdateResource(UpdateResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-resource", requestBody).ConfigureAwait(false);

            ResourceRespDto result = m_JsonService.DeserializeObject<ResourceRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteResource(DeleteResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-resource", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteResourcesBatch(DeleteResourcesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-resources-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> BatchDeleteCommonResource(DeleteCommonResourcesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-common-resources-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 关联/取消关联应用资源到租户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AssociateTenantResource(AssociateTenantResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/associate-tenant-resource", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 关联/取消关联应用资源到租户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AssociateTenantResource1(AssociateTenantResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/associate-tenant-resource", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建权限分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>NamespaceRespDto</returns>
        public async Task<NamespaceRespDto> CreateNamespace(CreateNamespaceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-namespace", requestBody).ConfigureAwait(false);

            NamespaceRespDto result = m_JsonService.DeserializeObject<NamespaceRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建权限分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> CreateNamespacesBatch(CreateNamespacesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-namespaces-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取权限分组详情
        ///</summary>
        /// <param name="code">权限分组唯一标志符</param>
        ///<returns>NamespaceRespDto</returns>
        public async Task<NamespaceRespDto> GetNamespace(GetNamespaceDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-namespace", reqDto).ConfigureAwait(false);

            NamespaceRespDto result = m_JsonService.DeserializeObject<NamespaceRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取权限分组详情
        ///</summary>
        /// <param name="codeList">权限分组 code 列表，批量可以使用逗号分隔</param>
        ///<returns>NamespaceListRespDto</returns>
        public async Task<NamespaceListRespDto> GetNamespacesBatch(GetNamespacesBatchDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-namespaces-batch", reqDto).ConfigureAwait(false);

            NamespaceListRespDto result = m_JsonService.DeserializeObject<NamespaceListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改权限分组信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UpdateNamespaceRespDto</returns>
        public async Task<UpdateNamespaceRespDto> UpdateNamespace(UpdateNamespaceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-namespace", requestBody).ConfigureAwait(false);

            UpdateNamespaceRespDto result = m_JsonService.DeserializeObject<UpdateNamespaceRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除权限分组信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteNamespace(DeleteNamespaceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-namespace", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除权限分组
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteNamespacesBatch(DeleteNamespacesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-namespaces-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 分页获取权限分组列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="keywords">搜索权限分组 Code</param>
        ///<returns>NamespaceListPaginatedRespDto</returns>
        public async Task<NamespaceListPaginatedRespDto> ListNamespaces(ListNamespacesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-namespaces", reqDto).ConfigureAwait(false);

            NamespaceListPaginatedRespDto result = m_JsonService.DeserializeObject<NamespaceListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 分页权限分组下所有的角色列表
        ///</summary>
        /// <param name="code">权限分组唯一标志符</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="keywords">角色 Code 或者名称</param>
        ///<returns>NamespaceRolesListPaginatedRespDto</returns>
        public async Task<NamespaceRolesListPaginatedRespDto> ListNamespaceRoles(ListNamespaceRolesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-namespace-roles", reqDto).ConfigureAwait(false);

            NamespaceRolesListPaginatedRespDto result = m_JsonService.DeserializeObject<NamespaceRolesListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 授权资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AuthorizeResources(AuthorizeResourcesDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/authorize-resources", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 授权资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AuthorizeResources1(AuthorizeResourcesDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/authorize-resources", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取某个主体被授权的资源列表
        ///</summary>
        /// <param name="targetType">目标对象类型：
        /// - `USER`: 用户
        /// - `ROLE`: 角色
        /// - `GROUP`: 分组
        /// - `DEPARTMENT`: 部门
        /// </param>
        /// <param name="targetIdentifier">目标对象的唯一标志符：
        /// - 如果是用户，为用户的 ID，如 `6343b98b7cfxxx9366e9b7c`
        /// - 如果是角色，为角色的 code，如 `admin`
        /// - 如果是分组，为分组的 code，如 `developer`
        /// - 如果是部门，为部门的 ID，如 `6343bafc019xxxx889206c4c`
        /// </param>
        /// <param name="nameSpace">所属权限分组(权限空间)的 Code</param>
        /// <param name="resourceType">限定资源类型，如数据、API、按钮、菜单</param>
        /// <param name="resourceList">限定查询的资源列表，如果指定，只会返回所指定的资源列表。
        ///
        /// resourceList 参数支持前缀匹配，例如：
        /// - 授权了一个资源为 `books:123`，可以通过 `books:*` 来匹配；
        /// - 授权了一个资源为 `books:fictions_123`，可以通过 `books:fictions_` 来匹配；
        /// </param>
        /// <param name="withDenied">是否获取被拒绝的资源</param>
        ///<returns>AuthorizedResourcePaginatedRespDto</returns>
        public async Task<AuthorizedResourcePaginatedRespDto> GetAuthorizedResources(GetAuthorizedResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-authorized-resources", reqDto).ConfigureAwait(false);

            AuthorizedResourcePaginatedRespDto result = m_JsonService.DeserializeObject<AuthorizedResourcePaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 判断用户是否对某个资源的某个操作有权限
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsActionAllowedRespDtp</returns>
        public async Task<IsActionAllowedRespDtp> IsActionAllowed(IsActionAllowedDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/is-action-allowed", requestBody).ConfigureAwait(false);

            IsActionAllowedRespDtp result = m_JsonService.DeserializeObject<IsActionAllowedRespDtp>(httpResponse);
            return result;
        }
        ///<summary>
        /// 判断用户是否对某个资源的某个操作有权限
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsActionAllowedRespDtp</returns>
        public async Task<IsActionAllowedRespDtp> IsActionAllowed1(IsActionAllowedDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/is-action-allowed", requestBody).ConfigureAwait(false);

            IsActionAllowedRespDtp result = m_JsonService.DeserializeObject<IsActionAllowedRespDtp>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取资源被授权的主体
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GetResourceAuthorizedTargetRespDto</returns>
        public async Task<GetResourceAuthorizedTargetRespDto> GetResourceAuthorizedTargets(GetResourceAuthorizedTargetsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-resource-authorized-targets", requestBody).ConfigureAwait(false);

            GetResourceAuthorizedTargetRespDto result = m_JsonService.DeserializeObject<GetResourceAuthorizedTargetRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户行为日志
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserActionLogRespDto</returns>
        public async Task<UserActionLogRespDto> GetUserActionLogs(GetUserActionLogsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-user-action-logs", requestBody).ConfigureAwait(false);

            UserActionLogRespDto result = m_JsonService.DeserializeObject<UserActionLogRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取管理员操作日志
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>AdminAuditLogRespDto</returns>
        public async Task<AdminAuditLogRespDto> GetAdminAuditLogs(GetAdminAuditLogsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-admin-audit-logs", requestBody).ConfigureAwait(false);

            AdminAuditLogRespDto result = m_JsonService.DeserializeObject<AdminAuditLogRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取邮件模版列表
        ///</summary>
        ///<returns>GetEmailTemplatesRespDto</returns>
        public async Task<GetEmailTemplatesRespDto> GetEmailTemplates()
        {
            string httpResponse = await Request("GET", "/api/v3/get-email-templates").ConfigureAwait(false);

            GetEmailTemplatesRespDto result = m_JsonService.DeserializeObject<GetEmailTemplatesRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改邮件模版
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>EmailTemplateSingleItemRespDto</returns>
        public async Task<EmailTemplateSingleItemRespDto> UpdateEmailTemplate(UpdateEmailTemplateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-email-template", requestBody).ConfigureAwait(false);

            EmailTemplateSingleItemRespDto result = m_JsonService.DeserializeObject<EmailTemplateSingleItemRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 预览邮件模版
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PreviewEmailTemplateRespDto</returns>
        public async Task<PreviewEmailTemplateRespDto> PreviewEmailTemplate(PreviewEmailTemplateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/preview-email-template", requestBody).ConfigureAwait(false);

            PreviewEmailTemplateRespDto result = m_JsonService.DeserializeObject<PreviewEmailTemplateRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取第三方邮件服务配置
        ///</summary>
        ///<returns>EmailProviderRespDto</returns>
        public async Task<EmailProviderRespDto> GetEmailProvider()
        {
            string httpResponse = await Request("GET", "/api/v3/get-email-provider").ConfigureAwait(false);

            EmailProviderRespDto result = m_JsonService.DeserializeObject<EmailProviderRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 配置第三方邮件服务
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>EmailProviderRespDto</returns>
        public async Task<EmailProviderRespDto> ConfigEmailProvider(ConfigEmailProviderDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/config-email-provider", requestBody).ConfigureAwait(false);

            EmailProviderRespDto result = m_JsonService.DeserializeObject<EmailProviderRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取应用详情
        ///</summary>
        /// <param name="appId">应用 ID</param>
        ///<returns>ApplicationSingleRespDto</returns>
        public async Task<ApplicationSingleRespDto> GetApplication(GetApplicationDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-application", reqDto).ConfigureAwait(false);

            ApplicationSingleRespDto result = m_JsonService.DeserializeObject<ApplicationSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取应用详情
        ///</summary>
        /// <param name="appId">应用 ID</param>
        ///<returns>ApplicationSingleRespDto</returns>
        public async Task<ApplicationSingleRespDto> GetApplication1(GetApplicationDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-application", reqDto).ConfigureAwait(false);

            ApplicationSingleRespDto result = m_JsonService.DeserializeObject<ApplicationSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 主体授权详情
        ///</summary>
        /// <param name="targetId">主体 id</param>
        /// <param name="targetType">主体类型</param>
        /// <param name="appId">应用 ID</param>
        ///<returns>GetSubjectAuthRespDto</returns>
        public async Task<GetSubjectAuthRespDto> DetailAuthSubject(GetSubjectAuthDetailDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-subject-auth-detail", reqDto).ConfigureAwait(false);

            GetSubjectAuthRespDto result = m_JsonService.DeserializeObject<GetSubjectAuthRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 主体授权列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ListApplicationSubjectRespDto</returns>
        public async Task<ListApplicationSubjectRespDto> ListAuthSubject(ListAuthSubjectDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-subject-auth", requestBody).ConfigureAwait(false);

            ListApplicationSubjectRespDto result = m_JsonService.DeserializeObject<ListApplicationSubjectRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 应用授权列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ListApplicationAuthPaginatedRespDto</returns>
        public async Task<ListApplicationAuthPaginatedRespDto> ListAuthApplication(ListApplicationAuthDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-applications-auth", requestBody).ConfigureAwait(false);

            ListApplicationAuthPaginatedRespDto result = m_JsonService.DeserializeObject<ListApplicationAuthPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新授权开关
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> EnabledAuth(UpdateAuthEnabledDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-auth-enabled", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除应用授权
        ///</summary>
        /// <param name="authIds">授权 ID</param>
        ///<returns>IsSuccessRespDto</returns>
        ///<summary>
        /// 获取应用列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="isIntegrateApp">是否为集成应用</param>
        /// <param name="isSelfBuiltApp">是否为自建应用</param>
        /// <param name="ssoEnabled">是否开启单点登录</param>
        /// <param name="keywords">模糊搜索字符串</param>
        /// <param name="all">搜索应用，true：搜索所有应用, 默认为 false</param>
        ///<returns>ApplicationPaginatedRespDto</returns>
        public async Task<ApplicationPaginatedRespDto> ListApplications(ListApplicationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-applications", reqDto).ConfigureAwait(false);

            ApplicationPaginatedRespDto result = m_JsonService.DeserializeObject<ApplicationPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取应用简单信息
        ///</summary>
        /// <param name="appId">应用 ID</param>
        ///<returns>ApplicationSimpleInfoSingleRespDto</returns>
        public async Task<ApplicationSimpleInfoSingleRespDto> GetApplicationSimpleInfo(GetApplicationSimpleInfoDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-application-simple-info", reqDto).ConfigureAwait(false);

            ApplicationSimpleInfoSingleRespDto result = m_JsonService.DeserializeObject<ApplicationSimpleInfoSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取应用简单信息
        ///</summary>
        /// <param name="appId">应用 ID</param>
        ///<returns>ApplicationSimpleInfoSingleRespDto</returns>
        public async Task<ApplicationSimpleInfoSingleRespDto> GetApplicationSimpleInfo1(GetApplicationSimpleInfoDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-application-simple-info", reqDto).ConfigureAwait(false);

            ApplicationSimpleInfoSingleRespDto result = m_JsonService.DeserializeObject<ApplicationSimpleInfoSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取应用简单信息列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="isIntegrateApp">是否为集成应用</param>
        /// <param name="isSelfBuiltApp">是否为自建应用</param>
        /// <param name="ssoEnabled">是否开启单点登录</param>
        /// <param name="keywords">模糊搜索字符串</param>
        ///<returns>ApplicationSimpleInfoPaginatedRespDto</returns>
        public async Task<ApplicationSimpleInfoPaginatedRespDto> ListApplicationSimpleInfo(ListApplicationSimpleInfoDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-application-simple-info", reqDto).ConfigureAwait(false);

            ApplicationSimpleInfoPaginatedRespDto result = m_JsonService.DeserializeObject<ApplicationSimpleInfoPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建应用
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateApplicationRespDto</returns>
        public async Task<CreateApplicationRespDto> CreateApplication(CreateApplicationDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-application", requestBody).ConfigureAwait(false);

            CreateApplicationRespDto result = m_JsonService.DeserializeObject<CreateApplicationRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除应用
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteApplication(DeleteApplicationDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-application", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取应用密钥
        ///</summary>
        /// <param name="appId">应用 ID</param>
        ///<returns>GetApplicationSecretRespDto</returns>
        public async Task<GetApplicationSecretRespDto> GetApplicationSecret(GetApplicationSecretDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-application-secret", reqDto).ConfigureAwait(false);

            GetApplicationSecretRespDto result = m_JsonService.DeserializeObject<GetApplicationSecretRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 刷新应用密钥
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>RefreshApplicationSecretRespDto</returns>
        public async Task<RefreshApplicationSecretRespDto> RefreshApplicationSecret(RefreshApplicationSecretDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/refresh-application-secret", requestBody).ConfigureAwait(false);

            RefreshApplicationSecretRespDto result = m_JsonService.DeserializeObject<RefreshApplicationSecretRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取应用当前登录用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UserPaginatedRespDto</returns>
        public async Task<UserPaginatedRespDto> ListApplicationActiveUsers(ListApplicationActiveUsersDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-application-active-users", requestBody).ConfigureAwait(false);

            UserPaginatedRespDto result = m_JsonService.DeserializeObject<UserPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取应用默认访问授权策略
        ///</summary>
        /// <param name="appId">应用 ID</param>
        ///<returns>GetApplicationPermissionStrategyRespDto</returns>
        public async Task<GetApplicationPermissionStrategyRespDto> GetApplicationPermissionStrategy(GetApplicationPermissionStrategyDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-application-permission-strategy", reqDto).ConfigureAwait(false);

            GetApplicationPermissionStrategyRespDto result = m_JsonService.DeserializeObject<GetApplicationPermissionStrategyRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 更新应用默认访问授权策略
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UpdateApplicationPermissionStrategy(UpdateApplicationPermissionStrategyDataDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-application-permission-strategy", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 授权应用访问权限
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AuthorizeApplicationAccess(AuthorizeApplicationAccessDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/authorize-application-access", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 授权应用访问权限
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AuthorizeApplicationAccess1(AuthorizeApplicationAccessDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/authorize-application-access", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除应用访问授权记录
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> RevokeApplicationAccess(RevokeApplicationAccessDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/revoke-application-access", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除应用访问授权记录
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> RevokeApplicationAccess1(RevokeApplicationAccessDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/revoke-application-access", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 检测域名是否可用
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CheckDomainAvailableSecretRespDto</returns>
        public async Task<CheckDomainAvailableSecretRespDto> CheckDomainAvailable(CheckDomainAvailable requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-domain-available", requestBody).ConfigureAwait(false);

            CheckDomainAvailableSecretRespDto result = m_JsonService.DeserializeObject<CheckDomainAvailableSecretRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取租户应用列表
        ///</summary>
        /// <param name="page">获取应用列表的页码</param>
        /// <param name="limit">每页获取的应用数量</param>
        /// <param name="keywords">搜索关键字</param>
        /// <param name="ssoEnabled">应用是否加入单点登录</param>
        ///<returns>TenantApplicationListPaginatedRespDto</returns>
        public async Task<TenantApplicationListPaginatedRespDto> ListTenantApplications(ListTenantApplicationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-tenant-applications", reqDto).ConfigureAwait(false);

            TenantApplicationListPaginatedRespDto result = m_JsonService.DeserializeObject<TenantApplicationListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取租户应用列表
        ///</summary>
        /// <param name="page">获取应用列表的页码</param>
        /// <param name="limit">每页获取的应用数量</param>
        /// <param name="keywords">搜索关键字</param>
        /// <param name="ssoEnabled">应用是否加入单点登录</param>
        ///<returns>TenantApplicationListPaginatedRespDto</returns>
        public async Task<TenantApplicationListPaginatedRespDto> ListTenantApplications1(ListTenantApplicationsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-tenant-applications", reqDto).ConfigureAwait(false);

            TenantApplicationListPaginatedRespDto result = m_JsonService.DeserializeObject<TenantApplicationListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 更新应用登录页配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UpdateLoginPageConfig(UpdateLoginConfigDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-login-page-config", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户池租户配置信息
        ///</summary>
        ///<returns>UserPoolTenantConfigDtoRespDto</returns>
        public async Task<UserPoolTenantConfigDtoRespDto> UserpollTenantConfig()
        {
            string httpResponse = await Request("GET", "/api/v3/userpool-tenant-config").ConfigureAwait(false);

            UserPoolTenantConfigDtoRespDto result = m_JsonService.DeserializeObject<UserPoolTenantConfigDtoRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 更新用户池租户配置信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UpdateUserPoolTenantConfig(UpdateUserPoolTenantLoginConfigDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-userpool-tenant-config", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新租户控制台扫码登录状态
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UpdateTenantQrCodeState(UpdateTenantAppqrcodeState requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-userpool-tenant-appqrcode-state", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 设置用户池多租户身份源连接
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> ChangeUserpoolTenanExtIdpConnState(ChangeUserPoolTenantExtIdpConnDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/change-userpool-tenant-ext-idp-conn-state", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改应用多因素认证配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>MFASettingsRespDto</returns>
        public async Task<MFASettingsRespDto> UpdateApplicationMfaSettings(UpdateApplicationMfaSettingsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-application-mfa-settings", requestBody).ConfigureAwait(false);

            MFASettingsRespDto result = m_JsonService.DeserializeObject<MFASettingsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取应用下用户 MFA 触发数据
        ///</summary>
        /// <param name="appId">所属应用 ID</param>
        /// <param name="userId">用户的唯一标志，可以是用户 ID、用户名、邮箱、手机号、externalId、在外部身份源的 ID，详情见 userIdType 字段的说明。默认为用户 id 。</param>
        /// <param name="userIdType">用户 ID 类型，默认值为 `user_id`，可选值为：
        /// - `user_id`: Authing 用户 ID，如 `6319a1504f3xxxxf214dd5b7`
        /// - `phone`: 用户手机号
        /// - `email`: 用户邮箱
        /// - `username`: 用户名
        /// - `external_id`: 用户在外部系统的 ID，对应 Authing 用户信息的 `externalId` 字段
        /// - `identity`: 用户的外部身份源信息，格式为 `<extIdpId>:<userIdInIdp>`，其中 `<extIdpId>` 为 Authing 身份源的 ID，`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`62f20932716fbcc10d966ee5:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// - `sync_relation`: 用户的外部身份源信息，格式为 `<provier>:<userIdInIdp>`，其中 `<provier>` 为同步身份源类型，如 wechatwork, lark；`<userIdInIdp>` 为用户在外部身份源的 ID。
        /// 示例值：`lark:ou_8bae746eac07cd2564654140d2a9ac61`。
        /// </param>
        ///<returns>GetMapInfoRespDto</returns>
        public async Task<GetMapInfoRespDto> GetMfaTriggerData(GetMfaTriggerDataDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-mfa-trigger-data", reqDto).ConfigureAwait(false);

            GetMapInfoRespDto result = m_JsonService.DeserializeObject<GetMapInfoRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>AsaAccountSingleRespDto</returns>
        public async Task<AsaAccountSingleRespDto> CreateAsaAccount(CreateAsaAccountDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-asa-account", requestBody).ConfigureAwait(false);

            AsaAccountSingleRespDto result = m_JsonService.DeserializeObject<AsaAccountSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> CreateAsaAccountBatch(CreateAsaAccountsBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-asa-accounts-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>AsaAccountSingleRespDto</returns>
        public async Task<AsaAccountSingleRespDto> UpdateAsaAccount(UpdateAsaAccountDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-asa-account", requestBody).ConfigureAwait(false);

            AsaAccountSingleRespDto result = m_JsonService.DeserializeObject<AsaAccountSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 ASA 账号列表
        ///</summary>
        /// <param name="appId">所属应用 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>AsaAccountPaginatedRespDto</returns>
        public async Task<AsaAccountPaginatedRespDto> ListAsaAccount(ListAsaAccountsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-asa-accounts", reqDto).ConfigureAwait(false);

            AsaAccountPaginatedRespDto result = m_JsonService.DeserializeObject<AsaAccountPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取 ASA 账号
        ///</summary>
        /// <param name="appId">所属应用 ID</param>
        /// <param name="accountId">ASA 账号 ID</param>
        ///<returns>AsaAccountSingleRespDto</returns>
        public async Task<AsaAccountSingleRespDto> GetAsaAccount(GetAsaAccountDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-asa-account", reqDto).ConfigureAwait(false);

            AsaAccountSingleRespDto result = m_JsonService.DeserializeObject<AsaAccountSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>AsaAccountListRespDto</returns>
        public async Task<AsaAccountListRespDto> GetAsaAccountBatch(GetAsaAccountBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-asa-accounts-batch", requestBody).ConfigureAwait(false);

            AsaAccountListRespDto result = m_JsonService.DeserializeObject<AsaAccountListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteAsaAccount(DeleteAsaAccountDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-asa-account", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteAsaAccountBatch(DeleteAsaAccountBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-asa-accounts-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 分配 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AssignAsaAccount(AssignAsaAccountsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/assign-asa-account", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 取消分配 ASA 账号
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UnassignAsaAccount(AssignAsaAccountsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/unassign-asa-account", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 ASA 账号分配的主体列表
        ///</summary>
        /// <param name="appId">所属应用 ID</param>
        /// <param name="accountId">ASA 账号 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>GetAsaAccountAssignedTargetRespDto</returns>
        public async Task<GetAsaAccountAssignedTargetRespDto> GetAsaAccountAssignedTargets(GetAsaAccountAssignedTargetsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-asa-account-assigned-targets", reqDto).ConfigureAwait(false);

            GetAsaAccountAssignedTargetRespDto result = m_JsonService.DeserializeObject<GetAsaAccountAssignedTargetRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取主体被分配的 ASA 账号
        ///</summary>
        /// <param name="appId">所属应用 ID</param>
        /// <param name="targetType">目标对象类型：
        /// - `USER`: 用户
        /// - `ROLE`: 角色
        /// - `GROUP`: 分组
        /// - `DEPARTMENT`: 部门
        /// </param>
        /// <param name="targetIdentifier">目标对象的唯一标志符：
        /// - 如果是用户，为用户的 ID，如 `6343b98b7cfxxx9366e9b7c`
        /// - 如果是角色，为角色的 code，如 `admin`
        /// - 如果是分组，为分组的 code，如 `developer`
        /// - 如果是部门，为部门的 ID，如 `6343bafc019xxxx889206c4c`
        /// </param>
        ///<returns>AsaAccountSingleNullableRespDto</returns>
        public async Task<AsaAccountSingleNullableRespDto> GetAssignedAccount(GetAssignedAccountDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-assigned-account", reqDto).ConfigureAwait(false);

            AsaAccountSingleNullableRespDto result = m_JsonService.DeserializeObject<AsaAccountSingleNullableRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取安全配置
        ///</summary>
        ///<returns>SecuritySettingsRespDto</returns>
        public async Task<SecuritySettingsRespDto> GetSecuritySettings()
        {
            string httpResponse = await Request("GET", "/api/v3/get-security-settings").ConfigureAwait(false);

            SecuritySettingsRespDto result = m_JsonService.DeserializeObject<SecuritySettingsRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改安全配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>SecuritySettingsRespDto</returns>
        public async Task<SecuritySettingsRespDto> UpdateSecuritySettings(UpdateSecuritySettingsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-security-settings", requestBody).ConfigureAwait(false);

            SecuritySettingsRespDto result = m_JsonService.DeserializeObject<SecuritySettingsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取全局多因素认证配置
        ///</summary>
        ///<returns>MFASettingsRespDto</returns>
        public async Task<MFASettingsRespDto> GetGlobalMfaSettings()
        {
            string httpResponse = await Request("GET", "/api/v3/get-global-mfa-settings").ConfigureAwait(false);

            MFASettingsRespDto result = m_JsonService.DeserializeObject<MFASettingsRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改全局多因素认证配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>MFASettingsRespDto</returns>
        public async Task<MFASettingsRespDto> UpdateGlobalMfaSettings(MFASettingsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-global-mfa-settings", requestBody).ConfigureAwait(false);

            MFASettingsRespDto result = m_JsonService.DeserializeObject<MFASettingsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建租户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateTenantRespDto</returns>
        public async Task<CreateTenantRespDto> CreateTenant(CreateTenantDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-tenant", requestBody).ConfigureAwait(false);

            CreateTenantRespDto result = m_JsonService.DeserializeObject<CreateTenantRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建租户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateTenantRespDto</returns>
        public async Task<CreateTenantRespDto> CreateTenant1(CreateTenantDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-tenant", requestBody).ConfigureAwait(false);

            CreateTenantRespDto result = m_JsonService.DeserializeObject<CreateTenantRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新租户数据
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UpdateTenant(UpdateTenantDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-tenant", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新租户数据
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UpdateTenant1(UpdateTenantDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-tenant", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除租户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteTenant(DeleteTenantDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-tenant", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除租户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeleteTenant1(DeleteTenantDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-tenant", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取/搜索租户列表
        ///</summary>
        /// <param name="keywords">搜索关键字</param>
        /// <param name="withMembersCount">是否增加返回租户成员统计</param>
        /// <param name="withAppDetail">增加返回租户下 app 简单信息</param>
        /// <param name="withCreatorDetail">增加返回租户下创建者简单信息</param>
        /// <param name="withSourceAppDetail">增加返回租户下来源 app 简单信息</param>
        /// <param name="page">页码</param>
        /// <param name="limit">每页获取的数据量</param>
        /// <param name="source">租户来源</param>
        ///<returns>TenantListPaginatedRespDto</returns>
        public async Task<TenantListPaginatedRespDto> ListTenants(ListTenantsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-tenants", reqDto).ConfigureAwait(false);

            TenantListPaginatedRespDto result = m_JsonService.DeserializeObject<TenantListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取/搜索租户列表
        ///</summary>
        /// <param name="keywords">搜索关键字</param>
        /// <param name="withMembersCount">是否增加返回租户成员统计</param>
        /// <param name="withAppDetail">增加返回租户下 app 简单信息</param>
        /// <param name="withCreatorDetail">增加返回租户下创建者简单信息</param>
        /// <param name="withSourceAppDetail">增加返回租户下来源 app 简单信息</param>
        /// <param name="page">页码</param>
        /// <param name="limit">每页获取的数据量</param>
        /// <param name="source">租户来源</param>
        ///<returns>TenantListPaginatedRespDto</returns>
        public async Task<TenantListPaginatedRespDto> ListTenants1(ListTenantsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-tenants", reqDto).ConfigureAwait(false);

            TenantListPaginatedRespDto result = m_JsonService.DeserializeObject<TenantListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取租户一点点的信息
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="withMembersCount">是否增加返回租户成员统计</param>
        /// <param name="withAppDetail">增加返回租户关联应用简单信息</param>
        /// <param name="withCreatorDetail">增加返回租户下创建者简单信息</param>
        /// <param name="withSourceAppDetail">增加返回租户来源应用简单信息</param>
        ///<returns>TenantSingleRespDto</returns>
        public async Task<TenantSingleRespDto> GetTenantLittleInfo(GetTenantLittleInfoDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-tenant-little-info", reqDto).ConfigureAwait(false);

            TenantSingleRespDto result = m_JsonService.DeserializeObject<TenantSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取租户一点点的信息
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="withMembersCount">是否增加返回租户成员统计</param>
        /// <param name="withAppDetail">增加返回租户关联应用简单信息</param>
        /// <param name="withCreatorDetail">增加返回租户下创建者简单信息</param>
        /// <param name="withSourceAppDetail">增加返回租户来源应用简单信息</param>
        ///<returns>TenantSingleRespDto</returns>
        public async Task<TenantSingleRespDto> GetTenantLittleInfo1(GetTenantLittleInfoDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-tenant-little-info", reqDto).ConfigureAwait(false);

            TenantSingleRespDto result = m_JsonService.DeserializeObject<TenantSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取租户详情
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="withMembersCount">是否增加返回租户成员统计</param>
        /// <param name="withAppDetail">增加返回租户关联应用简单信息</param>
        /// <param name="withCreatorDetail">增加返回租户下创建者简单信息</param>
        /// <param name="withSourceAppDetail">增加返回租户来源应用简单信息</param>
        ///<returns>TenantSingleRespDto</returns>
        public async Task<TenantSingleRespDto> GetTenant(GetTenantDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-tenant", reqDto).ConfigureAwait(false);

            TenantSingleRespDto result = m_JsonService.DeserializeObject<TenantSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取租户详情
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="withMembersCount">是否增加返回租户成员统计</param>
        /// <param name="withAppDetail">增加返回租户关联应用简单信息</param>
        /// <param name="withCreatorDetail">增加返回租户下创建者简单信息</param>
        /// <param name="withSourceAppDetail">增加返回租户来源应用简单信息</param>
        ///<returns>TenantSingleRespDto</returns>
        public async Task<TenantSingleRespDto> GetTenant1(GetTenantDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-tenant", reqDto).ConfigureAwait(false);

            TenantSingleRespDto result = m_JsonService.DeserializeObject<TenantSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 导入租户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ImportTenantRespDto</returns>
        public async Task<ImportTenantRespDto> ImportTenant(ImportTenantDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/import-tenant", requestBody).ConfigureAwait(false);

            ImportTenantRespDto result = m_JsonService.DeserializeObject<ImportTenantRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 导入租户历史
        ///</summary>
        /// <param name="page">页码</param>
        /// <param name="limit">每页获取的数据量</param>
        ///<returns>ImportTenantHistoryRespDto</returns>
        public async Task<ImportTenantHistoryRespDto> ImportTenantHistory(ImportTenantHistoryDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/import-tenant-history", reqDto).ConfigureAwait(false);

            ImportTenantHistoryRespDto result = m_JsonService.DeserializeObject<ImportTenantHistoryRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 导入租户通知用户列表
        ///</summary>
        /// <param name="importId">导入记录 id</param>
        /// <param name="page">页码</param>
        /// <param name="limit">每页获取的数据量</param>
        ///<returns>ImportTenantNotifyUserRespDto</returns>
        public async Task<ImportTenantNotifyUserRespDto> ImportTenantNotifyUser(ImportTenantNotifyUserDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/import-tenant-notify-user", reqDto).ConfigureAwait(false);

            ImportTenantNotifyUserRespDto result = m_JsonService.DeserializeObject<ImportTenantNotifyUserRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 导入租户通知邮箱用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>SendEmailBatchDataDto</returns>
        public async Task<SendEmailBatchDataDto> SendEmailBatch(SendManyTenantEmailDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/send-email-batch", requestBody).ConfigureAwait(false);

            SendEmailBatchDataDto result = m_JsonService.DeserializeObject<SendEmailBatchDataDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 导入租户短信通知用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>SendSmsBatchRespDto</returns>
        public async Task<SendSmsBatchRespDto> SendSmsBatch(SendManyTenantSmsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/send-sms-batch", requestBody).ConfigureAwait(false);

            SendSmsBatchRespDto result = m_JsonService.DeserializeObject<SendSmsBatchRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取租户管理员列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>TenantUserListPaginatedRespDto</returns>
        public async Task<TenantUserListPaginatedRespDto> ListTenantAdmin(ListTenantAdminDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-tenant-admin", requestBody).ConfigureAwait(false);

            TenantUserListPaginatedRespDto result = m_JsonService.DeserializeObject<TenantUserListPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取租户管理员列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>TenantUserListPaginatedRespDto</returns>
        public async Task<TenantUserListPaginatedRespDto> ListTenantAdmin1(ListTenantAdminDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-tenant-admin", requestBody).ConfigureAwait(false);

            TenantUserListPaginatedRespDto result = m_JsonService.DeserializeObject<TenantUserListPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 设置租户管理员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> SetTenantAdmin(RemoveTenantUsersDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-tenant-admin", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 设置租户管理员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> SetTenantAdmin1(RemoveTenantUsersDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/set-tenant-admin", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 取消设置租户管理员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeleteTenantAdmin(GetTenantUserDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-tenant-admin", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 取消设置租户管理员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeleteTenantAdmin1(GetTenantUserDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-tenant-admin", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量移除租户成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeleteTenantUser(RemoveTenantUsersDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-tenant-user", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 生成一个邀请租户成员的链接
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>InviteTenantUsersRespDto</returns>
        public async Task<InviteTenantUsersRespDto> GenerateInviteTenantUserLink(GenerateInviteTenantUserLink requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/generate-invite-tenant-user-link", requestBody).ConfigureAwait(false);

            InviteTenantUsersRespDto result = m_JsonService.DeserializeObject<InviteTenantUsersRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取可访问的租户控制台列表
        ///</summary>
        /// <param name="keywords">搜索关键字</param>
        /// <param name="page">页码</param>
        /// <param name="limit">每页获取的数据量</param>
        ///<returns>InviteTenantUserRecordListRespDto</returns>
        public async Task<InviteTenantUserRecordListRespDto> ListInviteTennatUserRecords(ListInviteTenantUserRecordsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-invite-tenant-user-records", reqDto).ConfigureAwait(false);

            InviteTenantUserRecordListRespDto result = m_JsonService.DeserializeObject<InviteTenantUserRecordListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取多租户管理员用户列表
        ///</summary>
        /// <param name="keywords">搜索关键字</param>
        /// <param name="page">页码</param>
        /// <param name="limit">每页获取的数据量</param>
        ///<returns>MultipleTenantAdminPaginatedRespDto</returns>
        public async Task<MultipleTenantAdminPaginatedRespDto> ListMultipleTenantAdmin(ListMultipleTenantAdminsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-multiple-tenant-admins", reqDto).ConfigureAwait(false);

            MultipleTenantAdminPaginatedRespDto result = m_JsonService.DeserializeObject<MultipleTenantAdminPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建多租户管理员用户
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> CreateMultipleTenantAdmin(CreateMultipleTenantAdminDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-multiple-tenant-admin", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取多租户管理员用户列表
        ///</summary>
        /// <param name="userId">用户 ID</param>
        ///<returns>MultipleTenantAdminPaginatedRespDto</returns>
        public async Task<MultipleTenantAdminPaginatedRespDto> GetMultipleTenantAdmin(GetMultipleTenantAdminDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-multiple-tenant-admin", reqDto).ConfigureAwait(false);

            MultipleTenantAdminPaginatedRespDto result = m_JsonService.DeserializeObject<MultipleTenantAdminPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取协作管理员用户列表
        ///</summary>
        /// <param name="keywords">搜索关键字</param>
        /// <param name="external">是否外部</param>
        /// <param name="page">页码</param>
        /// <param name="limit">每页获取的数据量</param>
        ///<returns>TenantCooperatorPaginatedRespDto</returns>
        public async Task<TenantCooperatorPaginatedRespDto> ListTenantCooperators(ListTenantCooperatorsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-tenant-cooperators", reqDto).ConfigureAwait(false);

            TenantCooperatorPaginatedRespDto result = m_JsonService.DeserializeObject<TenantCooperatorPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取一个协调管理员
        ///</summary>
        /// <param name="userId">用户 ID</param>
        ///<returns>TenantCooperatorSingleRespDto</returns>
        public async Task<TenantCooperatorSingleRespDto> GetTenantCooperator(GetTenantCooperatorDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-tenant-cooperator", reqDto).ConfigureAwait(false);

            TenantCooperatorSingleRespDto result = m_JsonService.DeserializeObject<TenantCooperatorSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取一个协调管理员拥有的列表
        ///</summary>
        /// <param name="userId">用户 ID</param>
        ///<returns>TenantCooperatorSingleRespDto</returns>
        public async Task<TenantCooperatorSingleRespDto> GetTenantCooperatorMenu(GetTenantCooperatorMenuDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-tenant-cooperator-menu", reqDto).ConfigureAwait(false);

            TenantCooperatorSingleRespDto result = m_JsonService.DeserializeObject<TenantCooperatorSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建协调管理员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> CreateTenantCooperator(CreateTenantCooperatorDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-tenant-cooperator", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取租户详情
        ///</summary>
        /// <param name="code">租户 Code</param>
        ///<returns>TenantSingleRespDto</returns>
        public async Task<TenantSingleRespDto> GetTenantByCode(GetTenantByCodeDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-tenant-by-code", reqDto).ConfigureAwait(false);

            TenantSingleRespDto result = m_JsonService.DeserializeObject<TenantSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取租户详情
        ///</summary>
        /// <param name="code">租户 Code</param>
        ///<returns>TenantSingleRespDto</returns>
        public async Task<TenantSingleRespDto> GetTenantByCode1(GetTenantByCodeDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-tenant-by-code", reqDto).ConfigureAwait(false);

            TenantSingleRespDto result = m_JsonService.DeserializeObject<TenantSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 发送邀请租户用户邮件
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> SendInviteTenantUserEmail(SendInviteTenantUserEmailDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/send-invite-tenant-user-email", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 添加租户成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> AddTenantUsers(AddTenantUsersDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/add-tenant-users", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量移除租户成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> RemoveTenantUsers(RemoveTenantUsersDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/remove-tenant-users", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新租户成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> UpdateTenantUser(UpdateTenantUserDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-tenant-user", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建租户成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>TenantUserDto</returns>
        public async Task<TenantUserDto> CreateTenantUser(CreateTenantUserReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-tenant-user", requestBody).ConfigureAwait(false);

            TenantUserDto result = m_JsonService.DeserializeObject<TenantUserDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取/搜索租户成员列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>TenantUserListPaginatedRespDto</returns>
        public async Task<TenantUserListPaginatedRespDto> ListTenantUsers(ListTenantUserDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-tenant-users", requestBody).ConfigureAwait(false);

            TenantUserListPaginatedRespDto result = m_JsonService.DeserializeObject<TenantUserListPaginatedRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取单个租户成员
        ///</summary>
        /// <param name="tenantId">租户 ID</param>
        /// <param name="linkUserId">关联的用户池级别的用户 ID</param>
        /// <param name="memberId">租户成员 ID</param>
        ///<returns>TenantUserSingleRespDto</returns>
        public async Task<TenantUserSingleRespDto> GetTenantUser(GetTenantUserDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-tenant-user", reqDto).ConfigureAwait(false);

            TenantUserSingleRespDto result = m_JsonService.DeserializeObject<TenantUserSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 租户部门下添加成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> AddTenantDepartmentMembers(AddTenantDepartmentMembersReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/add-tenant-department-members", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 租户部门下删除成员
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> RemoveTenantDepartmentMembers(RemoveTenantDepartmentMembersReqDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/remove-tenant-department-members", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建权限空间
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreatePermissionNamespaceResponseDto</returns>
        public async Task<CreatePermissionNamespaceResponseDto> CreatePermissionNamespace(CreatePermissionNamespaceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-permission-namespace", requestBody).ConfigureAwait(false);

            CreatePermissionNamespaceResponseDto result = m_JsonService.DeserializeObject<CreatePermissionNamespaceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量创建权限空间
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> CreatePermissionNamespacesBatch(CreatePermissionNamespacesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-permission-namespaces-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取权限空间详情
        ///</summary>
        /// <param name="code">权限空间 Code</param>
        ///<returns>GetPermissionNamespaceResponseDto</returns>
        public async Task<GetPermissionNamespaceResponseDto> GetPermissionNamespace(GetPermissionNamespaceDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-permission-namespace", reqDto).ConfigureAwait(false);

            GetPermissionNamespaceResponseDto result = m_JsonService.DeserializeObject<GetPermissionNamespaceResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 批量获取权限空间详情列表
        ///</summary>
        /// <param name="codes">权限空间 code 列表，批量可以使用逗号分隔</param>
        ///<returns>GetPermissionNamespaceListResponseDto</returns>
        public async Task<GetPermissionNamespaceListResponseDto> GetPermissionNamespacesBatch(GetPermissionNamespacesBatchDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-permission-namespaces-batch", reqDto).ConfigureAwait(false);

            GetPermissionNamespaceListResponseDto result = m_JsonService.DeserializeObject<GetPermissionNamespaceListResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 分页获取权限空间列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">权限空间 name</param>
        ///<returns>PermissionNamespaceListPaginatedRespDto</returns>
        public async Task<PermissionNamespaceListPaginatedRespDto> ListPermissionNamespaces(ListPermissionNamespacesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-permission-namespaces", reqDto).ConfigureAwait(false);

            PermissionNamespaceListPaginatedRespDto result = m_JsonService.DeserializeObject<PermissionNamespaceListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改权限空间
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UpdatePermissionNamespaceResponseDto</returns>
        public async Task<UpdatePermissionNamespaceResponseDto> UpdatePermissionNamespace(UpdatePermissionNamespaceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-permission-namespace", requestBody).ConfigureAwait(false);

            UpdatePermissionNamespaceResponseDto result = m_JsonService.DeserializeObject<UpdatePermissionNamespaceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除权限空间
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeletePermissionNamespace(DeletePermissionNamespaceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-permission-namespace", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 批量删除权限空间
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> DeletePermissionNamespacesBatch(DeletePermissionNamespacesBatchDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-permission-namespaces-batch", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 校验权限空间 Code 或者名称是否可用
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PermissionNamespaceCheckExistsRespDto</returns>
        public async Task<PermissionNamespaceCheckExistsRespDto> CheckPermissionNamespaceExists(CheckPermissionNamespaceExistsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-permission-namespace-exists", requestBody).ConfigureAwait(false);

            PermissionNamespaceCheckExistsRespDto result = m_JsonService.DeserializeObject<PermissionNamespaceCheckExistsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 分页查询权限空间下所有的角色列表
        ///</summary>
        /// <param name="code">权限分组唯一标志符 Code</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">角色 Code 或者名称</param>
        ///<returns>PermissionNamespaceRolesListPaginatedRespDto</returns>
        public async Task<PermissionNamespaceRolesListPaginatedRespDto> ListPermissionNamespaceRoles(ListPermissionNamespaceRolesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-permission-namespace-roles", reqDto).ConfigureAwait(false);

            PermissionNamespaceRolesListPaginatedRespDto result = m_JsonService.DeserializeObject<PermissionNamespaceRolesListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建数据资源（推荐、重点）
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateDataResourceResponseDto</returns>
        public async Task<CreateDataResourceResponseDto> CreateDataResource(CreateDataResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-data-resource", requestBody).ConfigureAwait(false);

            CreateDataResourceResponseDto result = m_JsonService.DeserializeObject<CreateDataResourceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建字符串数据资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateStringDataResourceResponseDto</returns>
        public async Task<CreateStringDataResourceResponseDto> CreateDataResourceByString(CreateStringDataResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-string-data-resource", requestBody).ConfigureAwait(false);

            CreateStringDataResourceResponseDto result = m_JsonService.DeserializeObject<CreateStringDataResourceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建数组数据资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateArrayDataResourceResponseDto</returns>
        public async Task<CreateArrayDataResourceResponseDto> CreateDataResourceByArray(CreateArrayDataResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-array-data-resource", requestBody).ConfigureAwait(false);

            CreateArrayDataResourceResponseDto result = m_JsonService.DeserializeObject<CreateArrayDataResourceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建树数据资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateTreeDataResourceResponseDto</returns>
        public async Task<CreateTreeDataResourceResponseDto> CreateDataResourceByTree(CreateTreeDataResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-tree-data-resource", requestBody).ConfigureAwait(false);

            CreateTreeDataResourceResponseDto result = m_JsonService.DeserializeObject<CreateTreeDataResourceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取数据资源列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">关键字搜索，可以是数据资源名称或者数据资源 Code</param>
        /// <param name="namespaceCodes">权限数据所属权限空间 Code 列表</param>
        ///<returns>ListDataResourcesPaginatedRespDto</returns>
        public async Task<ListDataResourcesPaginatedRespDto> ListDataResources(ListDataResourcesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-data-resources", reqDto).ConfigureAwait(false);

            ListDataResourcesPaginatedRespDto result = m_JsonService.DeserializeObject<ListDataResourcesPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取数据资源详情
        ///</summary>
        /// <param name="namespaceCode">数据资源所属的权限空间 Code</param>
        /// <param name="resourceCode">数据资源 Code, 权限空间内唯一</param>
        ///<returns>GetDataResourceResponseDto</returns>
        public async Task<GetDataResourceResponseDto> GetDataResource(GetDataResourceDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-data-resource", reqDto).ConfigureAwait(false);

            GetDataResourceResponseDto result = m_JsonService.DeserializeObject<GetDataResourceResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改数据资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UpdateDataResourceResponseDto</returns>
        public async Task<UpdateDataResourceResponseDto> UpdateDataResource(UpdateDataResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-data-resource", requestBody).ConfigureAwait(false);

            UpdateDataResourceResponseDto result = m_JsonService.DeserializeObject<UpdateDataResourceResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除数据资源
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeleteDataResource(DeleteDataResourceDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-data-resource", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 检查数据资源 Code 或者名称是否可用
        ///</summary>
        /// <param name="namespaceCode">数据资源所属的权限空间 Code</param>
        /// <param name="resourceName">数据资源名称, 权限空间内唯一</param>
        /// <param name="resourceCode">数据资源 Code, 权限空间内唯一</param>
        ///<returns>CheckParamsDataResourceResponseDto</returns>
        public async Task<CheckParamsDataResourceResponseDto> CheckDataResourceExists(CheckDataResourceExistsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/check-data-resource-exists", reqDto).ConfigureAwait(false);

            CheckParamsDataResourceResponseDto result = m_JsonService.DeserializeObject<CheckParamsDataResourceResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建数据策略（重点）
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateDataPolicyResponseDto</returns>
        public async Task<CreateDataPolicyResponseDto> CreateDataPolicy(CreateDataPolicyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-data-policy", requestBody).ConfigureAwait(false);

            CreateDataPolicyResponseDto result = m_JsonService.DeserializeObject<CreateDataPolicyResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取数据策略列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">数据策略名称关键字搜索</param>
        ///<returns>ListDataPoliciesPaginatedRespDto</returns>
        public async Task<ListDataPoliciesPaginatedRespDto> ListDataPolices(ListDataPoliciesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-data-policies", reqDto).ConfigureAwait(false);

            ListDataPoliciesPaginatedRespDto result = m_JsonService.DeserializeObject<ListDataPoliciesPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取数据策略简略信息列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">数据策略名称关键字搜索</param>
        ///<returns>ListSimpleDataPoliciesPaginatedRespDto</returns>
        public async Task<ListSimpleDataPoliciesPaginatedRespDto> ListSimpleDataPolices(ListSimpleDataPoliciesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-simple-data-policies", reqDto).ConfigureAwait(false);

            ListSimpleDataPoliciesPaginatedRespDto result = m_JsonService.DeserializeObject<ListSimpleDataPoliciesPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取数据策略详情
        ///</summary>
        /// <param name="policyId">数据策略 ID</param>
        ///<returns>GetDataPolicyResponseDto</returns>
        public async Task<GetDataPolicyResponseDto> GetDataPolicy(GetDataPolicyDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-data-policy", reqDto).ConfigureAwait(false);

            GetDataPolicyResponseDto result = m_JsonService.DeserializeObject<GetDataPolicyResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改数据策略
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UpdateDataPolicyResponseDto</returns>
        public async Task<UpdateDataPolicyResponseDto> UpdateDataPolicy(UpdateDataPolicyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-data-policy", requestBody).ConfigureAwait(false);

            UpdateDataPolicyResponseDto result = m_JsonService.DeserializeObject<UpdateDataPolicyResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除数据策略
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeleteDataPolicy(DeleteDataPolicyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-data-policy", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 检查数据策略名称是否可用
        ///</summary>
        /// <param name="policyName">数据策略名称，用户池唯一</param>
        ///<returns>CheckParamsDataPolicyResponseDto</returns>
        public async Task<CheckParamsDataPolicyResponseDto> CheckDataPolicyExists(CheckDataPolicyExistsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/check-data-policy-exists", reqDto).ConfigureAwait(false);

            CheckParamsDataPolicyResponseDto result = m_JsonService.DeserializeObject<CheckParamsDataPolicyResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取数据策略授权的主体列表
        ///</summary>
        /// <param name="policyId">数据策略 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="query">主体名称</param>
        /// <param name="targetType">主体类型,包括 USER、GROUP、ROLE、ORG 四种类型</param>
        ///<returns>ListDataPolicySubjectPaginatedRespDto</returns>
        public async Task<ListDataPolicySubjectPaginatedRespDto> ListDataPolicyTargets(ListDataPolicyTargetsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-data-policy-targets", reqDto).ConfigureAwait(false);

            ListDataPolicySubjectPaginatedRespDto result = m_JsonService.DeserializeObject<ListDataPolicySubjectPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 授权数据策略
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> AuthorizeDataPolicies(CreateAuthorizeDataPolicyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/authorize-data-policies", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除数据策略授权
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> RevokeDataPolicy(DeleteAuthorizeDataPolicyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/revoke-data-policy", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户权限列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GetUserPermissionListRespDto</returns>
        public async Task<GetUserPermissionListRespDto> GetUserPermissionList(GetUserPermissionListDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-user-permission-list", requestBody).ConfigureAwait(false);

            GetUserPermissionListRespDto result = m_JsonService.DeserializeObject<GetUserPermissionListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 判断用户权限（重点）
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CheckPermissionRespDto</returns>
        public async Task<CheckPermissionRespDto> CheckPermission(CheckPermissionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-permission", requestBody).ConfigureAwait(false);

            CheckPermissionRespDto result = m_JsonService.DeserializeObject<CheckPermissionRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 判断外部用户权限
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CheckExternalUserPermissionRespDto</returns>
        public async Task<CheckExternalUserPermissionRespDto> CheckExternalUserPermission(CheckExternalUserPermissionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-external-user-permission", requestBody).ConfigureAwait(false);

            CheckExternalUserPermissionRespDto result = m_JsonService.DeserializeObject<CheckExternalUserPermissionRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户拥有某些资源的权限列表（推荐）
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GetUserResourcePermissionListRespDto</returns>
        public async Task<GetUserResourcePermissionListRespDto> GetUserResourcePermissionList(GetUserResourcePermissionListDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-user-resource-permission-list", requestBody).ConfigureAwait(false);

            GetUserResourcePermissionListRespDto result = m_JsonService.DeserializeObject<GetUserResourcePermissionListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取拥有某些资源权限的用户列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ListResourceTargetsRespDto</returns>
        public async Task<ListResourceTargetsRespDto> ListResourceTargets(ListResourceTargetsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-resource-targets", requestBody).ConfigureAwait(false);

            ListResourceTargetsRespDto result = m_JsonService.DeserializeObject<ListResourceTargetsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取用户拥有指定资源的权限及资源结构信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GetUserResourceStructRespDto</returns>
        public async Task<GetUserResourceStructRespDto> GetUserResourceStruct(GetUserResourceStructDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-user-resource-struct", requestBody).ConfigureAwait(false);

            GetUserResourceStructRespDto result = m_JsonService.DeserializeObject<GetUserResourceStructRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取外部用户拥有指定资源的权限及资源结构信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>GetExternalUserResourceStructRespDto</returns>
        public async Task<GetExternalUserResourceStructRespDto> GetExternalUserResourceStruct(GetExternalUserResourceStructDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-external-user-resource-struct", requestBody).ConfigureAwait(false);

            GetExternalUserResourceStructRespDto result = m_JsonService.DeserializeObject<GetExternalUserResourceStructRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 判断用户在树资源同层级下的权限（推荐）
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CheckUserSameLevelPermissionResponseDto</returns>
        public async Task<CheckUserSameLevelPermissionResponseDto> CheckUserSameLevelPermission(CheckUserSameLevelPermissionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/check-user-same-level-permission", requestBody).ConfigureAwait(false);

            CheckUserSameLevelPermissionResponseDto result = m_JsonService.DeserializeObject<CheckUserSameLevelPermissionResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取权限视图数据列表
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ListPermissionViewResponseDto</returns>
        public async Task<ListPermissionViewResponseDto> ListPermissionView(ListPermissionViewDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/list-permission-view/data", requestBody).ConfigureAwait(false);

            ListPermissionViewResponseDto result = m_JsonService.DeserializeObject<ListPermissionViewResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取套餐详情
        ///</summary>
        ///<returns>CostGetCurrentPackageRespDto</returns>
        public async Task<CostGetCurrentPackageRespDto> GetCurrentPackageInfo()
        {
            string httpResponse = await Request("GET", "/api/v3/get-current-package-info").ConfigureAwait(false);

            CostGetCurrentPackageRespDto result = m_JsonService.DeserializeObject<CostGetCurrentPackageRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取用量详情
        ///</summary>
        ///<returns>CostGetCurrentUsageRespDto</returns>
        public async Task<CostGetCurrentUsageRespDto> GetUsageInfo()
        {
            string httpResponse = await Request("GET", "/api/v3/get-usage-info").ConfigureAwait(false);

            CostGetCurrentUsageRespDto result = m_JsonService.DeserializeObject<CostGetCurrentUsageRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取 MAU 使用记录
        ///</summary>
        /// <param name="startTime">起始时间（年月日）</param>
        /// <param name="endTime">截止时间（年月日）</param>
        ///<returns>CostGetMauPeriodUsageHistoryRespDto</returns>
        public async Task<CostGetMauPeriodUsageHistoryRespDto> GetMauPeriodUsageHistory(GetMauPeriodUsageHistoryDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-mau-period-usage-history", reqDto).ConfigureAwait(false);

            CostGetMauPeriodUsageHistoryRespDto result = m_JsonService.DeserializeObject<CostGetMauPeriodUsageHistoryRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取所有权益
        ///</summary>
        ///<returns>CostGetAllRightItemRespDto</returns>
        public async Task<CostGetAllRightItemRespDto> GetAllRightsItem()
        {
            string httpResponse = await Request("GET", "/api/v3/get-all-rights-items").ConfigureAwait(false);

            CostGetAllRightItemRespDto result = m_JsonService.DeserializeObject<CostGetAllRightItemRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取订单列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>CostGetOrdersRespDto</returns>
        public async Task<CostGetOrdersRespDto> GetOrders(GetOrdersDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-orders", reqDto).ConfigureAwait(false);

            CostGetOrdersRespDto result = m_JsonService.DeserializeObject<CostGetOrdersRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取订单详情
        ///</summary>
        /// <param name="orderNo">订单号</param>
        ///<returns>CostGetOrderDetailRespDto</returns>
        public async Task<CostGetOrderDetailRespDto> GetOrderDetail(GetOrderDetailDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-order-detail", reqDto).ConfigureAwait(false);

            CostGetOrderDetailRespDto result = m_JsonService.DeserializeObject<CostGetOrderDetailRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取订单支付明细
        ///</summary>
        /// <param name="orderNo">订单号</param>
        ///<returns>CostGetOrderPayDetailRespDto</returns>
        public async Task<CostGetOrderPayDetailRespDto> GetOrderPayDetail(GetOrderPayDetailDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-order-pay-detail", reqDto).ConfigureAwait(false);

            CostGetOrderPayDetailRespDto result = m_JsonService.DeserializeObject<CostGetOrderPayDetailRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建自定义事件应用
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> CreateEventApp(CreateEventAppDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-event-app", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取事件应用列表
        ///</summary>
        ///<returns>EventAppPaginatedRespDto</returns>
        public async Task<EventAppPaginatedRespDto> ListEventApps()
        {
            string httpResponse = await Request("GET", "/api/v3/list-event-apps").ConfigureAwait(false);

            EventAppPaginatedRespDto result = m_JsonService.DeserializeObject<EventAppPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取事件列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        /// <param name="app">应用类型</param>
        ///<returns>OpenEventPaginatedRespDto</returns>
        public async Task<OpenEventPaginatedRespDto> ListEvents(ListEventsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-events", reqDto).ConfigureAwait(false);

            OpenEventPaginatedRespDto result = m_JsonService.DeserializeObject<OpenEventPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 定义自定义事件
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DefineEvent(DefineEventDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/define-event", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 推送自定义事件
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PubEventRespDto</returns>
        public async Task<PubEventRespDto> VerifyEvent(PubEventDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/pub-event", requestBody).ConfigureAwait(false);

            PubEventRespDto result = m_JsonService.DeserializeObject<PubEventRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 认证端推送自定义事件
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PubEventRespDto</returns>
        public async Task<PubEventRespDto> PubUserEvent(PubEventDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/pub-userEvent", requestBody).ConfigureAwait(false);

            PubEventRespDto result = m_JsonService.DeserializeObject<PubEventRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建注册白名单
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>WhitelistListRespDto</returns>
        public async Task<WhitelistListRespDto> AddWhitelist(AddWhitelistDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/add-whitelist", requestBody).ConfigureAwait(false);

            WhitelistListRespDto result = m_JsonService.DeserializeObject<WhitelistListRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取注册白名单列表
        ///</summary>
        /// <param name="type">白名单类型</param>
        ///<returns>WhitelistListRespDto</returns>
        public async Task<WhitelistListRespDto> ListWhitelists(ListWhitelistDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-whitelist", reqDto).ConfigureAwait(false);

            WhitelistListRespDto result = m_JsonService.DeserializeObject<WhitelistListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 删除注册白名单
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessDto</returns>
        public async Task<IsSuccessDto> DeleteWhitelist(DeleteWhitelistDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-whitelist", requestBody).ConfigureAwait(false);

            IsSuccessDto result = m_JsonService.DeserializeObject<IsSuccessDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 ip 列表
        ///</summary>
        /// <param name="ipType">IP 类型</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>IpListPaginatedRespDto</returns>
        public async Task<IpListPaginatedRespDto> FindIpList(IpListDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/ip-list", reqDto).ConfigureAwait(false);

            IpListPaginatedRespDto result = m_JsonService.DeserializeObject<IpListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建 ip 名单
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> Add(IpListCreateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/ip-list", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除 ip 名单
        ///</summary>
        /// <param name="id"></param>
        ///<returns>CommonResponseDto</returns>
        ///<summary>
        /// 获取用户列表
        ///</summary>
        /// <param name="userListType">IP 类型</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>UserListPaginatedRespDto</returns>
        public async Task<UserListPaginatedRespDto> FindUserList(UserListDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/user-list", reqDto).ConfigureAwait(false);

            UserListPaginatedRespDto result = m_JsonService.DeserializeObject<UserListPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建用户名单
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> AddUser(UserListCreateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/user-list", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除用户名单
        ///</summary>
        /// <param name="id"></param>
        ///<returns>CommonResponseDto</returns>
        ///<summary>
        /// 获取风险策略列表
        ///</summary>
        /// <param name="optObject">策略操作对象，目前只有 ip</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>UserListPolicyPaginatedRespDto</returns>
        public async Task<UserListPolicyPaginatedRespDto> FindRiskListPolicy(RiskListPolicyDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/risk-list-policy", reqDto).ConfigureAwait(false);

            UserListPolicyPaginatedRespDto result = m_JsonService.DeserializeObject<UserListPolicyPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建风险策略
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> AddRiskListPolicy(RiskListPolicyCreateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/risk-list-policy", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除风险策略
        ///</summary>
        /// <param name="id"></param>
        ///<returns>CommonResponseDto</returns>
        ///<summary>
        /// 新增设备
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>TerminalInfoRespDto</returns>
        public async Task<TerminalInfoRespDto> CreateDevice(CreateTerminalDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-device", requestBody).ConfigureAwait(false);

            TerminalInfoRespDto result = m_JsonService.DeserializeObject<TerminalInfoRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 最近登录应用
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> FindLastLoginAppsByDeviceIds(QueryTerminalAppsDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-last-login-apps-by-deviceIds", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 新增 verify 设备
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>TerminalInfoRespDto</returns>
        public async Task<TerminalInfoRespDto> CreateVerifyDevice(CreateTerminalDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/authing-verify/create-device", requestBody).ConfigureAwait(false);

            TerminalInfoRespDto result = m_JsonService.DeserializeObject<TerminalInfoRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 创建 Pipeline 函数
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PipelineFunctionSingleRespDto</returns>
        public async Task<PipelineFunctionSingleRespDto> CreatePipelineFunction(CreatePipelineFunctionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-pipeline-function", requestBody).ConfigureAwait(false);

            PipelineFunctionSingleRespDto result = m_JsonService.DeserializeObject<PipelineFunctionSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 Pipeline 函数详情
        ///</summary>
        /// <param name="funcId">Pipeline 函数 ID</param>
        ///<returns>PipelineFunctionSingleRespDto</returns>
        public async Task<PipelineFunctionSingleRespDto> GetPipelineFunction(GetPipelineFunctionDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-pipeline-function", reqDto).ConfigureAwait(false);

            PipelineFunctionSingleRespDto result = m_JsonService.DeserializeObject<PipelineFunctionSingleRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 重新上传 Pipeline 函数
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PipelineFunctionSingleRespDto</returns>
        public async Task<PipelineFunctionSingleRespDto> ReuploadPipelineFunction(ReUploadPipelineFunctionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/reupload-pipeline-function", requestBody).ConfigureAwait(false);

            PipelineFunctionSingleRespDto result = m_JsonService.DeserializeObject<PipelineFunctionSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改 Pipeline 函数
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>PipelineFunctionSingleRespDto</returns>
        public async Task<PipelineFunctionSingleRespDto> UpdatePipelineFunction(UpdatePipelineFunctionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-pipeline-function", requestBody).ConfigureAwait(false);

            PipelineFunctionSingleRespDto result = m_JsonService.DeserializeObject<PipelineFunctionSingleRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 修改 Pipeline 函数顺序
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> UpdatePipelineOrder(UpdatePipelineOrderDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-pipeline-order", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除 Pipeline 函数
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeletePipelineFunction(DeletePipelineFunctionDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-pipeline-function", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 Pipeline 函数列表
        ///</summary>
        /// <param name="scene">通过函数的触发场景进行筛选（可选，默认返回所有）：
        /// - `PRE_REGISTER`: 注册前
        /// - `POST_REGISTER`: 注册后
        /// - `PRE_AUTHENTICATION`: 认证前
        /// - `POST_AUTHENTICATION`: 认证后
        /// - `PRE_OIDC_ID_TOKEN_ISSUED`: OIDC ID Token 签发前
        /// - `PRE_OIDC_ACCESS_TOKEN_ISSUED`: OIDC Access Token 签发前
        /// - `PRE_COMPLETE_USER_INFO`: 补全用户信息前
        /// </param>
        ///<returns>PipelineFunctionPaginatedRespDto</returns>
        public async Task<PipelineFunctionPaginatedRespDto> ListPipelineFunctions(ListPipelineFunctionsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-pipeline-functions", reqDto).ConfigureAwait(false);

            PipelineFunctionPaginatedRespDto result = m_JsonService.DeserializeObject<PipelineFunctionPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取 Pipeline 日志
        ///</summary>
        /// <param name="funcId">Pipeline 函数 ID</param>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>PipelineFunctionPaginatedRespDto</returns>
        public async Task<PipelineFunctionPaginatedRespDto> GetPipelineLogs(GetPipelineLogsDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-pipeline-logs", reqDto).ConfigureAwait(false);

            PipelineFunctionPaginatedRespDto result = m_JsonService.DeserializeObject<PipelineFunctionPaginatedRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建 Webhook
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateWebhookRespDto</returns>
        public async Task<CreateWebhookRespDto> CreateWebhook(CreateWebhookDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-webhook", requestBody).ConfigureAwait(false);

            CreateWebhookRespDto result = m_JsonService.DeserializeObject<CreateWebhookRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 Webhook 列表
        ///</summary>
        /// <param name="page">当前页数，从 1 开始</param>
        /// <param name="limit">每页数目，最大不能超过 50，默认为 10</param>
        ///<returns>GetWebhooksRespDto</returns>
        public async Task<GetWebhooksRespDto> ListWebhooks(ListWebhooksDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-webhooks", reqDto).ConfigureAwait(false);

            GetWebhooksRespDto result = m_JsonService.DeserializeObject<GetWebhooksRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 修改 Webhook 配置
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>UpdateWebhooksRespDto</returns>
        public async Task<UpdateWebhooksRespDto> UpdateWebhook(UpdateWebhookDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-webhook", requestBody).ConfigureAwait(false);

            UpdateWebhooksRespDto result = m_JsonService.DeserializeObject<UpdateWebhooksRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除 Webhook
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>DeleteWebhookRespDto</returns>
        public async Task<DeleteWebhookRespDto> DeleteWebhook(DeleteWebhookDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-webhook", requestBody).ConfigureAwait(false);

            DeleteWebhookRespDto result = m_JsonService.DeserializeObject<DeleteWebhookRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 Webhook 日志
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>ListWebhookLogsRespDto</returns>
        public async Task<ListWebhookLogsRespDto> GetWebhookLogs(ListWebhookLogs requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/get-webhook-logs", requestBody).ConfigureAwait(false);

            ListWebhookLogsRespDto result = m_JsonService.DeserializeObject<ListWebhookLogsRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 手动触发 Webhook 执行
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>TriggerWebhookRespDto</returns>
        public async Task<TriggerWebhookRespDto> TriggerWebhook(TriggerWebhookDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/trigger-webhook", requestBody).ConfigureAwait(false);

            TriggerWebhookRespDto result = m_JsonService.DeserializeObject<TriggerWebhookRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 Webhook 详情
        ///</summary>
        /// <param name="webhookId">Webhook ID</param>
        ///<returns>GetWebhookRespDto</returns>
        public async Task<GetWebhookRespDto> GetWebhook(GetWebhookDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-webhook", reqDto).ConfigureAwait(false);

            GetWebhookRespDto result = m_JsonService.DeserializeObject<GetWebhookRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取 Webhook 事件列表
        ///</summary>
        ///<returns>WebhookEventListRespDto</returns>
        public async Task<WebhookEventListRespDto> GetWebhookEventList()
        {
            string httpResponse = await Request("GET", "/api/v3/get-webhook-event-list").ConfigureAwait(false);

            WebhookEventListRespDto result = m_JsonService.DeserializeObject<WebhookEventListRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 生成 LDAP Server 管理员密码
        ///</summary>
        ///<returns>LdapGetBindPwdRespDto</returns>
        public async Task<LdapGetBindPwdRespDto> GetBindPwd()
        {
            string httpResponse = await Request("GET", "/api/v3/get-ldap-server-random-pwd").ConfigureAwait(false);

            LdapGetBindPwdRespDto result = m_JsonService.DeserializeObject<LdapGetBindPwdRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取 LDAP server 配置信息
        ///</summary>
        ///<returns>LdapConfigInfoRespDto</returns>
        public async Task<LdapConfigInfoRespDto> QueryLdapConfigInfo()
        {
            string httpResponse = await Request("GET", "/api/v3/get-ldap-server-config").ConfigureAwait(false);

            LdapConfigInfoRespDto result = m_JsonService.DeserializeObject<LdapConfigInfoRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 更新 LDAP server 配置信息
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>LdapOperateRespDto</returns>
        public async Task<LdapOperateRespDto> UpdateLdapConfigInfo(LdapUpdateDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-ldap-server-config", requestBody).ConfigureAwait(false);

            LdapOperateRespDto result = m_JsonService.DeserializeObject<LdapOperateRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 初始化/重启 LDAP server
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>LdapOperateRespDto</returns>
        public async Task<LdapOperateRespDto> SaveLdapConfigInfo(LdapSaveDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/enable-ldap-server", requestBody).ConfigureAwait(false);

            LdapOperateRespDto result = m_JsonService.DeserializeObject<LdapOperateRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 关闭 LDAP server 服务，关闭前必须先初始化
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>LdapOperateRespDto</returns>
        public async Task<LdapOperateRespDto> DisableLdapServer(LdapSetEnabledFlagDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/disable-ldap-server", requestBody).ConfigureAwait(false);

            LdapOperateRespDto result = m_JsonService.DeserializeObject<LdapOperateRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// LDAP server 日志查询
        ///</summary>
        /// <param name="type">类型：1 访问日志，2 错误日志</param>
        /// <param name="page">当前页,从 1 开始</param>
        /// <param name="limit">每页条数</param>
        /// <param name="connection">连接标识</param>
        /// <param name="operationNumber">操作码</param>
        /// <param name="errorCode">错误码</param>
        /// <param name="message">消息内容</param>
        /// <param name="startTime">开始时间-时间戳</param>
        /// <param name="endTime">结束时间-时间戳</param>
        ///<returns>LdapLogRespDto</returns>
        public async Task<LdapLogRespDto> QueryLdapLog(GetLdapServerLogDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-ldap-server-log", reqDto).ConfigureAwait(false);

            LdapLogRespDto result = m_JsonService.DeserializeObject<LdapLogRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// LDAP server 根据 DN 查询下一级
        ///</summary>
        /// <param name="page">当前页,从 1 开始</param>
        /// <param name="limit">每页条数</param>
        /// <param name="dn">当前 DN</param>
        ///<returns>LdapLogRespDto</returns>
        public async Task<LdapLogRespDto> QueryLdapSubEntries(GetLdapSubEntriesDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-ldap-sub-entries", reqDto).ConfigureAwait(false);

            LdapLogRespDto result = m_JsonService.DeserializeObject<LdapLogRespDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取协作管理员 AK/SK 列表
        ///</summary>
        /// <param name="userId">密钥所属用户 ID</param>
        /// <param name="tenantId">密钥所属租户 ID</param>
        /// <param name="type">密钥类型</param>
        /// <param name="status">AccessKey 状态，activated：已激活，staging：分级（可轮换），revoked：已撤销</param>
        ///<returns>ListAccessKeyResponseDto</returns>
        public async Task<ListAccessKeyResponseDto> GetAccessKeyList(ListAccessKeyDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/list-access-key", reqDto).ConfigureAwait(false);

            ListAccessKeyResponseDto result = m_JsonService.DeserializeObject<ListAccessKeyResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 获取协作管理员 AK/SK 详细信息
        ///</summary>
        /// <param name="userId">用户 ID</param>
        /// <param name="accessKeyId">accessKeyId</param>
        ///<returns>GetAccessKeyResponseDto</returns>
        public async Task<GetAccessKeyResponseDto> GetAccessKey(GetAccessKeyDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/get-access-key", reqDto).ConfigureAwait(false);

            GetAccessKeyResponseDto result = m_JsonService.DeserializeObject<GetAccessKeyResponseDto>(httpResponse);
            return result;

        }
        ///<summary>
        /// 创建协作管理员的 AK/SK
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CreateAccessKeyResponseDto</returns>
        public async Task<CreateAccessKeyResponseDto> CreateAccessKey(CreateAccessKeyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/create-access-key", requestBody).ConfigureAwait(false);

            CreateAccessKeyResponseDto result = m_JsonService.DeserializeObject<CreateAccessKeyResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 删除协作管理员的 AK/SK
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>CommonResponseDto</returns>
        public async Task<CommonResponseDto> DeleteAccessKey(DeleteAccessKeyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/delete-access-key", requestBody).ConfigureAwait(false);

            CommonResponseDto result = m_JsonService.DeserializeObject<CommonResponseDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 更新一个管理员 AccessKey
        ///</summary>
        /// <param name="requestBody"></param>
        ///<returns>IsSuccessRespDto</returns>
        public async Task<IsSuccessRespDto> UpdateAccessKey(UpdateAccessKeyDto requestBody)
        {
            string httpResponse = await Request("POST", "/api/v3/update-access-key", requestBody).ConfigureAwait(false);

            IsSuccessRespDto result = m_JsonService.DeserializeObject<IsSuccessRespDto>(httpResponse);
            return result;
        }
        ///<summary>
        /// 获取 verify-config-app 列表
        ///</summary>
        /// <param name="keywords">搜索关键字</param>
        ///<returns>ApplicationDto</returns>
        public async Task<ApplicationDto> GetVerifyConfigApp(VerifyConfigAppDto reqDto)
        {
            string httpResponse = await Request("GET", "/api/v3/verify-config-app", reqDto).ConfigureAwait(false);

            ApplicationDto result = m_JsonService.DeserializeObject<ApplicationDto>(httpResponse);
            return result;

        }
    }
}