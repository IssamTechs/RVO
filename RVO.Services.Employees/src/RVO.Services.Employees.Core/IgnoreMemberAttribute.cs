using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Employees.Core
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class IgnoreMemberAttribute : Attribute
    {
    }
}
