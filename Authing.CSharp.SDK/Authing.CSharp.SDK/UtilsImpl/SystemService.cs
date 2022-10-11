using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.UtilsImpl
{
    public class SystemService
    {
        /// <summary>
        /// 获取Windows系统版本
        /// </summary>
        /// <returns>Windows系统版本字符串</returns>
        public static string GetWindowsVersion()
        {
            return (string)Environment.OSVersion.ToString();
        }
    }
}
