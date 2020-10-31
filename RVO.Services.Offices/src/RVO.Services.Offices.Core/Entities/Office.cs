using RVO.Services.Offices.Core.Exceptions;
using RVO.Services.Offices.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Offices.Core.Entities
{
    public class Office: BaseEntity<Guid>, IAggregateRoot
    {
        public string Title { get; private set; }

        public string Description { get; private set; }

        public OfficeHours OfficeHours { get; private set; }

        public Office()
        {

        }
        public Office(Guid id, string title, string description, OfficeHours officeHours)
        {
            Id = id;
            ChangeTitle(title);
            ChangeDescription(description);
            ChangeOfficeHours(officeHours);
        }

        public void ChangeTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new InvalidOfficeTitleException(Id, title);
            }

            Title = title;
        }

        public void ChangeDescription(string description)
        { 
            Description = description;
        }

        public void ChangeOfficeHours(OfficeHours officeHours)
        {
           
            OfficeHours = officeHours;
        }
    }
}
