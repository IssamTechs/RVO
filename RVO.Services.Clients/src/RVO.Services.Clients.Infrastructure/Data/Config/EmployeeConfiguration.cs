using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RVO.Services.Clients.Core.Entities;

namespace RVO.Services.Employees.Infrastructure.Data.Config
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(t => t.FirstName)
                .IsRequired();
            builder.Property(t => t.LastName)
            .IsRequired(); 
        }
    }
}
