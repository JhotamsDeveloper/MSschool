using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v008 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96d85479-e857-4dfb-95f1-efa1605a1585"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7236c2d-18fd-43ea-a2c0-33911cfb4029"));

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
                table: "SubjectsAcademicPrograms");

            migrationBuilder.DropColumn(
                name: "LastModifiedByIdUser",
                table: "SubjectsAcademicPrograms");

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
                name: "CreatedByUser",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "UserCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "UserCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "UserAssignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "UserAssignments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "SubjectValues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "SubjectValues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "SubjectsAcademicPrograms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "SubjectsAcademicPrograms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "Subjects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "Schedules",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "Institutions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "Institutions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "CourseNotes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "CourseNotes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "AcademicsPrograms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "AcademicsPrograms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "AcademicProgramUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "AcademicProgramUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUser",
                table: "AcademicLevels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedByUser",
                table: "AcademicLevels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("c277290d-af69-4bd7-8d9d-74e7f929f40d"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("d698cd1d-61ee-4031-9f6d-01703d2aea98"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c277290d-af69-4bd7-8d9d-74e7f929f40d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d698cd1d-61ee-4031-9f6d-01703d2aea98"));

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "UserCategories");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "UserAssignments");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "UserAssignments");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "SubjectValues");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "SubjectValues");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "SubjectsAcademicPrograms");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "SubjectsAcademicPrograms");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "Institutions");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "CourseNotes");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "CourseNotes");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "AcademicsPrograms");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "AcademicsPrograms");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "AcademicProgramUsers");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "AcademicProgramUsers");

            migrationBuilder.DropColumn(
                name: "CreatedByUser",
                table: "AcademicLevels");

            migrationBuilder.DropColumn(
                name: "LastModifiedByUser",
                table: "AcademicLevels");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "UserCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "UserCategories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "UserAssignments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "UserAssignments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "SubjectValues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "SubjectValues",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "SubjectsAcademicPrograms",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "SubjectsAcademicPrograms",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Subjects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "Subjects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Schedules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "Schedules",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Institutions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "Institutions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "CourseNotes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "CourseNotes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "AcademicsPrograms",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "AcademicsPrograms",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "AcademicProgramUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LastModifiedByIdUser",
                table: "AcademicProgramUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByIdUser",
                table: "AcademicLevels",
                type: "uniqueidentifier",
                nullable: true);

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
                    { new Guid("96d85479-e857-4dfb-95f1-efa1605a1585"), null, new Guid("00000000-0000-0000-0000-000000000000"), null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("e7236c2d-18fd-43ea-a2c0-33911cfb4029"), null, new Guid("00000000-0000-0000-0000-000000000000"), null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });
        }
    }
}
