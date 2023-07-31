using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v0016 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Address_AddressCurrentId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Address_AddressOfBirthId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5380214c-4b68-492b-ace5-16d76a9bc593"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("edc07b39-c740-4a5c-98ad-54133418a32f"));

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("9ad2e461-5ef1-4791-9934-e655d7ab9e0b"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("ae5402ff-2c88-41e9-883b-651f45f3572e"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_AddressCurrentId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Addresses_AddressOfBirthId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9ad2e461-5ef1-4791-9934-e655d7ab9e0b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae5402ff-2c88-41e9-883b-651f45f3572e"));

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByUser", "CreatedDate", "Description", "LastModifiedByUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("5380214c-4b68-492b-ace5-16d76a9bc593"), null, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("edc07b39-c740-4a5c-98ad-54133418a32f"), null, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });

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
    }
}
