using RVO.Services.Employees.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Employees.Core.Exceptions
{
    
    public class InvalidRangeException : DomainException
    {
        public override string Code { get; } = "invalid_datetime_range";
        public Guid Id { get; }
        public DateTimeRange TimeRange { get; }

        public InvalidRangeException(DateTimeRange timeRange) : base(
            $"Date range from {timeRange.Start}-{timeRange.End} is invalid.")
        {
            TimeRange = timeRange;
        }
    }
}
