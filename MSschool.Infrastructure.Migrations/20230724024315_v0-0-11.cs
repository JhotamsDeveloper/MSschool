using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v0011 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d9d1661-a37b-4b9d-a3eb-0c8cbd8e4f23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcf8f3c0-8199-4a7e-a1f5-a2a3b9ecc77d"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("625375f6-aa98-4c76-b4b4-83ece1f8b257"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("63a455ea-d8bf-412f-8bb1-dd89d7c622b7"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("0d9d1661-a37b-4b9d-a3eb-0c8cbd8e4f23"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("dcf8f3c0-8199-4a7e-a1f5-a2a3b9ecc77d"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }
    }
}
