using RVO.Services.Offices.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Offices.Core.Exceptions
{
    
    public class InvalidOfficeTitleException  : DomainException
    {
        public override string Code { get; } = "invalid_office_title";
        public Guid Id { get; }
        public string Title { get; }

        public InvalidOfficeTitleException(Guid id, string title) : base(
            $"office title is invalid for office id {id}")
        {
            Title = title;
        }
    }
}
