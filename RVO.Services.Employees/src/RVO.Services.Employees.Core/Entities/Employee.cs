using RVO.Services.Employees.Core.Exceptions;
using RVO.Services.Employees.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Employees.Core.Entities
{
    public class Employee: BaseEntity<Guid>, IAggregateRoot
    {
        public string Title { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public Guid OfficeId { get; private set; }

        public DateTime BirthDate { get; private set; }

        public DateTime HireDate { get; private set; }

        public bool Discontinue { get; private set; }

        public OfficeHours WeekSchedule { get; private set; }

        public Employee()
        {

        }
        public Employee(Guid id, string title,  string firstname, string lastname, Guid officeId, DateTime birthDate, DateTime hireDate, OfficeHours weekSchedule)
        {
            Id = id;
            ChangeTitle(title);
            ChangeFirstName(firstname);
            ChangeLastName(lastname);
            ChangeOffice(officeId);
            ChangeBirthDate(birthDate);
            ChangeHireDate(hireDate);
            ChangeWeekSchedule(weekSchedule);
        }

        private void ChangeOffice(Guid officeId)
        {
            OfficeId = officeId;
        }

        public void ChangeTitle(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new InvalidEmployeeTitleException(Id, title);
            }

            Title = title;
        }

        public void ChangeFirstName(string firstname)
        {
            if (string.IsNullOrEmpty(firstname))
            {
                throw new InvalidEmployeeTitleException(Id, firstname);
            }

            FirstName = firstname;
        }

        public void ChangeLastName(string lastname)
        {
            if (string.IsNullOrEmpty(lastname))
            {
                throw new InvalidEmployeeTitleException(Id, lastname);
            }

            LastName = lastname;
        }

        public void ChangeBirthDate(DateTime date)
        { 
            BirthDate = date;
        }

        public void ChangeHireDate(DateTime date)
        {
            HireDate = date;
        }

        public void ChangeWeekSchedule(OfficeHours weekSchedule)
        {

            WeekSchedule = weekSchedule;
        }
    }
}
