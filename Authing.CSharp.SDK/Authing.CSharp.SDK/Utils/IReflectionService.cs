using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Authing.CSharp.SDK.Utils
{
    public interface IReflectionService
    {
        IDictionary<string, object> GetInputObjec(object obj);
    }
}
