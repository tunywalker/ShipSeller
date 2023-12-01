﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebAPI.Migrations
{
    [DbContext(typeof(BaseDbContext))]
    [Migration("20231201013429_init3")]
    partial class init3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Turkey Ship-Co",
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Japan Ship-Co",
                            OwnerId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Monaco Ship-Co",
                            OwnerId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Spain Ship-Co",
                            OwnerId = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "Germany Ship-Co",
                            OwnerId = 3
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
                            Id = new Guid("954a684f-ab38-4685-a0a4-2451d11325de"),
                            CompanyId = 1,
                            Name = "Hakkı Usta",
                            Salary = 15000.0
                        },
                        new
                        {
                            Id = new Guid("45b5c30a-33b6-4ac0-b591-c01b71f49126"),
                            CompanyId = 1,
                            Name = "Suat Usta",
                            Salary = 20000.0
                        },
                        new
                        {
                            Id = new Guid("6f7d8c00-f162-4cc1-ad9b-435c0a36bb60"),
                            CompanyId = 1,
                            Name = "Ahmet Usta",
                            Salary = 5000.0
                        },
                        new
                        {
                            Id = new Guid("8ae99910-1958-43f7-be1d-6db6efc25a78"),
                            CompanyId = 2,
                            Name = "Hitachi Usta",
                            Salary = 25000.0
                        },
                        new
                        {
                            Id = new Guid("7dd5434a-628f-4ed3-b483-6d7069419605"),
                            CompanyId = 2,
                            Name = "Makita Usta",
                            Salary = 30000.0
                        },
                        new
                        {
                            Id = new Guid("00a85644-6b92-474e-abfa-bb9ee74121f5"),
                            CompanyId = 2,
                            Name = "Ryobi Usta",
                            Salary = 45000.0
                        },
                        new
                        {
                            Id = new Guid("cfe1bdd7-2d19-4e26-a448-3991ae307e97"),
                            CompanyId = 3,
                            Name = "Buffon Usta",
                            Salary = 20000.0
                        },
                        new
                        {
                            Id = new Guid("4e7817ed-fb84-4e0f-8173-c2595dd7f509"),
                            CompanyId = 3,
                            Name = "Hans Usta",
                            Salary = 22000.0
                        },
                        new
                        {
                            Id = new Guid("2acdc66f-b3cd-453e-a7a4-d0cfda41bf21"),
                            CompanyId = 3,
                            Name = "Tsubasa Usta",
                            Salary = 23232.0
                        },
                        new
                        {
                            Id = new Guid("95e7c78e-4427-4d34-ada6-755e10089fe4"),
                            CompanyId = 3,
                            Name = "Nail Usta",
                            Salary = 33000.0
                        },
                        new
                        {
                            Id = new Guid("c29046e6-320d-449a-8cc4-22abd1cacb52"),
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
                    b.HasOne("Models.Entities.Owner", "Owner")
                        .WithMany("Companies")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Models.Entities.Employee", b =>
                {
                    b.HasOne("Models.Entities.Company", "Company")
                        .WithMany("Employees")
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
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("Models.Entities.Owner", b =>
                {
                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}
