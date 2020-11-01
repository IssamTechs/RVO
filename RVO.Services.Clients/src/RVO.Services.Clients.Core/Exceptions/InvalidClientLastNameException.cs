using System;

namespace RVO.Services.Clients.Core.Exceptions
{

    public class InvalidClientLastNameException  : DomainException
    {
        public override string Code { get; } = "invalid_client_lastname";
        public Guid Id { get; }
        public string LastName { get; }

        public InvalidClientLastNameException(Guid id, string lastname) : base(
            $"client last name is invalid for client id {id}")
        {
            LastName = lastname;
        }
    }
}
