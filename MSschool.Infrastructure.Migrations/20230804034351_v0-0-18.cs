using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v0018 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64d0cf80-0e7e-4a3a-a88e-dc70bd0a3cd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9591becc-0a3f-41c5-8ffe-922fa7998e61"));

            migrationBuilder.CreateTable(
                name: "Colombia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DepartmentCode = table.Column<int>(type: "int", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CityCode = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colombia", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("a39f5311-119f-4dea-aafc-97184d35b099"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("f754fec6-a14f-4d18-adfd-e6eb6bd17eca"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colombia");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a39f5311-119f-4dea-aafc-97184d35b099"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f754fec6-a14f-4d18-adfd-e6eb6bd17eca"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("64d0cf80-0e7e-4a3a-a88e-dc70bd0a3cd3"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("9591becc-0a3f-41c5-8ffe-922fa7998e61"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });
        }
    }
}
