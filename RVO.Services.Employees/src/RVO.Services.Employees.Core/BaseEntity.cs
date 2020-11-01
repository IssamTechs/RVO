using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Employees.Core
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }

    }
}
