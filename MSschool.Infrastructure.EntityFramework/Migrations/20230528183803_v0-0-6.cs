using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v006 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3bca9c6-5283-4050-833b-32e13368f002"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df3e4454-8e66-49be-bcd4-6791377b3f73"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subjects",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Institutions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AcademicsPrograms",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AcademicLevels",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("83fac49a-99eb-43a5-89b1-22a2fc40a592"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 28, 13, 38, 3, 539, DateTimeKind.Unspecified).AddTicks(1422), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("ef002964-0fef-46b4-8a82-2da298ad5c21"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 28, 13, 38, 3, 539, DateTimeKind.Unspecified).AddTicks(1392), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("83fac49a-99eb-43a5-89b1-22a2fc40a592"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ef002964-0fef-46b4-8a82-2da298ad5c21"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Subjects",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Institutions",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AcademicsPrograms",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AcademicLevels",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("d3bca9c6-5283-4050-833b-32e13368f002"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 28, 13, 30, 56, 707, DateTimeKind.Unspecified).AddTicks(4830), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("df3e4454-8e66-49be-bcd4-6791377b3f73"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 28, 13, 30, 56, 707, DateTimeKind.Unspecified).AddTicks(4858), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }
    }
}
