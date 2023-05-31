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
                keyValue: new Guid("b1263826-e10c-450f-979c-8e99a81be8ee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b56637d9-fd45-44f9-9710-742709098d57"));

            migrationBuilder.DropColumn(
                name: "Test",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("476412ec-4a73-41ec-8bf0-196cd3863da3"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 23, 21, 31, 640, DateTimeKind.Unspecified).AddTicks(3752), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("c41ab635-a7d9-43f1-8c21-28ec37ce8f50"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 23, 21, 31, 640, DateTimeKind.Unspecified).AddTicks(3781), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("476412ec-4a73-41ec-8bf0-196cd3863da3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c41ab635-a7d9-43f1-8c21-28ec37ce8f50"));

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
                    { new Guid("b1263826-e10c-450f-979c-8e99a81be8ee"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 22, 54, 11, 33, DateTimeKind.Unspecified).AddTicks(2485), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente", "tes" },
                    { new Guid("b56637d9-fd45-44f9-9710-742709098d57"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 22, 54, 11, 33, DateTimeKind.Unspecified).AddTicks(2520), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante", "tes" }
                });
        }
    }
}
