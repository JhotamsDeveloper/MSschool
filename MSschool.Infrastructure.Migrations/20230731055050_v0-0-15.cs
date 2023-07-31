using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v0015 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54a6e9c7-31a3-4a9c-b736-cfea9dd373ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("56a2f037-e6da-4130-9445-ad6136779d87"));

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
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedByUser = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("5380214c-4b68-492b-ace5-16d76a9bc593"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("edc07b39-c740-4a5c-98ad-54133418a32f"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
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
                name: "FK_Users_Address_AddressCurrentId",
                table: "Users",
                column: "AddressCurrentId",
                principalTable: "Address",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Address_AddressOfBirthId",
                table: "Users",
                column: "AddressOfBirthId",
                principalTable: "Address",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Address_AddressCurrentId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Address_AddressOfBirthId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Users_AddressCurrentId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_AddressOfBirthId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5380214c-4b68-492b-ace5-16d76a9bc593"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("edc07b39-c740-4a5c-98ad-54133418a32f"));

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
                    { new Guid("54a6e9c7-31a3-4a9c-b736-cfea9dd373ed"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("56a2f037-e6da-4130-9445-ad6136779d87"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });
        }
    }
}
