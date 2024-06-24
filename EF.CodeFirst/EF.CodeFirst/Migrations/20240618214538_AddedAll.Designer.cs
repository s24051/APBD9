﻿// <auto-generated />
using System;
using EF.CodeFirst.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF.CodeFirst.Migrations
{
    [DbContext(typeof(Apbd9Context))]
    [Migration("20240618214538_AddedAll")]
    partial class AddedAll
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.5.24306.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF.CodeFirst.Models.Doctor", b =>
                {
                    b.Property<int>("IdDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDoctor"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdDoctor")
                        .HasName("Doctor_PK");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            IdDoctor = 1,
                            Email = "Adamski@gmail.com",
                            FirstName = "DAdam",
                            LastName = "Adamski"
                        },
                        new
                        {
                            IdDoctor = 2,
                            Email = "Janski@gmail.com",
                            FirstName = "DJan",
                            LastName = "Janski"
                        });
                });

            modelBuilder.Entity("EF.CodeFirst.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMedicament"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdMedicament")
                        .HasName("Medicament_PK");

                    b.ToTable("Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "Headache medicament",
                            Name = "Apap",
                            Type = "Strong"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "Better headache medicament",
                            Name = "Ibum",
                            Type = "Strong"
                        });
                });

            modelBuilder.Entity("EF.CodeFirst.Models.Patient", b =>
                {
                    b.Property<int>("IdPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPatient"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPatient")
                        .HasName("Patient_PK");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            IdPatient = 1,
                            BirthDate = new DateTime(2024, 6, 18, 23, 45, 37, 748, DateTimeKind.Local).AddTicks(6599),
                            FirstName = "Marian",
                            LastName = "Zielony"
                        },
                        new
                        {
                            IdPatient = 2,
                            BirthDate = new DateTime(2024, 6, 23, 23, 45, 37, 752, DateTimeKind.Local).AddTicks(4854),
                            FirstName = "Janina",
                            LastName = "Pietruszka"
                        });
                });

            modelBuilder.Entity("EF.CodeFirst.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPrescription"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription")
                        .HasName("Prescription_pk");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescriptions");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2024, 9, 18, 23, 45, 37, 759, DateTimeKind.Local).AddTicks(4448),
                            DueDate = new DateTime(2024, 3, 18, 23, 45, 37, 759, DateTimeKind.Local).AddTicks(4914),
                            IdDoctor = 1,
                            IdPatient = 1
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2024, 12, 18, 23, 45, 37, 759, DateTimeKind.Local).AddTicks(5402),
                            DueDate = new DateTime(2024, 4, 18, 23, 45, 37, 759, DateTimeKind.Local).AddTicks(5446),
                            IdDoctor = 2,
                            IdPatient = 2
                        });
                });

            modelBuilder.Entity("EF.CodeFirst.Models.PrescriptionMedicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int>("IdPrescription")
                        .HasColumnType("int");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Dose")
                        .HasColumnType("int");

                    b.HasKey("IdMedicament", "IdPrescription")
                        .HasName("PrescriptionMedicament_PK");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Prescription_Medicament", (string)null);

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            IdPrescription = 1,
                            Details = "Prescription for 1 medicament",
                            Dose = 100
                        },
                        new
                        {
                            IdMedicament = 2,
                            IdPrescription = 2,
                            Details = "Prescription details",
                            Dose = 1000
                        });
                });

            modelBuilder.Entity("EF.CodeFirst.Models.Prescription", b =>
                {
                    b.HasOne("EF.CodeFirst.Models.Doctor", "IdDoctorNav")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdDoctor")
                        .IsRequired()
                        .HasConstraintName("Doctor_Prescription_FK");

                    b.HasOne("EF.CodeFirst.Models.Patient", "IdPatientNav")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient")
                        .IsRequired()
                        .HasConstraintName("Patient_Prescription_FK");

                    b.Navigation("IdDoctorNav");

                    b.Navigation("IdPatientNav");
                });

            modelBuilder.Entity("EF.CodeFirst.Models.PrescriptionMedicament", b =>
                {
                    b.HasOne("EF.CodeFirst.Models.Medicament", "IdMedicamentNav")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdMedicament")
                        .IsRequired()
                        .HasConstraintName("Medicament_Prescription_FK");

                    b.HasOne("EF.CodeFirst.Models.Prescription", "IdPrescriptionNav")
                        .WithMany("PrescriptionMedicaments")
                        .HasForeignKey("IdPrescription")
                        .IsRequired()
                        .HasConstraintName("Prescription_Medicament_FK");

                    b.Navigation("IdMedicamentNav");

                    b.Navigation("IdPrescriptionNav");
                });

            modelBuilder.Entity("EF.CodeFirst.Models.Doctor", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("EF.CodeFirst.Models.Medicament", b =>
                {
                    b.Navigation("PrescriptionMedicaments");
                });

            modelBuilder.Entity("EF.CodeFirst.Models.Patient", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("EF.CodeFirst.Models.Prescription", b =>
                {
                    b.Navigation("PrescriptionMedicaments");
                });
#pragma warning restore 612, 618
        }
    }
}
