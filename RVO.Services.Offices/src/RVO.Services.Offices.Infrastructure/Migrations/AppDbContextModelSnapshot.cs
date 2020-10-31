﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RVO.Services.Offices.Infrastructure.Data;

namespace RVO.Services.Offices.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RVO.Services.Offices.Core.Entities.Office", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Offices");
                });

            modelBuilder.Entity("RVO.Services.Offices.Core.Entities.Office", b =>
                {
                    b.OwnsOne("RVO.Services.Offices.Core.Entities.OfficeHours", "OfficeHours", b1 =>
                        {
                            b1.Property<Guid>("OfficeId")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("OfficeId");

                            b1.ToTable("Offices");

                            b1.WithOwner()
                                .HasForeignKey("OfficeId");

                            b1.OwnsOne("RVO.Services.Offices.Core.Entities.DateTimeRange", "FriTimeRange", b2 =>
                                {
                                    b2.Property<Guid>("OfficeHoursOfficeId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<DateTime>("End")
                                        .HasColumnType("datetime2");

                                    b2.Property<DateTime>("Start")
                                        .HasColumnType("datetime2");

                                    b2.HasKey("OfficeHoursOfficeId");

                                    b2.ToTable("Offices");

                                    b2.WithOwner()
                                        .HasForeignKey("OfficeHoursOfficeId");
                                });

                            b1.OwnsOne("RVO.Services.Offices.Core.Entities.DateTimeRange", "MonTimeRange", b2 =>
                                {
                                    b2.Property<Guid>("OfficeHoursOfficeId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<DateTime>("End")
                                        .HasColumnType("datetime2");

                                    b2.Property<DateTime>("Start")
                                        .HasColumnType("datetime2");

                                    b2.HasKey("OfficeHoursOfficeId");

                                    b2.ToTable("Offices");

                                    b2.WithOwner()
                                        .HasForeignKey("OfficeHoursOfficeId");
                                });

                            b1.OwnsOne("RVO.Services.Offices.Core.Entities.DateTimeRange", "SatTimeRange", b2 =>
                                {
                                    b2.Property<Guid>("OfficeHoursOfficeId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<DateTime>("End")
                                        .HasColumnType("datetime2");

                                    b2.Property<DateTime>("Start")
                                        .HasColumnType("datetime2");

                                    b2.HasKey("OfficeHoursOfficeId");

                                    b2.ToTable("Offices");

                                    b2.WithOwner()
                                        .HasForeignKey("OfficeHoursOfficeId");
                                });

                            b1.OwnsOne("RVO.Services.Offices.Core.Entities.DateTimeRange", "SunTimeRange", b2 =>
                                {
                                    b2.Property<Guid>("OfficeHoursOfficeId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<DateTime>("End")
                                        .HasColumnType("datetime2");

                                    b2.Property<DateTime>("Start")
                                        .HasColumnType("datetime2");

                                    b2.HasKey("OfficeHoursOfficeId");

                                    b2.ToTable("Offices");

                                    b2.WithOwner()
                                        .HasForeignKey("OfficeHoursOfficeId");
                                });

                            b1.OwnsOne("RVO.Services.Offices.Core.Entities.DateTimeRange", "ThuTimeRange", b2 =>
                                {
                                    b2.Property<Guid>("OfficeHoursOfficeId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<DateTime>("End")
                                        .HasColumnType("datetime2");

                                    b2.Property<DateTime>("Start")
                                        .HasColumnType("datetime2");

                                    b2.HasKey("OfficeHoursOfficeId");

                                    b2.ToTable("Offices");

                                    b2.WithOwner()
                                        .HasForeignKey("OfficeHoursOfficeId");
                                });

                            b1.OwnsOne("RVO.Services.Offices.Core.Entities.DateTimeRange", "TueTimeRange", b2 =>
                                {
                                    b2.Property<Guid>("OfficeHoursOfficeId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<DateTime>("End")
                                        .HasColumnType("datetime2");

                                    b2.Property<DateTime>("Start")
                                        .HasColumnType("datetime2");

                                    b2.HasKey("OfficeHoursOfficeId");

                                    b2.ToTable("Offices");

                                    b2.WithOwner()
                                        .HasForeignKey("OfficeHoursOfficeId");
                                });

                            b1.OwnsOne("RVO.Services.Offices.Core.Entities.DateTimeRange", "WedTimeRange", b2 =>
                                {
                                    b2.Property<Guid>("OfficeHoursOfficeId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<DateTime>("End")
                                        .HasColumnType("datetime2");

                                    b2.Property<DateTime>("Start")
                                        .HasColumnType("datetime2");

                                    b2.HasKey("OfficeHoursOfficeId");

                                    b2.ToTable("Offices");

                                    b2.WithOwner()
                                        .HasForeignKey("OfficeHoursOfficeId");
                                });
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
