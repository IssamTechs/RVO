using RVO.Services.Employees.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Employees.Core.Exceptions
{
    
    public class InvalidEmployeeBirthDateException  : DomainException
    {
        public override string Code { get; } = "invalid_employee_birthdate";
        public Guid Id { get; }
        public DateTime BirthDate { get; }

        public InvalidEmployeeBirthDateException(Guid id, DateTime birthDate) : base(
            $"employee birth date is invalid for employee id {id}")
        {
            BirthDate = birthDate;
        }
    }
}
