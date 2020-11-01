using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RVO.Services.Employees.Core.Entities
{
    [Owned]
    public class OfficeHours
    { 
       public DateTimeRange SatTimeRange { get; private set; }
       public DateTimeRange SunTimeRange { get; private set; }
       public DateTimeRange MonTimeRange { get; private set; }
       public DateTimeRange TueTimeRange { get; private set; }
       public DateTimeRange WedTimeRange { get; private set; }
       public DateTimeRange ThuTimeRange { get; private set; }
       public DateTimeRange FriTimeRange { get; private set; }

        public OfficeHours(
            DateTimeRange satDateTime, 
            DateTimeRange sunDateTime,
            DateTimeRange monDateTime,            
            DateTimeRange tueDateTime, 
            DateTimeRange wedDateTime, 
            DateTimeRange thuDateTime,
            DateTimeRange friDateTime)
        {
            ChangeDayOfficeHours(DayOfWeek.Saturday, satDateTime);
            ChangeDayOfficeHours(DayOfWeek.Sunday, sunDateTime);
            ChangeDayOfficeHours(DayOfWeek.Monday, monDateTime);
            ChangeDayOfficeHours(DayOfWeek.Tuesday, tueDateTime);
            ChangeDayOfficeHours(DayOfWeek.Wednesday, wedDateTime);
            ChangeDayOfficeHours(DayOfWeek.Thursday, thuDateTime);
            ChangeDayOfficeHours(DayOfWeek.Friday, friDateTime);
        }

        private void ChangeDayOfficeHours(DayOfWeek dayOfWeek, DateTimeRange range)
        {
           switch(dayOfWeek)
           {
                case DayOfWeek.Saturday: this.SatTimeRange = range; break;
                case DayOfWeek.Sunday: this.SunTimeRange = range; break;
                case DayOfWeek.Monday: this.MonTimeRange = range; break;
                case DayOfWeek.Tuesday: this.TueTimeRange = range; break;
                case DayOfWeek.Wednesday: this.WedTimeRange = range; break;
                case DayOfWeek.Thursday: this.ThuTimeRange = range; break;
                case DayOfWeek.Friday: this.FriTimeRange = range; break;
                default: break;
            }
        }

        public OfficeHours()
        {

        }
    }
}
