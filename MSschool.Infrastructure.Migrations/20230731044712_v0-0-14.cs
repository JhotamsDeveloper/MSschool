using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v0014 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ad91a139-39ea-45d6-9957-770e39b02ed0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce9da054-3e5d-4b05-a625-6fbf10a82070"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("54a6e9c7-31a3-4a9c-b736-cfea9dd373ed"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("56a2f037-e6da-4130-9445-ad6136779d87"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54a6e9c7-31a3-4a9c-b736-cfea9dd373ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56a2f037-e6da-4130-9445-ad6136779d87"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("ad91a139-39ea-45d6-9957-770e39b02ed0"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("ce9da054-3e5d-4b05-a625-6fbf10a82070"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });
        }
    }
}
