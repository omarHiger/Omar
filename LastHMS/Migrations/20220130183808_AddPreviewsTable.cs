﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LastHMS.Migrations
{
    public partial class AddPreviewsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Previews",
                columns: table => new
                {
                    Preview_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preview_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Doctor_Name = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: false),
                    Patient_Id = table.Column<int>(type: "int", nullable: false),
                    Doctor_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Previews", x => x.Preview_Id);
                    table.ForeignKey(
                        name: "FK_Previews_Doctors_Doctor_Id",
                        column: x => x.Doctor_Id,
                        principalTable: "Doctors",
                        principalColumn: "Doctor_Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Previews_Patients_Patient_Id",
                        column: x => x.Patient_Id,
                        principalTable: "Patients",
                        principalColumn: "Patient_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Previews_Doctor_Id",
                table: "Previews",
                column: "Doctor_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Previews_Patient_Id",
                table: "Previews",
                column: "Patient_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Previews");
        }
    }
}
