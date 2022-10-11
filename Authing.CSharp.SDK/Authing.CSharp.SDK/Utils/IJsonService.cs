using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authing.CSharp.SDK.IServices
{
    public interface IJsonService
    {
        string SerializeObject(object obj);

        string SerializeObjectIngoreNull(object obj);

        string SerializeObjectCamelCase(object obj, bool ingoreNull = true);
        T DeserializeObject<T>(string jsonStr);
    }
}
