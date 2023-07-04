using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v007 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80ce64db-78de-431e-b415-a3f3c896ac16"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d771af19-ed79-4a85-b4d5-086dc2f454a7"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("96d85479-e857-4dfb-95f1-efa1605a1585"), null, new Guid("00000000-0000-0000-0000-000000000000"), null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("e7236c2d-18fd-43ea-a2c0-33911cfb4029"), null, new Guid("00000000-0000-0000-0000-000000000000"), null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96d85479-e857-4dfb-95f1-efa1605a1585"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e7236c2d-18fd-43ea-a2c0-33911cfb4029"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("80ce64db-78de-431e-b415-a3f3c896ac16"), null, new Guid("00000000-0000-0000-0000-000000000000"), null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("d771af19-ed79-4a85-b4d5-086dc2f454a7"), null, new Guid("00000000-0000-0000-0000-000000000000"), null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });
        }
    }
}
