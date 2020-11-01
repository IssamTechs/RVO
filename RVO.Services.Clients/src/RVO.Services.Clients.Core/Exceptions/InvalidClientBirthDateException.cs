using System;

namespace RVO.Services.Clients.Core.Exceptions
{

    public class InvalidClientBirthDateException  : DomainException
    {
        public override string Code { get; } = "invalid_client_birthdate";
        public Guid Id { get; }
        public DateTime BirthDate { get; }

        public InvalidClientBirthDateException(Guid id, DateTime birthDate) : base(
            $"client birth date is invalid for client id {id}")
        {
            BirthDate = birthDate;
        }
    }
}
