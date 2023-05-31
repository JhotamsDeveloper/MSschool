using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0ed10333-6fc4-4de5-b11b-5f3effcec022"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4aeda22f-d882-471e-8397-9ff4fef12d9b"));

            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name", "Test" },
                values: new object[,]
                {
                    { new Guid("876c6673-8b45-4936-b005-1b467549b274"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 22, 29, 12, 897, DateTimeKind.Unspecified).AddTicks(7355), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante", "tes" },
                    { new Guid("afcaa75d-cdc6-4701-a436-10d1176cf424"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 22, 29, 12, 897, DateTimeKind.Unspecified).AddTicks(7326), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente", "tes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("876c6673-8b45-4936-b005-1b467549b274"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("afcaa75d-cdc6-4701-a436-10d1176cf424"));

            migrationBuilder.DropColumn(
                name: "Test",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0ed10333-6fc4-4de5-b11b-5f3effcec022"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 22, 13, 55, 764, DateTimeKind.Unspecified).AddTicks(9105), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("4aeda22f-d882-471e-8397-9ff4fef12d9b"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 22, 13, 55, 764, DateTimeKind.Unspecified).AddTicks(9134), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }
    }
}
