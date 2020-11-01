using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Clients.Core
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class IgnoreMemberAttribute : Attribute
    {
    }
}
