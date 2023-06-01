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
                keyValue: new Guid("476412ec-4a73-41ec-8bf0-196cd3863da3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c41ab635-a7d9-43f1-8c21-28ec37ce8f50"));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Institutions",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("5203b072-488d-481a-bcce-2dfd38d411ab"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 31, 14, 51, 57, 600, DateTimeKind.Unspecified).AddTicks(576), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("f2fed544-0e4b-4cf5-8929-301d81643379"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 31, 14, 51, 57, 600, DateTimeKind.Unspecified).AddTicks(616), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5203b072-488d-481a-bcce-2dfd38d411ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2fed544-0e4b-4cf5-8929-301d81643379"));

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Institutions",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("476412ec-4a73-41ec-8bf0-196cd3863da3"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 23, 21, 31, 640, DateTimeKind.Unspecified).AddTicks(3752), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("c41ab635-a7d9-43f1-8c21-28ec37ce8f50"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 30, 23, 21, 31, 640, DateTimeKind.Unspecified).AddTicks(3781), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }
    }
}
