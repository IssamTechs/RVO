using RVO.Services.Employees.Application.DTO;
using RVO.Services.Employees.Core.Entities;  

namespace RVO.Services.Employees.Application
{
    public static class Extensions
    {
        public static Employee AsEntity(this EmployeeDto dto)
           => new Employee(dto.Id, dto.Title, dto.FirstName, dto.LastName, dto.OfficeId, dto.BirthDate, dto.HireDate,
                    new OfficeHours(
                     new DateTimeRange(
                         dto.SatSchedule.Start,
                          dto.SatSchedule.End
                     ),
                    new DateTimeRange(
                         dto.SunSchedule.Start,
                          dto.SunSchedule.End
                     ),
                    new DateTimeRange(
                         dto.MonSchedule.Start,
                          dto.MonSchedule.End
                     ),
                     new DateTimeRange(
                         dto.TueSchedule.Start,
                          dto.TueSchedule.End
                     ),
                    new DateTimeRange(
                         dto.WedSchedule.Start,
                          dto.WedSchedule.End
                     ),
                    new DateTimeRange(
                         dto.ThuSchedule.Start,
                          dto.ThuSchedule.End
                     ),
                    new DateTimeRange(
                         dto.FriSchedule.Start,
                          dto.FriSchedule.End
                     )
                    )
               );

       
        public static EmployeeDto AsDto(this Employee employee)
            => new EmployeeDto
            {
                Id = employee.Id,
                Title = employee.Title,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                BirthDate = employee.BirthDate,
                HireDate = employee.HireDate,
                OfficeId = employee.OfficeId,
                SatSchedule = employee.WeekSchedule.SatTimeRange,
                SunSchedule = employee.WeekSchedule.SunTimeRange,
                MonSchedule = employee.WeekSchedule.MonTimeRange,
                TueSchedule = employee.WeekSchedule.TueTimeRange,
                WedSchedule = employee.WeekSchedule.WedTimeRange,
                ThuSchedule = employee.WeekSchedule.ThuTimeRange,
                FriSchedule = employee.WeekSchedule.FriTimeRange,
            };
       
    }
}
