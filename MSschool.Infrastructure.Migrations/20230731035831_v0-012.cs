using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v0012 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("625375f6-aa98-4c76-b4b4-83ece1f8b257"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("63a455ea-d8bf-412f-8bb1-dd89d7c622b7"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("3fb4b193-4e5c-4659-9138-c821a3e3986a"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("bcde09ab-37ea-43f1-aa1c-eb99bfa3c3e2"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3fb4b193-4e5c-4659-9138-c821a3e3986a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bcde09ab-37ea-43f1-aa1c-eb99bfa3c3e2"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("625375f6-aa98-4c76-b4b4-83ece1f8b257"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("63a455ea-d8bf-412f-8bb1-dd89d7c622b7"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }
    }
}
