using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v003 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f1d3017-cc58-4e1a-a6e3-231459bbec77"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6d8bcc9-b060-4db3-aaa6-7966438261c5"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<int>(
                name: "number",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name", "number" },
                values: new object[,]
                {
                    { new Guid("16369831-5518-4615-b13f-fa74f7155d0d"), false, null, null, null, null, null, null, 0 },
                    { new Guid("612d88f0-e9b6-4110-b664-089feed2008e"), false, null, null, null, null, null, null, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16369831-5518-4615-b13f-fa74f7155d0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("612d88f0-e9b6-4110-b664-089feed2008e"));

            migrationBuilder.DropColumn(
                name: "number",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0f1d3017-cc58-4e1a-a6e3-231459bbec77"), false, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("c6d8bcc9-b060-4db3-aaa6-7966438261c5"), false, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });
        }
    }
}
