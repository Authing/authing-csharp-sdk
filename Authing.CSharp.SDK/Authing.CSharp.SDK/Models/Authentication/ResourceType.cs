using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.CSharp.SDK.Models.Authentication
{
    public enum ResourceType
    {
        [EnumMember(Value = "DATA")]
        DATA,
        [EnumMember(Value = "API")]
        API,
        [EnumMember(Value = "MENU")]
        MENU,
        [EnumMember(Value = "BUTTON")]
        BUTTON,
    }
}
