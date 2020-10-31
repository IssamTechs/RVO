using RVO.Services.Offices.Application.DTO;
using RVO.Services.Offices.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Offices.Application
{
    public static class Extensions
    {
        public static Office AsEntity(this OfficeDto dto)
           => new Office(dto.Id, dto.Title, dto.Description,
                    new OfficeHours(
                     new DateTimeRange(
                         dto.SatTimeRange.Start,
                          dto.SatTimeRange.End
                     ),
                    new DateTimeRange(
                         dto.SunTimeRange.Start,
                          dto.SunTimeRange.End
                     ),
                    new DateTimeRange(
                         dto.MonTimeRange.Start,
                          dto.MonTimeRange.End
                     ),
                     new DateTimeRange(
                         dto.TueTimeRange.Start,
                          dto.TueTimeRange.End
                     ),
                    new DateTimeRange(
                         dto.WedTimeRange.Start,
                          dto.WedTimeRange.End
                     ),
                    new DateTimeRange(
                         dto.ThuTimeRange.Start,
                          dto.ThuTimeRange.End
                     ),
                    new DateTimeRange(
                         dto.FriTimeRange.Start,
                          dto.FriTimeRange.End
                     )
                    )
               );

       
        public static OfficeDto AsDto(this Office office)
            => new OfficeDto
            {
                Id = office.Id,
                Title = office.Title,
                Description = office.Description,
                SatTimeRange = office.OfficeHours.SatTimeRange,
                SunTimeRange = office.OfficeHours.SunTimeRange,
                MonTimeRange = office.OfficeHours.MonTimeRange,
                TueTimeRange = office.OfficeHours.TueTimeRange,
                WedTimeRange = office.OfficeHours.WedTimeRange,
                ThuTimeRange = office.OfficeHours.ThuTimeRange,
                FriTimeRange = office.OfficeHours.FriTimeRange,
            };
       
    }
}
