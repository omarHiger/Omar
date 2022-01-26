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
    [Migration("20220126123110_AddHospitalsTable")]
    partial class AddHospitalsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalManagmentSystem.Class_Attriputes.Hospital_Phone_Numbers", b =>
                {
                    b.Property<int>("Ho_Id")
                        .HasColumnType("int");

                    b.Property<string>("Hospital_Phone_Number")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Ho_Id", "Hospital_Phone_Number");

                    b.ToTable("Hospital_Phone_Numbers");
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

                    b.Property<string>("Serial_Number")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Ho_Id");

                    b.ToTable("Hospitals");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Class_Attriputes.Hospital_Phone_Numbers", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Hospital", null)
                        .WithMany("Hospital_Phone_Numbers")
                        .HasForeignKey("Ho_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Hospital", b =>
                {
                    b.Navigation("Hospital_Phone_Numbers");
                });
#pragma warning restore 612, 618
        }
    }
}
