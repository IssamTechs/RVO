using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RVO.Services.Employees.Core.Entities; 

namespace RVO.Services.Employees.Infrastructure.Data.Config
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(t => t.Title)
                .IsRequired();
            builder.OwnsOne(p => p.WeekSchedule);
        }
    }
}
