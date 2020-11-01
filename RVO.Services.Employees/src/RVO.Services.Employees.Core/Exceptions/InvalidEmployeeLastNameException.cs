using RVO.Services.Employees.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Employees.Core.Exceptions
{
    
    public class InvalidEmployeeLastNameException  : DomainException
    {
        public override string Code { get; } = "invalid_employee_lastname";
        public Guid Id { get; }
        public string LastName { get; }

        public InvalidEmployeeLastNameException(Guid id, string lastname) : base(
            $"employee last name is invalid for employee id {id}")
        {
            LastName = lastname;
        }
    }
}
