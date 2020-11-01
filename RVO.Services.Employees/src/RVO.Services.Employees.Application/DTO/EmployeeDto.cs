using RVO.Services.Employees.Core.Entities;
using System;

namespace RVO.Services.Employees.Application.DTO
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid OfficeId { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public DateTimeRange SatSchedule { get; set; }
        public DateTimeRange SunSchedule { get; set; }
        public DateTimeRange MonSchedule { get; set; }
        public DateTimeRange TueSchedule { get; set; }
        public DateTimeRange WedSchedule { get; set; }
        public DateTimeRange ThuSchedule { get; set; }
        public DateTimeRange FriSchedule { get; set; }
    }
}
