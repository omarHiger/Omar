﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OurHospitalManagmentSystem.Data;

namespace OurHospitalManagmentSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220123165242_Test6")]
    partial class Test6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OurHospitalManagmentSystem.Class_Attriputes.Patient_Phone_Numbers", b =>
                {
                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<string>("Patient_Phone_Number")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Patient_Id", "Patient_Phone_Number");

                    b.ToTable("Patient_Phone_Numbers");
                });

            modelBuilder.Entity("OurHospitalManagmentSystem.Models.Patient", b =>
                {
                    b.Property<int>("Patient_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Patient_First_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Patient_Gender")
                        .IsRequired()
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

                    b.HasKey("Patient_Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("OurHospitalManagmentSystem.Class_Attriputes.Patient_Phone_Numbers", b =>
                {
                    b.HasOne("OurHospitalManagmentSystem.Models.Patient", null)
                        .WithMany("Patient_Phone_Numbers")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OurHospitalManagmentSystem.Models.Patient", b =>
                {
                    b.Navigation("Patient_Phone_Numbers");
                });
#pragma warning restore 612, 618
        }
    }
}
