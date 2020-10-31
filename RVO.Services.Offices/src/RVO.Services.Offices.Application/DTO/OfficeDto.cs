using RVO.Services.Offices.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Offices.Application.DTO
{
    public class OfficeDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeRange SatTimeRange { get; set; }
        public DateTimeRange SunTimeRange { get; set; }
        public DateTimeRange MonTimeRange { get; set; }
        public DateTimeRange TueTimeRange { get; set; }
        public DateTimeRange WedTimeRange { get; set; }
        public DateTimeRange ThuTimeRange { get; set; }
        public DateTimeRange FriTimeRange { get; set; }
    }
}
