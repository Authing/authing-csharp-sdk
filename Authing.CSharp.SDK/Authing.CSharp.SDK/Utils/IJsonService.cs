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

        string SerializeObjectCamelCase(object obj);
        T DeserializeObject<T>(string jsonStr);
    }
}
