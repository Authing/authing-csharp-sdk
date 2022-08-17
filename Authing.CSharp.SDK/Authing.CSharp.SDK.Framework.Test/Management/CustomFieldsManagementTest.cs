﻿using Authing.CSharp.SDK.Models;
using Authing.CSharp.SDK.Services;
using Authing.CSharp.SDK.Utils;
using Authing.CSharp.SDK.UtilsImpl;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Authing.CSharp.SDK.Framework.Test
{
    class CustomFieldsManagementTest
    {
        ManagementClient managementClient;

        IDateTimeService dateTimeService;

        [SetUp]
        public void Setup()
        {
            ManagementClientOptions options = new ManagementClientOptions()
            {
                AccessKeyId = "613189b2eed393affbbf396e",
                AccessKeySecret = "ccf4951a33e5d54d64e145782a65f0a7"
            };

            managementClient = new ManagementClient(options);
            dateTimeService = new DateTimeService();
        }


        [Test]
        public void GetCustomFieldsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                CustomFieldListRespDto dto = managementClient.GetCustomFields("USER").Result;
                if (dto.StatusCode != 200)
                {
                    //进行异常处理
                }
                //返回数据成功，继续你的业务逻辑

                Assert.IsTrue(dto.Data.Count > 0);
            }
        }

        [Test]
        public void SetCustomFieldsTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
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
        }

        [Test]
        public void SetCustomDataTest()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {

                SetCustomDataReqDto setCustomFieldsReqDto = new SetCustomDataReqDto()
                {
                    TargetType=SetCustomDataReqDto.targetType.USER,
                    TargetIdentifier= "6283074cf5d4ed3e7535b928",
                    Namespace="default",
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

        [Test]
        public void GetCustomData()
        {
            using (CancellationTokenSource cts = new CancellationTokenSource())
            {
                GetCustomDataRespDto getCustomDataRespDto = managementClient.GetCustomData("6283074cf5d4ed3e7535b928","USER").Result;
                Assert.IsNotNull(getCustomDataRespDto.Data);
            }
        }
    }
}