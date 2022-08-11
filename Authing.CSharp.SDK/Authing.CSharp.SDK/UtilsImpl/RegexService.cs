using Authing.CSharp.SDK.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.UtilsImpl
{
    public class RegexService : IRegexService
    {
        public string DomainC14n(string domain)
        {
            string domainExp = @"/^((?:http)|(?:https):\/\/)?((?:[\w-_]+)(?:\.[\w-_]+)+)(?:\/.*)?$/";
            domainExp = @"(http|http(s)?://)?([\w-]+\.)+[\w-]+[.com|.in|.org]+(\[\?%&=]*)?";

            Regex regex = new Regex(domainExp);
            var isMatch = regex.IsMatch(domain);
            if (isMatch)
            {
                return domain;
            }
            throw new Exception("无效的域名配置：" + domain);
        }
    }
}
