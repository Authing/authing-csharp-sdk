using Authing.CSharp.SDK.Infrastructure;
using Authing.CSharp.SDK.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.Services
{
    public abstract class ServiceBase
    {
        protected readonly IJsonService m_JsonService;
        protected readonly IHttpService m_HttpService;

        protected string m_AccessToken;
        protected long? TokenExpirAt;

        public ServiceBase(IJsonService jsonService)
        {
            m_JsonService = jsonService;
            m_HttpService = HttpServiceFactory.Get(m_JsonService, Enums.HttpServiceType.HTTPWEBREQUEST);
        }

        protected string BuildHttpPostRequest(Dictionary<string, string> @params)
        {
            return BuildHttpPostRequest<Dictionary<string, string>>(@params);
        }

        protected string BuildHttpPostRequest<T>(T obj)
        {
            return m_JsonService.SerializeObject(obj);
        }



    }
}
