﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(CodeFirstContext))]
    [Migration("20200603111435_test1")]
    partial class test1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdDoctor")
                        .HasName("Doctor_PK");

                    b.ToTable("Doctor");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "T.Rydzyk@gmail.com",
                            FirstName = "Tadeusz",
                            LastName = "Rydzyk"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "M.Oktaba@gmail.com",
                            FirstName = "Mariusz",
                            LastName = "Oktaba"
                        },
                        new
                        {
                            IdDoctor = 3,
                            Email = "G.Lomacz@gmail.com",
                            FirstName = "Grzegorz",
                            LastName = "Łomacz"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdMedicament")
                        .HasName("Medicament_PK");

                    b.ToTable("Medicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 10,
                            Description = "Na katar",
                            Name = "Hyrosalic",
                            Type = "Tabletki"
                        },
                        new
                        {
                            IdMedicament = 20,
                            Description = "Przeciwbólowy",
                            Name = "Tomysol",
                            Type = "Tabletki"
                        },
                        new
                        {
                            IdMedicament = 30,
                            Description = "Przeciwzapalny",
                            Name = "Mamarys",
                            Type = "Tabletki"
                        },
                        new
                        {
                            IdMedicament = 40,
                            Description = "Na kaszel",
                            Name = "Kaselic",
                            Type = "Syrop"
                        },
                        new
                        {
                            IdMedicament = 50,
                            Description = "Antybiotyk",
                            Name = "Parytol",
                            Type = "Tabletki"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("IdPatient")
                        .HasName("Patient_PK");

                    b.ToTable("Patient");

                    b.HasData(
                        new
                        {
                            IdPatient = 0,
                            Birthdate = new DateTime(2012, 9, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Jan",
                            LastName = "Kowalski"
                        },
                        new
                        {
                            IdPatient = 1,
                            Birthdate = new DateTime(2000, 3, 1, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Rafał",
                            LastName = "Smoczyński"
                        },
                        new
                        {
                            IdPatient = 2,
                            Birthdate = new DateTime(2002, 8, 21, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Piotr",
                            LastName = "Krótki"
                        },
                        new
                        {
                            IdPatient = 3,
                            Birthdate = new DateTime(2004, 6, 13, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Mateusz",
                            LastName = "Szybki"
                        },
                        new
                        {
                            IdPatient = 4,
                            Birthdate = new DateTime(1999, 2, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Robert",
                            LastName = "Wolny"
                        },
                        new
                        {
                            IdPatient = 5,
                            Birthdate = new DateTime(1997, 6, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Gosia",
                            LastName = "Miałczyńska"
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription")
                        .HasName("Prescritpion_PK");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescription");

                    b.HasData(
                        new
                        {
                            IdPrescription = 331,
                            Date = new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            DueDate = new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            IdDoctor = 3,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 332,
                            Date = new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            DueDate = new DateTime(2020, 6, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            IdDoctor = 2,
                            IdPatient = 2
                        },
                        new
                        {
                            IdPrescription = 333,
                            Date = new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            DueDate = new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            IdDoctor = 2,
                            IdPatient = 3
                        },
                        new
                        {
                            IdPrescription = 334,
                            Date = new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            DueDate = new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Local),
                            IdDoctor = 3,
                            IdPatient = 4
                        },
                        new
                        {
                            IdPrescription = 335,
                            Date = new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            DueDate = new DateTime(2020, 6, 26, 0, 0, 0, 0, DateTimeKind.Local),
                            IdDoctor = 1,
                            IdPatient = 5
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Prescription_Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription")
                        .HasName("Prescription_Medicament_PK");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Prescription_Medicament");

                    b.HasData(
                        new
                        {
                            IdMedicament = 10,
                            IdPrescription = 335,
                            Details = "Rano i wieczorem",
                            Dose = 15
                        },
                        new
                        {
                            IdMedicament = 20,
                            IdPrescription = 334,
                            Details = "Tylko wieczorem",
                            Dose = 18
                        },
                        new
                        {
                            IdMedicament = 30,
                            IdPrescription = 333,
                            Details = "Tylko rano",
                            Dose = 5
                        },
                        new
                        {
                            IdMedicament = 40,
                            IdPrescription = 332,
                            Details = "Na czczo",
                            Dose = 100
                        },
                        new
                        {
                            IdMedicament = 50,
                            IdPrescription = 331,
                            Details = "Tylko gdy boli",
                            Dose = 1
                        });
                });

            modelBuilder.Entity("WebApplication1.Models.Prescription", b =>
                {
                    b.HasOne("WebApplication1.Models.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdDoctor")
                        .HasConstraintName("Prescription_Doctor")
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient")
                        .HasConstraintName("Prescription_Patient")
                        .IsRequired();
                });

            modelBuilder.Entity("WebApplication1.Models.Prescription_Medicament", b =>
                {
                    b.HasOne("WebApplication1.Models.Medicament", "Medicament")
                        .WithMany("Medicaments_Prescriptions")
                        .HasForeignKey("IdMedicament")
                        .HasConstraintName("Prescription_Medicament_Medicament")
                        .IsRequired();

                    b.HasOne("WebApplication1.Models.Prescription", "Prescription")
                        .WithMany("Prescriptions_Medicaments")
                        .HasForeignKey("IdPrescription")
                        .HasConstraintName("Prescription_Medicament_Prescription")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
