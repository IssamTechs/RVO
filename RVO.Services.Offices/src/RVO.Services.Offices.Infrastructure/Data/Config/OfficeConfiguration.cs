using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RVO.Services.Offices.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RVO.Services.Offices.Infrastructure.Data.Config
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.Property(t => t.Title)
                .IsRequired();
            builder.OwnsOne(p => p.OfficeHours);
        }
    }
}
