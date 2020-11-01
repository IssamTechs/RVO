using RVO.Services.Clients.Application.DTO;
using RVO.Services.Clients.Core.Entities;  

namespace RVO.Services.Clients.Application
{
    public static class Extensions
    {
        public static Client AsEntity(this ClientDto dto)
           => new Client(dto.Id, dto.FirstName, dto.LastName, dto.BirthDate, dto.Telephone, dto.Email);

       
        public static ClientDto AsDto(this Client client)
            => new ClientDto
            {
                Id = client.Id, 
                FirstName = client.FirstName,
                LastName = client.LastName,
                BirthDate = client.BirthDate,
                Telephone = client.Telephone,
                Email = client.Email
            };
       
    }
}
