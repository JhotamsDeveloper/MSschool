using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v006 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectsAcademicProgram_AcademicsPrograms_IdAcademicProgram",
                table: "SubjectsAcademicProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectsAcademicProgram_Subjects_IdSubject",
                table: "SubjectsAcademicProgram");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectsAcademicProgram",
                table: "SubjectsAcademicProgram");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5203b072-488d-481a-bcce-2dfd38d411ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f2fed544-0e4b-4cf5-8929-301d81643379"));

            migrationBuilder.RenameTable(
                name: "SubjectsAcademicProgram",
                newName: "SubjectsAcademicPrograms");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectsAcademicProgram_IdSubject",
                table: "SubjectsAcademicPrograms",
                newName: "IX_SubjectsAcademicPrograms_IdSubject");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectsAcademicProgram_IdAcademicProgram",
                table: "SubjectsAcademicPrograms",
                newName: "IX_SubjectsAcademicPrograms_IdAcademicProgram");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "Users",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "UserCategories",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "UserCategories",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "UserAssignments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "UserAssignments",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "SubjectValues",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "SubjectValues",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Subjects",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "Subjects",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Schedules",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "Schedules",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Institutions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "Institutions",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "CourseNotes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "CourseNotes",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "Categories",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "AcademicsPrograms",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "AcademicsPrograms",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "AcademicProgramUsers",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "AcademicProgramUsers",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "AcademicLevels",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "AcademicLevels",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "SubjectsAcademicPrograms",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "SubjectsAcademicPrograms",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectsAcademicPrograms",
                table: "SubjectsAcademicPrograms",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("955487f9-517d-4e33-8e0a-0c8eefbbc646"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 6, 1, 0, 42, 59, 359, DateTimeKind.Unspecified).AddTicks(6947), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("fd7b33cf-6796-4caf-82e1-c1f843e57ec9"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 6, 1, 0, 42, 59, 359, DateTimeKind.Unspecified).AddTicks(6914), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectsAcademicPrograms_AcademicsPrograms_IdAcademicProgram",
                table: "SubjectsAcademicPrograms",
                column: "IdAcademicProgram",
                principalTable: "AcademicsPrograms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectsAcademicPrograms_Subjects_IdSubject",
                table: "SubjectsAcademicPrograms",
                column: "IdSubject",
                principalTable: "Subjects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubjectsAcademicPrograms_AcademicsPrograms_IdAcademicProgram",
                table: "SubjectsAcademicPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectsAcademicPrograms_Subjects_IdSubject",
                table: "SubjectsAcademicPrograms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SubjectsAcademicPrograms",
                table: "SubjectsAcademicPrograms");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("955487f9-517d-4e33-8e0a-0c8eefbbc646"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd7b33cf-6796-4caf-82e1-c1f843e57ec9"));

            migrationBuilder.RenameTable(
                name: "SubjectsAcademicPrograms",
                newName: "SubjectsAcademicProgram");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectsAcademicPrograms_IdSubject",
                table: "SubjectsAcademicProgram",
                newName: "IX_SubjectsAcademicProgram_IdSubject");

            migrationBuilder.RenameIndex(
                name: "IX_SubjectsAcademicPrograms_IdAcademicProgram",
                table: "SubjectsAcademicProgram",
                newName: "IX_SubjectsAcademicProgram_IdAcademicProgram");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "UserCategories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "UserCategories",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "UserAssignments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "UserAssignments",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "SubjectValues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "SubjectValues",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Subjects",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "Subjects",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Schedules",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "Schedules",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Institutions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "Institutions",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "CourseNotes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "CourseNotes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "AcademicsPrograms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "AcademicsPrograms",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "AcademicProgramUsers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "AcademicProgramUsers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "AcademicLevels",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "AcademicLevels",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByIdUser",
                table: "SubjectsAcademicProgram",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Availability",
                table: "SubjectsAcademicProgram",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubjectsAcademicProgram",
                table: "SubjectsAcademicProgram",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedByIdUser", "CreatedDate", "Description", "LastModifiedByIdUser", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("5203b072-488d-481a-bcce-2dfd38d411ab"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 31, 14, 51, 57, 600, DateTimeKind.Unspecified).AddTicks(576), "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("f2fed544-0e4b-4cf5-8929-301d81643379"), true, new Guid("00000000-0000-0000-0000-000000000000"), new DateTime(2023, 5, 31, 14, 51, 57, 600, DateTimeKind.Unspecified).AddTicks(616), "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectsAcademicProgram_AcademicsPrograms_IdAcademicProgram",
                table: "SubjectsAcademicProgram",
                column: "IdAcademicProgram",
                principalTable: "AcademicsPrograms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectsAcademicProgram_Subjects_IdSubject",
                table: "SubjectsAcademicProgram",
                column: "IdSubject",
                principalTable: "Subjects",
                principalColumn: "Id");
        }
    }
}
