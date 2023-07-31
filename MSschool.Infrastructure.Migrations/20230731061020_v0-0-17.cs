using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v0017 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_AddressCurrentId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_AddressOfBirthId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Users_AddressCurrentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AddressOfBirthId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ad2e461-5ef1-4791-9934-e655d7ab9e0b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae5402ff-2c88-41e9-883b-651f45f3572e"));

            migrationBuilder.DropColumn(
                name: "AddressCurrentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AddressOfBirthId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "AddressCurrent",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressOfBirth",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("64d0cf80-0e7e-4a3a-a88e-dc70bd0a3cd3"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("9591becc-0a3f-41c5-8ffe-922fa7998e61"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64d0cf80-0e7e-4a3a-a88e-dc70bd0a3cd3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9591becc-0a3f-41c5-8ffe-922fa7998e61"));

            migrationBuilder.DropColumn(
                name: "AddressCurrent",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AddressOfBirth",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "AddressCurrentId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AddressOfBirthId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("9ad2e461-5ef1-4791-9934-e655d7ab9e0b"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("ae5402ff-2c88-41e9-883b-651f45f3572e"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressCurrentId",
                table: "Users",
                column: "AddressCurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressOfBirthId",
                table: "Users",
                column: "AddressOfBirthId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Addresses_AddressCurrentId",
                table: "Users",
                column: "AddressCurrentId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Addresses_AddressOfBirthId",
                table: "Users",
                column: "AddressOfBirthId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }
    }
}
