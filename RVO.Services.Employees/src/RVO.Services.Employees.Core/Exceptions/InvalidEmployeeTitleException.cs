using RVO.Services.Employees.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Employees.Core.Exceptions
{
    
    public class InvalidEmployeeTitleException  : DomainException
    {
        public override string Code { get; } = "invalid_employee_title";
        public Guid Id { get; }
        public string Title { get; }

        public InvalidEmployeeTitleException(Guid id, string title) : base(
            $"employee title is invalid for employee id {id}")
        {
            Title = title;
        }
    }
}
