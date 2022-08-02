using Authing.CSharp.SDK.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Extensions
{
    internal static class BaseManagementServiceExtension
    {
        public static bool IfTokenValid(this BaseManagementService serviceBase, long? accessTokenExpirAt)
        {
            long dateTime = DateTimeOffset.Now.Second;

            if (accessTokenExpirAt.HasValue && accessTokenExpirAt.Value > dateTime + 3600)
            {
                return true;
            }
            return false;
        }
    }
}
