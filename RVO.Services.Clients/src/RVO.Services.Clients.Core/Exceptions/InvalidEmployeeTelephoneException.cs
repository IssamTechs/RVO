using System;

namespace RVO.Services.Clients.Core.Exceptions
{

    public class InvalidClientTelephoneException  : DomainException
    {
        public override string Code { get; } = "invalid_client_telephone";
        public Guid Id { get; }
        public string Telephone { get; }

        public InvalidClientTelephoneException(Guid id, string telephone) : base(
            $"client telephone is invalid for client id {id}")
        {
            Telephone = telephone;
        }
    }
}
