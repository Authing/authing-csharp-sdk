using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Services;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.UtilsImpl;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Framework.Test
{
    class CustomFieldsManagementTest : ManagementClientBaseTest
    {
        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取用户内置列表
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task GetUserBaseFieldsAsync()
        {
            var dto = await managementClient.GetUserBaseFields();

            Assert.NotNull(dto.Data);
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 设置用户自定义字段
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task SetUserBaseFieldsAsync()
        {
            var dto = await managementClient.SetUserBaseFields(new SetUserBaseFieldsReqDto
            {
                List = new List<SetUserBaseFieldDto>
                {
                    new SetUserBaseFieldDto { Key="nickname",Label="昵称修改"}
                }
            });

            var list = await managementClient.GetUserBaseFields();
            var nickName = list.Data.Where(p => p.Key == "nickname").FirstOrDefault();
            Assert.IsTrue(nickName.Label == "昵称修改");
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 设置用户自定义字段
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetCustomFieldsTest()
        {
            CustomFieldListRespDto dto = managementClient.GetCustomFields(new GetCustomFieldsDto { TargetType = "USER" }).Result;

            Assert.IsTrue(dto.Data.Count > 0);
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 设置用户自定义字段
        /// </summary>
        /// <returns></returns>
        [Test]
        public void SetCustomFieldsTest()
        {
            SetCustomFieldsReqDto setCustomFieldsReqDto = new SetCustomFieldsReqDto()
            {
                List = new List<SetCustomFieldDto>()
                    {
                        new SetCustomFieldDto()
                        {
                            TargetType=SetCustomFieldDto.targetType.USER,
                           DataType = SetCustomFieldDto.dataType.STRING,
                           Description = "AuthingV3Test",
                           Key = "AuhtingV3Key",
                           Label = "AuthingV3",
                           Encrypted=false,
                           Options = new List<CustomFieldSelectOption>
                           {
                                new CustomFieldSelectOption
                                {
                                    Label = "ss", Value = "AuthingV3Value"
                                }
                            }
                        }
                    }
            };

            CustomFieldListRespDto dto = managementClient.SetCustomFields(setCustomFieldsReqDto).Result;
            Assert.IsTrue(dto.Data.Count > 0);
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 设置自定义字段的值
        /// </summary>
        /// <returns></returns>
        [Test]
        public void SetCustomDataTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                SetCustomDataReqDto setCustomFieldsReqDto = new SetCustomDataReqDto()
                {
                    TargetType = SetCustomDataReqDto.targetType.USER,
                    TargetIdentifier = "634fc0a6ebc13285a2ac8dd2",
                    Namespace = "default",
                    List = new List<SetCustomDataDto>()
                    {
                        new SetCustomDataDto()
                        {

                           Key = "AuhtingV3Key",
                           Value="AuthingV3Value"
                        }
                    }
                };

                IsSuccessRespDto isSuccess = managementClient.SetCustomData(setCustomFieldsReqDto).Result;
                Assert.IsTrue(isSuccess.Data.Success);
            }
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取自定义字段的值
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetCustomData()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                GetCustomDataRespDto getCustomDataRespDto = managementClient.GetCustomData(new GetCustomDataDto { Namespace = "default", TargetIdentifier = "634fc0a6ebc13285a2ac8dd2", TargetType = "USER" }).Result;
                Assert.IsNotNull(getCustomDataRespDto.Data);
            }
        }
    }
}
