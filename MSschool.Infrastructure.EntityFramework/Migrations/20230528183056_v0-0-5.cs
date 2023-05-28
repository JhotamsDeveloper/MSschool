using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v005 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("48d3c63c-a34a-4e80-99c2-068aab3c6a04"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("91e1a27d-6184-4e23-a63c-394505f78b3e"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("d3bca9c6-5283-4050-833b-32e13368f002"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 28, 13, 30, 56, 707, DateTimeKind.Unspecified).AddTicks(4830), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("df3e4454-8e66-49be-bcd4-6791377b3f73"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 28, 13, 30, 56, 707, DateTimeKind.Unspecified).AddTicks(4858), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d3bca9c6-5283-4050-833b-32e13368f002"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df3e4454-8e66-49be-bcd4-6791377b3f73"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("48d3c63c-a34a-4e80-99c2-068aab3c6a04"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 27, 21, 24, 8, 119, DateTimeKind.Unspecified).AddTicks(6474), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("91e1a27d-6184-4e23-a63c-394505f78b3e"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 27, 21, 24, 8, 119, DateTimeKind.Unspecified).AddTicks(6502), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }
    }
}
