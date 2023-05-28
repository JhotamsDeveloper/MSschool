using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v004 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16369831-5518-4615-b13f-fa74f7155d0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("612d88f0-e9b6-4110-b664-089feed2008e"));

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "UserAssignments");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "UserAssignments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SubjectValues");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "SubjectValues");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SubjectsAcademicProgram");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "SubjectsAcademicProgram");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CourseNotes");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "CourseNotes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "number",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AcademicsPrograms");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "AcademicsPrograms");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AcademicProgramUsers");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "AcademicProgramUsers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AcademicLevels");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "AcademicLevels");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "UserCategories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "UserCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "UserAssignments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "UserAssignments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "SubjectValues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "SubjectValues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "SubjectsAcademicProgram",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "SubjectsAcademicProgram",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Subjects",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "Subjects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Schedules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "Schedules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Institutions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "Institutions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "CourseNotes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "CourseNotes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "AcademicsPrograms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "AcademicsPrograms",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "AcademicProgramUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "AcademicProgramUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "AcademicLevels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "AcademicLevels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("48d3c63c-a34a-4e80-99c2-068aab3c6a04"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 27, 21, 24, 8, 119, DateTimeKind.Unspecified).AddTicks(6474), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("91e1a27d-6184-4e23-a63c-394505f78b3e"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 27, 21, 24, 8, 119, DateTimeKind.Unspecified).AddTicks(6502), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48d3c63c-a34a-4e80-99c2-068aab3c6a04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91e1a27d-6184-4e23-a63c-394505f78b3e"));

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "UserAssignments");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "UserAssignments");

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "SubjectValues");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "SubjectValues");

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "SubjectsAcademicProgram");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "SubjectsAcademicProgram");

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "CourseNotes");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "CourseNotes");

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "AcademicsPrograms");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "AcademicsPrograms");

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "AcademicProgramUsers");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "AcademicProgramUsers");

            migrationBuilder.DropColumn(
                name: "CreatedByIdUser",
                table: "AcademicLevels");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "AcademicLevels");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "UserCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "UserCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "UserAssignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "UserAssignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SubjectValues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "SubjectValues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SubjectsAcademicProgram",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "SubjectsAcademicProgram",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Institutions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Institutions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CourseNotes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "CourseNotes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "number",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AcademicsPrograms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "AcademicsPrograms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AcademicProgramUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "AcademicProgramUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AcademicLevels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "AcademicLevels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name", "number" },
                values: new object[,]
                {
                    { new Guid("16369831-5518-4615-b13f-fa74f7155d0d"), false, null, null, null, null, null, null, 0 },
                    { new Guid("612d88f0-e9b6-4110-b664-089feed2008e"), false, null, null, null, null, null, null, 0 }
                });
        }
    }
}
