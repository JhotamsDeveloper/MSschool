using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("876c6673-8b45-4936-b005-1b467549b274"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("afcaa75d-cdc6-4701-a436-10d1176cf424"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name", "Test" },
                values: new object[,]
                {
                    { new Guid("b1263826-e10c-450f-979c-8e99a81be8ee"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 22, 54, 11, 33, DateTimeKind.Unspecified).AddTicks(2485), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente", "tes" },
                    { new Guid("b56637d9-fd45-44f9-9710-742709098d57"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 22, 54, 11, 33, DateTimeKind.Unspecified).AddTicks(2520), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante", "tes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b1263826-e10c-450f-979c-8e99a81be8ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56637d9-fd45-44f9-9710-742709098d57"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name", "Test" },
                values: new object[,]
                {
                    { new Guid("876c6673-8b45-4936-b005-1b467549b274"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 22, 29, 12, 897, DateTimeKind.Unspecified).AddTicks(7355), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante", "tes" },
                    { new Guid("afcaa75d-cdc6-4701-a436-10d1176cf424"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 22, 29, 12, 897, DateTimeKind.Unspecified).AddTicks(7326), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente", "tes" }
                });
        }
    }
}
