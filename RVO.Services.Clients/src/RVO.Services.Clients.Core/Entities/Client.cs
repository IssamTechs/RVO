using RVO.Services.Clients.Core;
using RVO.Services.Clients.Core.Exceptions;
using RVO.Services.Clients.Core.Interface;
using System;

namespace RVO.Services.Clients.Core.Entities
{
    public class Client: BaseEntity<Guid>, IAggregateRoot
    { 

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime BirthDate { get; private set; } 

        public string Telephone { get; private set; }

        public string Email { get; private set; }



        public Client()
        {

        }
        public Client(Guid id, string firstname, string lastname, DateTime birthDate, string telephone, string email)
        {
            Id = id;
            ChangeFirstName(firstname);
            ChangeLastName(lastname);
            ChangeBirthDate(birthDate); 
            ChangeTelephone(telephone);
            ChangeEmail(email);

        }

        public void ChangeEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new InvalidClientEmailException(Id, email);
            }

            Email = email;
        }

        public void ChangeTelephone(string telephone)
        {
            if (string.IsNullOrEmpty(telephone))
            {
                throw new InvalidClientTelephoneException(Id, telephone);
            }

            Telephone = telephone;
        }
        public void ChangeFirstName(string firstname)
        {
            if (string.IsNullOrEmpty(firstname))
            {
                throw new InvalidClientEmailException(Id, firstname);
            }

            FirstName = firstname;
        }

        public void ChangeLastName(string lastname)
        {
            if (string.IsNullOrEmpty(lastname))
            {
                throw new InvalidClientEmailException(Id, lastname);
            }

            LastName = lastname;
        }

        public void ChangeBirthDate(DateTime date)
        { 
            BirthDate = date;
        }
    }
}
