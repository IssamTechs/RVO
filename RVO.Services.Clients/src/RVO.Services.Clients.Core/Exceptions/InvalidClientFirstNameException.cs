using System;

namespace RVO.Services.Clients.Core.Exceptions
{

    public class InvalidClientFirstNameException  : DomainException
    {
        public override string Code { get; } = "invalid_client_firstname";
        public Guid Id { get; }
        public string FirstName { get; }

        public InvalidClientFirstNameException(Guid id, string firstname) : base(
            $"client first name is invalid for client id {id}")
        {
            FirstName = firstname;
        }
    }
}
