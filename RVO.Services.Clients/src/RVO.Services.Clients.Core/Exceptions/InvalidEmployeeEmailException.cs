using System;

namespace RVO.Services.Clients.Core.Exceptions
{

    public class InvalidClientEmailException  : DomainException
    {
        public override string Code { get; } = "invalid_client_email";
        public Guid Id { get; }
        public string Email { get; }

        public InvalidClientEmailException(Guid id, string email) : base(
            $"client email is invalid for client id {id}")
        {
            Email = email;
        }
    }
}
