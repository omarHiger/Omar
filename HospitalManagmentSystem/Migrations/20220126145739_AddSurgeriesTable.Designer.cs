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
    [Migration("20220126145739_AddSurgeriesTable")]
    partial class AddSurgeriesTable
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

            modelBuilder.Entity("HospitalManagmentSystem.Class_Attriputes.Employee_Phone_Numbers", b =>
                {
                    b.Property<int>("Employee_Id")
                        .HasColumnType("int");

                    b.Property<string>("Employee_Phone_Number")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Employee_Id", "Employee_Phone_Number");

                    b.ToTable("Employee_Phone_Numbers");
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

            modelBuilder.Entity("HospitalManagmentSystem.Models.Bill", b =>
                {
                    b.Property<int>("Bill_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Bill_Examination")
                        .HasColumnType("float");

                    b.Property<double>("Bill_Medical_Test")
                        .HasColumnType("float");

                    b.Property<double>("Bill_Rays")
                        .HasColumnType("float");

                    b.Property<double>("Bill_Room_Service")
                        .HasColumnType("float");

                    b.Property<double>("Bill_Surgeries")
                        .HasColumnType("float");

                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.HasKey("Bill_Id");

                    b.HasIndex("Patient_Id");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Department", b =>
                {
                    b.Property<int>("Department_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Department_Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Dept_Mgr_Id")
                        .HasColumnType("int");

                    b.Property<int>("Ho_Id")
                        .HasColumnType("int");

                    b.HasKey("Department_Id");

                    b.HasIndex("Dept_Mgr_Id");

                    b.HasIndex("Ho_Id");

                    b.ToTable("Departments");
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

                    b.HasIndex("Department_Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Employee", b =>
                {
                    b.Property<int>("Employee_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Employee_Area")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Employee_Birth_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Employee_Birth_Place")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Employee_City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Employee_Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Employee_Family_Members")
                        .HasColumnType("int");

                    b.Property<string>("Employee_First_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Employee_Gender")
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<DateTime>("Employee_Hire_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Employee_Job")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Employee_Last_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Employee_Middle_Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Employee_National_Number")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Employee_Password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Employee_Qualifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employee_Social_Status")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Employee_Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Employee_X_Y")
                        .IsRequired()
                        .HasMaxLength(61)
                        .HasColumnType("nvarchar(61)");

                    b.Property<int>("Ho_Id")
                        .HasColumnType("int");

                    b.HasKey("Employee_Id");

                    b.HasIndex("Ho_Id");

                    b.ToTable("Employees");
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

            modelBuilder.Entity("HospitalManagmentSystem.Models.Medical_Detail", b =>
                {
                    b.Property<string>("MD_Patient_Allergies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MD_Patient_Blood_Type")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("MD_Patient_Chronic_diseases")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MD_Patient_Examination_Records")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MD_Patient_External_Records")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MD_Patient_Family_Health_History")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MD_Patient_Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("nvarchar(90)");

                    b.Property<string>("MD_Patient_Special_Needs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MD_Patient_Treatment_Plans_And_Daily_Supplements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.HasIndex("Patient_Id");

                    b.ToTable("Medical_Details");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Medical_Test", b =>
                {
                    b.Property<int>("Test_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Test_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Test_Result")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Test_Type")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Test_Id");

                    b.HasIndex("Patient_Id");

                    b.ToTable("Medical_Tests");
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

                    b.HasIndex("Ho_Id");

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

            modelBuilder.Entity("HospitalManagmentSystem.Models.Ray", b =>
                {
                    b.Property<int>("Ray_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ray_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ray_Result")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ray_Type")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Ray_Id");

                    b.HasIndex("Patient_Id");

                    b.ToTable("Rays");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Reservation", b =>
                {
                    b.Property<int>("Reservation_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<int>("Room_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start_Date")
                        .HasColumnType("datetime2");

                    b.HasKey("Reservation_Id");

                    b.HasIndex("Patient_Id");

                    b.HasIndex("Room_Id");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Room", b =>
                {
                    b.Property<int>("Room_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ho_Id")
                        .HasColumnType("int");

                    b.Property<bool>("Room_Empty")
                        .HasColumnType("bit");

                    b.Property<int>("Room_Type")
                        .HasColumnType("int");

                    b.HasKey("Room_Id");

                    b.HasIndex("Ho_Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Surgery", b =>
                {
                    b.Property<int>("Surgery_Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Doctor_Id")
                        .HasColumnType("int");

                    b.Property<int>("Patient_Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Surgery_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Surgery_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Surgery_Room_Id")
                        .HasColumnType("int");

                    b.Property<int>("Surgery_Time")
                        .HasColumnType("int");

                    b.HasKey("Surgery_Number");

                    b.HasIndex("Doctor_Id");

                    b.HasIndex("Patient_Id");

                    b.HasIndex("Surgery_Room_Id");

                    b.ToTable("Surgeries");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Surgery_Room", b =>
                {
                    b.Property<int>("Surgery_Room_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ho_Id")
                        .HasColumnType("int");

                    b.Property<bool>("Surgery_Room_Ready")
                        .HasColumnType("bit");

                    b.HasKey("Surgery_Room_Id");

                    b.HasIndex("Ho_Id");

                    b.ToTable("Surgery_Rooms");
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

            modelBuilder.Entity("HospitalManagmentSystem.Class_Attriputes.Employee_Phone_Numbers", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Employee", null)
                        .WithMany("Employee_Phone_Numbers")
                        .HasForeignKey("Employee_Id")
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

            modelBuilder.Entity("HospitalManagmentSystem.Models.Bill", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Patient", null)
                        .WithMany("Patient_Bills")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Department", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Doctor", "Dept_Manager")
                        .WithMany()
                        .HasForeignKey("Dept_Mgr_Id");

                    b.HasOne("HospitalManagmentSystem.Models.Hospital", null)
                        .WithMany("Hospital_Departments")
                        .HasForeignKey("Ho_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dept_Manager");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Doctor", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Department", null)
                        .WithMany("Department_Doctors")
                        .HasForeignKey("Department_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Employee", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Hospital", null)
                        .WithMany("Ho_Employees")
                        .HasForeignKey("Ho_Id")
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

            modelBuilder.Entity("HospitalManagmentSystem.Models.Medical_Detail", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Medical_Test", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Patient", null)
                        .WithMany("Medical_Tests")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Patient", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Hospital", null)
                        .WithMany("Ho_Patients")
                        .HasForeignKey("Ho_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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

            modelBuilder.Entity("HospitalManagmentSystem.Models.Ray", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Patient", null)
                        .WithMany("Patient_Rays")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Reservation", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Patient", null)
                        .WithMany("Patient_Reservations")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagmentSystem.Models.Room", null)
                        .WithMany("Room_Reservations")
                        .HasForeignKey("Room_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Room", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Hospital", null)
                        .WithMany("Hospital_Rooms")
                        .HasForeignKey("Ho_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Surgery", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Doctor", null)
                        .WithMany("Doctor_Surgeries")
                        .HasForeignKey("Doctor_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagmentSystem.Models.Patient", null)
                        .WithMany("Patient_Surgeries")
                        .HasForeignKey("Patient_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagmentSystem.Models.Surgery_Room", null)
                        .WithMany("Surgery_Room_Surgeries")
                        .HasForeignKey("Surgery_Room_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Surgery_Room", b =>
                {
                    b.HasOne("HospitalManagmentSystem.Models.Hospital", null)
                        .WithMany("Hospital_Surgery_Rooms")
                        .HasForeignKey("Ho_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Department", b =>
                {
                    b.Navigation("Department_Doctors");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Doctor", b =>
                {
                    b.Navigation("CareGiver");

                    b.Navigation("Doctor_Phone_Numbers");

                    b.Navigation("Doctor_Previews");

                    b.Navigation("Doctor_Surgeries");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Employee", b =>
                {
                    b.Navigation("Employee_Phone_Numbers");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Hospital", b =>
                {
                    b.Navigation("Ho_Employees");

                    b.Navigation("Ho_Patients");

                    b.Navigation("Hospital_Departments");

                    b.Navigation("Hospital_Phone_Numbers");

                    b.Navigation("Hospital_Rooms");

                    b.Navigation("Hospital_Surgery_Rooms");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Patient", b =>
                {
                    b.Navigation("CareTaker");

                    b.Navigation("Medical_Tests");

                    b.Navigation("Patient_Bills");

                    b.Navigation("Patient_Phone_Numbers");

                    b.Navigation("Patient_Previews");

                    b.Navigation("Patient_Rays");

                    b.Navigation("Patient_Reservations");

                    b.Navigation("Patient_Surgeries");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Room", b =>
                {
                    b.Navigation("Room_Reservations");
                });

            modelBuilder.Entity("HospitalManagmentSystem.Models.Surgery_Room", b =>
                {
                    b.Navigation("Surgery_Room_Surgeries");
                });
#pragma warning restore 612, 618
        }
    }
}
