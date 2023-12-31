﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    partial class BaseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CompanyOwnerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyOwnerId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyOwnerId = 1,
                            Name = "Turkey Ship-Co"
                        },
                        new
                        {
                            Id = 2,
                            CompanyOwnerId = 1,
                            Name = "Japan Ship-Co"
                        },
                        new
                        {
                            Id = 3,
                            CompanyOwnerId = 2,
                            Name = "Monaco Ship-Co"
                        },
                        new
                        {
                            Id = 4,
                            CompanyOwnerId = 3,
                            Name = "Spain Ship-Co"
                        },
                        new
                        {
                            Id = 5,
                            CompanyOwnerId = 3,
                            Name = "Germany Ship-Co"
                        });
                });

            modelBuilder.Entity("Models.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6a251fa1-fd88-45c4-8d09-7277941ab148"),
                            CompanyId = 1,
                            Name = "Hakkı Usta",
                            Salary = 15000.0
                        },
                        new
                        {
                            Id = new Guid("3afa7636-aba3-4562-92b3-a3c07a5c7411"),
                            CompanyId = 1,
                            Name = "Suat Usta",
                            Salary = 20000.0
                        },
                        new
                        {
                            Id = new Guid("ea4df93b-6508-4faf-b572-7edf453efd7f"),
                            CompanyId = 1,
                            Name = "Ahmet Usta",
                            Salary = 5000.0
                        },
                        new
                        {
                            Id = new Guid("43e7d70a-e308-4f6b-a8b7-9216bb6c7077"),
                            CompanyId = 2,
                            Name = "Hitachi Usta",
                            Salary = 25000.0
                        },
                        new
                        {
                            Id = new Guid("7b1cd380-5cb5-4fa9-a208-a03acd8bf8d8"),
                            CompanyId = 2,
                            Name = "Makita Usta",
                            Salary = 30000.0
                        },
                        new
                        {
                            Id = new Guid("e5b2346e-e4fc-4570-8617-adfa0c621362"),
                            CompanyId = 2,
                            Name = "Ryobi Usta",
                            Salary = 45000.0
                        },
                        new
                        {
                            Id = new Guid("bc1982bc-838d-4006-9c11-baa7ff323282"),
                            CompanyId = 3,
                            Name = "Buffon Usta",
                            Salary = 20000.0
                        },
                        new
                        {
                            Id = new Guid("b8f466ac-e51f-427e-abdb-cb4a4efb566e"),
                            CompanyId = 3,
                            Name = "Hans Usta",
                            Salary = 22000.0
                        },
                        new
                        {
                            Id = new Guid("fa90374f-10ed-4344-a185-9d40e718f9a4"),
                            CompanyId = 3,
                            Name = "Tsubasa Usta",
                            Salary = 23232.0
                        },
                        new
                        {
                            Id = new Guid("f12ab5fa-f8a5-4049-a674-e2fdfbf6ad15"),
                            CompanyId = 3,
                            Name = "Nail Usta",
                            Salary = 33000.0
                        },
                        new
                        {
                            Id = new Guid("5b76820b-26df-46a6-987c-d908dc6040bb"),
                            CompanyId = 4,
                            Name = "Iglesias Usta",
                            Salary = 60000.0
                        });
                });

            modelBuilder.Entity("Models.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Tuna GÜL"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Zatoichi Kiroshi"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Raquel Sanchez"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Emilio Zanetti"
                        });
                });

            modelBuilder.Entity("Models.Entities.Ship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShipColor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Ships");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            Length = 50.0,
                            Name = "Uçak Gemisi",
                            ShipColor = 5
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 1,
                            Length = 30.0,
                            Name = "Yük Gemisi",
                            ShipColor = 4
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 1,
                            Length = 30.0,
                            Name = "Buğday Gemisi",
                            ShipColor = 3
                        },
                        new
                        {
                            Id = 4,
                            CompanyId = 2,
                            Length = 40.0,
                            Name = "Oil Ship",
                            ShipColor = 0
                        },
                        new
                        {
                            Id = 5,
                            CompanyId = 2,
                            Length = 30.0,
                            Name = "Car Ship",
                            ShipColor = 1
                        },
                        new
                        {
                            Id = 6,
                            CompanyId = 2,
                            Length = 25.0,
                            Name = "Drone Ship",
                            ShipColor = 1
                        },
                        new
                        {
                            Id = 7,
                            CompanyId = 3,
                            Length = 10.0,
                            Name = "Fisher Boat",
                            ShipColor = 0
                        },
                        new
                        {
                            Id = 8,
                            CompanyId = 3,
                            Length = 5.0,
                            Name = "Mussell Hunter",
                            ShipColor = 5
                        });
                });

            modelBuilder.Entity("Models.Entities.Company", b =>
                {
                    b.HasOne("Models.Entities.Owner", "CompanyOwner")
                        .WithMany("Companies")
                        .HasForeignKey("CompanyOwnerId");

                    b.Navigation("CompanyOwner");
                });

            modelBuilder.Entity("Models.Entities.Employee", b =>
                {
                    b.HasOne("Models.Entities.Company", "Company")
                        .WithMany("CompanyEmployees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Models.Entities.Ship", b =>
                {
                    b.HasOne("Models.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Models.Entities.Company", b =>
                {
                    b.Navigation("CompanyEmployees");
                });

            modelBuilder.Entity("Models.Entities.Owner", b =>
                {
                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}
