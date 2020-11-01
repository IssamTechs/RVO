using RVO.Services.Employees.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Employees.Core.Exceptions
{
    
    public class InvalidEmployeeFirstNameException  : DomainException
    {
        public override string Code { get; } = "invalid_employee_firstname";
        public Guid Id { get; }
        public string FirstName { get; }

        public InvalidEmployeeFirstNameException(Guid id, string firstname) : base(
            $"employee first name is invalid for employee id {id}")
        {
            FirstName = firstname;
        }
    }
}
