﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using back_end_cemex;

#nullable disable

namespace back_end_cemex.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220421234237_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("back_end_cemex.Entities.Company", b =>
                {
                    b.Property<int>("IdCompany")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCompany");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCompany"), 1L, 1);

                    b.Property<string>("DocumentCompany")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NitCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdCompany");

                    b.HasIndex("NitCompany")
                        .IsUnique();

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            IdCompany = 1,
                            NameCompany = "Sevi Transporte",
                            NitCompany = "123121-212"
                        },
                        new
                        {
                            IdCompany = 2,
                            NameCompany = "Entregas SAS",
                            NitCompany = "34341-982"
                        },
                        new
                        {
                            IdCompany = 3,
                            NameCompany = "Carga Segura",
                            NitCompany = "431231-12"
                        });
                });

            modelBuilder.Entity("back_end_cemex.Entities.Conveyor", b =>
                {
                    b.Property<int>("IdConveyor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdConveyor");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdConveyor"), 1L, 1);

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("TypeConveyorId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdConveyor");

                    b.HasIndex("CompanyId");

                    b.HasIndex("TypeConveyorId");

                    b.HasIndex("UserId");

                    b.ToTable("Conveyors");
                });

            modelBuilder.Entity("back_end_cemex.Entities.Driver", b =>
                {
                    b.Property<int>("IdDriver")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdDriver");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDriver"), 1L, 1);

                    b.Property<string>("CodeSap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ConveyorId")
                        .HasColumnType("int");

                    b.Property<string>("DocumentDrivinglicenseBack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentDrivinglicenseFrontal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentSecurityCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("TypeConveyorId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdDriver");

                    b.HasIndex("ConveyorId");

                    b.HasIndex("TypeConveyorId");

                    b.HasIndex("UserId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("back_end_cemex.Entities.TypeConveyor", b =>
                {
                    b.Property<int>("IdTypeConveyor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdTypeConveyor");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTypeConveyor"), 1L, 1);

                    b.Property<string>("DescriptionTypeConveyor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameTypeConveyor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTypeConveyor");

                    b.ToTable("TypeConveyors");

                    b.HasData(
                        new
                        {
                            IdTypeConveyor = 1,
                            DescriptionTypeConveyor = "Son empresas de transporte de carga que cuentan con una flota que supera los 5 camiones.",
                            NameTypeConveyor = "AdminLogis"
                        },
                        new
                        {
                            IdTypeConveyor = 2,
                            DescriptionTypeConveyor = "Son microempresas de transporte que tienen entre 1 a 5 camiones en su flota.",
                            NameTypeConveyor = "ManTruck"
                        },
                        new
                        {
                            IdTypeConveyor = 3,
                            DescriptionTypeConveyor = "Encargado de conducir el camión y su responsabilidad es cumplir con el itinerario de viajes asignados.",
                            NameTypeConveyor = "Driver"
                        });
                });

            modelBuilder.Entity("back_end_cemex.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("DocumentIdentityCardBack")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentIdentityCardFrontal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "f78da2e2-f68b-4528-be9c-f0795098e66c",
                            ConcurrencyStamp = "8df2b7cc-49ed-456a-a330-f9e5dd9b5d27",
                            Name = "PoweUser",
                            NormalizedName = "POWERUSER"
                        },
                        new
                        {
                            Id = "b45bf238-a642-4263-acdc-24a17200412c",
                            ConcurrencyStamp = "f9c82ef3-06dd-4436-a6f0-729017a20e2e",
                            Name = "CemexAdminLogis",
                            NormalizedName = "CEMEXADMINLOGIS"
                        },
                        new
                        {
                            Id = "e80631fd-2743-46a2-8c99-4902d42d4002",
                            ConcurrencyStamp = "15339a7c-9ab8-4413-9a43-948a9d4f1e87",
                            Name = "AdminLogis",
                            NormalizedName = "ADMINLOGIS"
                        },
                        new
                        {
                            Id = "88e9b834-09d7-4d50-852d-3ff69fbd64eb",
                            ConcurrencyStamp = "0bd43162-0559-47ad-a20b-b5c8ff6e87ca",
                            Name = "ManTruck",
                            NormalizedName = "MANTRUCK"
                        },
                        new
                        {
                            Id = "c316fdc1-7614-436b-836c-6e6234cd660f",
                            ConcurrencyStamp = "9c5fb206-7b72-4824-aa46-0c4ed0e699a2",
                            Name = "Driver",
                            NormalizedName = "DRIVER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("back_end_cemex.Entities.Conveyor", b =>
                {
                    b.HasOne("back_end_cemex.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("back_end_cemex.Entities.TypeConveyor", "TypeConveyor")
                        .WithMany()
                        .HasForeignKey("TypeConveyorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("back_end_cemex.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Company");

                    b.Navigation("TypeConveyor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("back_end_cemex.Entities.Driver", b =>
                {
                    b.HasOne("back_end_cemex.Entities.Conveyor", "Conveyor")
                        .WithMany()
                        .HasForeignKey("ConveyorId");

                    b.HasOne("back_end_cemex.Entities.TypeConveyor", "TypeConveyor")
                        .WithMany()
                        .HasForeignKey("TypeConveyorId");

                    b.HasOne("back_end_cemex.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Conveyor");

                    b.Navigation("TypeConveyor");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("back_end_cemex.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("back_end_cemex.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("back_end_cemex.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("back_end_cemex.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}