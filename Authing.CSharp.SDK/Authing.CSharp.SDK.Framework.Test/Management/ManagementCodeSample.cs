using Authing.CSharp.SDK.Services;
using System;
using System.Threading.Tasks;
using Authing.CSharp.SDK.Models;
using System.Collections.Generic;

namespace ConsoleManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            // 设置初始化参数
            ManagementClientOptions clientOptions = new ManagementClientOptions
            {
                AccessKeyId = "AUTHING_ACCESS_KEY_ID",// Authing Access Key ID
                AccessKeySecret = "AUTHING_ACCESS_KEY_SECRET", // Authing Access Key Secret
            };

            // 初始化 ManagementClient
            ManagementClient managementClient = new ManagementClient(clientOptions);

            CheckUserSameLevelPermissionResponseDto result = await managementClient.CheckUserSameLevelPermission(new CheckUserSameLevelPermissionDto
            {
                NamespaceCode = "examplePermissionNamespace",
                UserId = "USERID",
                Action = "read",
                Resource = "strResourceCode1",
            });
        }
    }
}