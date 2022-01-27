﻿// <auto-generated />
using System;
using HospitalManagmentSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalManagmentSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220126134707_AddPreviewsTable")]
    partial class AddPreviewsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalManagmentSystem.BreakTables.Caring", b =>
                {
                    b.Property<int>("Doctor_Id")
                        .HasColumnType("int");

                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.HasKey("Doctor_Id", "Patient_Id");

                    b.HasIndex("Patient_Id");

                    b.ToTable("Caring");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Class_Attriputes.Doctor_Phone_Numbers", b =>
                {
                    b.Property<int>("Doctor_Id")
                        .HasColumnType("int");

                    b.Property<string>("Doctor_Phone_Number")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Doctor_Id", "Doctor_Phone_Number");

                    b.ToTable("Doctor_Phone_Numbers");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Class_Attriputes.Hospital_Phone_Numbers", b =>
                {
                    b.Property<int>("Ho_Id")
                        .HasColumnType("int");

                    b.Property<string>("Hospital_Phone_Number")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Ho_Id", "Hospital_Phone_Number");

                    b.ToTable("Hospital_Phone_Numbers");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Class_Attriputes.Patient_Phone_Numbers", b =>
                {
                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<string>("Patient_Phone_Number")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Patient_Id", "Patient_Phone_Number");

                    b.ToTable("Patient_Phone_Numbers");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Doctor", b =>
                {
                    b.Property<int>("Doctor_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Department_Id")
                        .HasColumnType("int");

                    b.Property<string>("Doctor_Area")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Doctor_Birth_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Doctor_Birth_Place")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Doctor_City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Doctor_Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Doctor_Family_Members")
                        .HasColumnType("int");

                    b.Property<string>("Doctor_First_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Doctor_Gender")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<DateTime>("Doctor_Hire_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Doctor_Last_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Doctor_Middle_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Doctor_National_Number")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Doctor_Password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Doctor_Qualifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doctor_Social_Status")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Doctor_Specialization")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Doctor_Street")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Doctor_Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Hospital", b =>
                {
                    b.Property<int>("Ho_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ho_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Ho_Subscribtion_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Hospital_Area")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Hospital_City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Hospital_Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Mgr_Id")
                        .HasColumnType("int");

                    b.Property<string>("Serial_Number")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Ho_Id");

                    b.HasIndex("Mgr_Id");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Patient", b =>
                {
                    b.Property<int>("Patient_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ho_Id")
                        .HasColumnType("int");

                    b.Property<string>("Patient_Area")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Patient_Birth_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Patient_Birth_Place")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Patient_City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Patient_Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Patient_First_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Patient_Gender")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Patient_Last_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Patient_Middle_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Patient_National_Number")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Patient_Password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Patient_Social_Status")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Patient_Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Patient_X_Y")
                        .IsRequired()
                        .HasMaxLength(61)
                        .HasColumnType("nvarchar(61)");

                    b.HasKey("Patient_Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Preview", b =>
                {
                    b.Property<int>("Preview_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Doctor_Id")
                        .HasColumnType("int");

                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Preview_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Preview_Id");

                    b.HasIndex("Doctor_Id");

                    b.HasIndex("Patient_Id");

                    b.ToTable("Previews");
                });

            modelBuilder.Entity("HospitalManagmentSystem.BreakTables.Caring", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Doctor", null)
                        .WithMany("CareGiver")
                        .HasForeignKey("Doctor_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagmentSystem.Models.Patient", null)
                        .WithMany("CareTaker")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Class_Attriputes.Doctor_Phone_Numbers", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Doctor", null)
                        .WithMany("Doctor_Phone_Numbers")
                        .HasForeignKey("Doctor_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Class_Attriputes.Hospital_Phone_Numbers", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Hospital", null)
                        .WithMany("Hospital_Phone_Numbers")
                        .HasForeignKey("Ho_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Class_Attriputes.Patient_Phone_Numbers", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Patient", null)
                        .WithMany("Patient_Phone_Numbers")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Hospital", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Doctor", "Manager")
                        .WithMany()
                        .HasForeignKey("Mgr_Id");

                    b.Navigation("Manager");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Preview", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Doctor", null)
                        .WithMany("Doctor_Previews")
                        .HasForeignKey("Doctor_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagmentSystem.Models.Patient", null)
                        .WithMany("Patient_Previews")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Doctor", b =>
                {
                    b.Navigation("CareGiver");

                    b.Navigation("Doctor_Phone_Numbers");

                    b.Navigation("Doctor_Previews");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Hospital", b =>
                {
                    b.Navigation("Hospital_Phone_Numbers");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Patient", b =>
                {
                    b.Navigation("CareTaker");

                    b.Navigation("Patient_Phone_Numbers");

                    b.Navigation("Patient_Previews");
                });
#pragma warning restore 612, 618
        }
    }
}
