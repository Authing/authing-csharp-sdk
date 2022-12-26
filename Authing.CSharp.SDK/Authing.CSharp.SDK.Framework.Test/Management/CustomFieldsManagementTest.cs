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
    class CustomUserFieldsManagement_Test : ManagementClientBaseTest
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
        /// 修改用户内置字段
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
        /// 获取用户自定义字段
        /// </summary>
        /// <returns></returns>
        [Test]
        public void GetCustomFieldsTest()
        {
            CustomFieldListRespDto dto = managementClient.GetCustomFields(new GetCustomFieldsDto { TargetType = "USER" }).Result;

            Assert.IsTrue(dto.Data.Count > 0);
        }


    }

    /// <summary>
    /// 自定义字段的测试
    /// </summary>
    class CustomFieldsManagementTest : ManagementClientBaseTest
    {
        private string fieldKey = "auting_v3_key";
        private string fieldLabel = "authing_v3_label";
        private string fieldDescription = "authing_v3_test_descprition";

        private UserDto user;

        [OneTimeSetUp]
        public async Task CreateUser()
        {
            CreateUserReqDto dto = new CreateUserReqDto()
            {
                Username = "testUser" + new Random().Next(200, 1000),
                Status = CreateUserReqDto.status.ACTIVATED,
                Password = "password",
                Options = new CreateUserOptionsDto { DepartmentIdType = CreateUserOptionsDto.departmentIdType.DEPARTMENT_ID }
            };

            UserSingleRespDto userSingleRespDto = await managementClient.CreateUser(dto);

            user = userSingleRespDto.Data;
        }

        [OneTimeTearDown]
        public async Task DeleteUser()
        {
            await managementClient.DeleteUsersBatch(new DeleteUsersBatchDto
            {
                UserIds = new List<string> { user.UserId }
            });
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 设置用户自定义字段
        /// </summary>
        /// <returns></returns>
        [Test, Order(1)]
        public async Task SetCustomFieldsTest()
        {
            SetCustomFieldsReqDto setCustomFieldsReqDto = new SetCustomFieldsReqDto()
            {
                List = new List<SetCustomFieldDto>()
                    {
                        new SetCustomFieldDto()
                        {
                            TargetType=SetCustomFieldDto.targetType.USER,
                           DataType = SetCustomFieldDto.dataType.STRING,
                           Description = fieldDescription,
                           Key = fieldKey,
                           Label = fieldLabel,
                           Encrypted=false,
                           Options = new List<CustomFieldSelectOption>
                           {
                                new CustomFieldSelectOption
                                {
                                    Label = "EnumLabel1", Value = "EnumLabelValue1"
                                }
                            }
                        }
                    }
            };

            CustomFieldListRespDto dto = await managementClient.SetCustomFields(setCustomFieldsReqDto);
            Assert.IsTrue(dto.Data.Count > 0);
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 设置自定义字段的值
        /// </summary>
        /// <returns></returns>
        [Test, Order(2)]
        public async Task SetCustomData_With_UserId_Test()
        {
            SetCustomDataReqDto setCustomFieldsReqDto = new SetCustomDataReqDto()
            {
                TargetType = SetCustomDataReqDto.targetType.USER,
                TargetIdentifier = user.UserId,
                List = new List<SetCustomDataDto>()
                    {
                        new SetCustomDataDto()
                        {

                           Key = "AuhtingV3Key",
                           Value="AuthingV3Value"
                        }
                    }
            };

            IsSuccessRespDto isSuccess = await managementClient.SetCustomData(setCustomFieldsReqDto);
            Assert.IsTrue(isSuccess.Data.Success);
        }

        /// <summary>
        /// 2022-10-20 测试通过
        /// 获取自定义字段的值
        /// </summary>
        /// <returns></returns>
        [Test, Order(3)]
        public async Task GetCustomData_With_userId_Test()
        {
            GetCustomDataRespDto getCustomDataRespDto = await managementClient.GetCustomData(new GetCustomDataDto { TargetIdentifier = user.UserId, TargetType = "USER" });
            Assert.IsNotNull(getCustomDataRespDto.Data);
        }
    }
}
