using System;

namespace RVO.Services.Clients.Application.DTO
{
    public class ClientDto
    {
        public Guid Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; } 
    }
}
