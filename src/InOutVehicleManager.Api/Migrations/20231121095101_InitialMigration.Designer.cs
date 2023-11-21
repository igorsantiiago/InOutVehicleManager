﻿// <auto-generated />
using System;
using InOutVehicleManager.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InOutVehicleManager.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231121095101_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CompanyEmployee", b =>
                {
                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CompanyId", "EmployeeId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("CompanyEmployee");
                });

            modelBuilder.Entity("CompanyParking", b =>
                {
                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ParkingId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CompanyId", "ParkingId");

                    b.HasIndex("ParkingId");

                    b.ToTable("CompanyParking");
                });

            modelBuilder.Entity("EmployeeRole", b =>
                {
                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("EmployeeId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("EmployeeRole");
                });

            modelBuilder.Entity("InOutVehicleManager.Core.Contexts.CompanyContext.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Company", (string)null);
                });

            modelBuilder.Entity("InOutVehicleManager.Core.Contexts.CompanyContext.Entities.Parking", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AvailableCarParkingSpaces")
                        .HasColumnType("INT")
                        .HasColumnName("AvailableCarSpaces");

                    b.Property<int>("AvailableMotorcycleParkingSpaces")
                        .HasColumnType("INT")
                        .HasColumnName("AvailableMotorcycleSpaces");

                    b.Property<int>("TotalCarParkingSpaces")
                        .HasColumnType("int");

                    b.Property<int>("TotalMotorcycleParkingSpaces")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Parking", (string)null);
                });

            modelBuilder.Entity("InOutVehicleManager.Core.Contexts.EmployeeContext.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("InOutVehicleManager.Core.Contexts.EmployeeContext.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Role", (string)null);
                });

            modelBuilder.Entity("InOutVehicleManager.Core.Contexts.VehicleContext.Entities.Vehicle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Brand");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Color");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("LicensePlate");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Model");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("NVARCHAR")
                        .HasColumnName("Type");

                    b.HasKey("Id");

                    b.ToTable("Vehicle", (string)null);
                });

            modelBuilder.Entity("CompanyEmployee", b =>
                {
                    b.HasOne("InOutVehicleManager.Core.Contexts.CompanyContext.Entities.Company", null)
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InOutVehicleManager.Core.Contexts.EmployeeContext.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CompanyParking", b =>
                {
                    b.HasOne("InOutVehicleManager.Core.Contexts.CompanyContext.Entities.Company", null)
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InOutVehicleManager.Core.Contexts.CompanyContext.Entities.Parking", null)
                        .WithMany()
                        .HasForeignKey("ParkingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeRole", b =>
                {
                    b.HasOne("InOutVehicleManager.Core.Contexts.EmployeeContext.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InOutVehicleManager.Core.Contexts.EmployeeContext.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InOutVehicleManager.Core.Contexts.CompanyContext.Entities.Company", b =>
                {
                    b.OwnsOne("InOutVehicleManager.Core.Contexts.CompanyContext.ValueObjects.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("CompanyId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("AddressLine")
                                .IsRequired()
                                .HasMaxLength(40)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("AddressLine");

                            b1.Property<int>("AddressNumber")
                                .HasColumnType("INT")
                                .HasColumnName("AddressNumber");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("City");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasMaxLength(15)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("State");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasMaxLength(80)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("Street");

                            b1.Property<string>("ZipCode")
                                .IsRequired()
                                .HasMaxLength(8)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("ZipCode");

                            b1.HasKey("CompanyId");

                            b1.ToTable("Company");

                            b1.WithOwner()
                                .HasForeignKey("CompanyId");
                        });

                    b.OwnsOne("InOutVehicleManager.Core.Contexts.CompanyContext.ValueObjects.Cnpj", "Cnpj", b1 =>
                        {
                            b1.Property<Guid>("CompanyId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Document")
                                .IsRequired()
                                .HasMaxLength(14)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("Document");

                            b1.HasKey("CompanyId");

                            b1.ToTable("Company");

                            b1.WithOwner()
                                .HasForeignKey("CompanyId");
                        });

                    b.OwnsOne("InOutVehicleManager.Core.Contexts.CompanyContext.ValueObjects.Phone", "Phone", b1 =>
                        {
                            b1.Property<Guid>("CompanyId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("LandlinePhone")
                                .IsRequired()
                                .HasMaxLength(15)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("LandlinePhone");

                            b1.Property<string>("MobilePhone")
                                .IsRequired()
                                .HasMaxLength(15)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("MobilePhone");

                            b1.HasKey("CompanyId");

                            b1.ToTable("Company");

                            b1.WithOwner()
                                .HasForeignKey("CompanyId");
                        });

                    b.Navigation("Address")
                        .IsRequired();

                    b.Navigation("Cnpj")
                        .IsRequired();

                    b.Navigation("Phone")
                        .IsRequired();
                });

            modelBuilder.Entity("InOutVehicleManager.Core.Contexts.EmployeeContext.Entities.Employee", b =>
                {
                    b.OwnsOne("InOutVehicleManager.Core.Contexts.EmployeeContext.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("EmployeeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Address")
                                .IsRequired()
                                .HasMaxLength(120)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("Address");

                            b1.HasKey("EmployeeId");

                            b1.ToTable("Employee");

                            b1.WithOwner()
                                .HasForeignKey("EmployeeId");
                        });

                    b.OwnsOne("InOutVehicleManager.Core.Contexts.EmployeeContext.ValueObjects.Name", "Name", b1 =>
                        {
                            b1.Property<Guid>("EmployeeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("LastName");

                            b1.HasKey("EmployeeId");

                            b1.ToTable("Employee");

                            b1.WithOwner()
                                .HasForeignKey("EmployeeId");
                        });

                    b.OwnsOne("InOutVehicleManager.Core.Contexts.EmployeeContext.ValueObjects.Password", "Password", b1 =>
                        {
                            b1.Property<Guid>("EmployeeId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Hash")
                                .IsRequired()
                                .HasMaxLength(255)
                                .HasColumnType("NVARCHAR")
                                .HasColumnName("PasswordHash");

                            b1.HasKey("EmployeeId");

                            b1.ToTable("Employee");

                            b1.WithOwner()
                                .HasForeignKey("EmployeeId");
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("Name")
                        .IsRequired();

                    b.Navigation("Password")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
