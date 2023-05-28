using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class v002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicProgramUsers_AcademicsPrograms",
                table: "AcademicProgramUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicProgramUsers_Users",
                table: "AcademicProgramUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicsPrograms_AcademicLevels",
                table: "AcademicsPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicsPrograms_Institutions",
                table: "AcademicsPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicsPrograms_Users",
                table: "AcademicsPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_AcademicsPrograms",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectsAcademicProgram_AcademicsPrograms",
                table: "SubjectsAcademicProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectsAcademicProgram_Subjects",
                table: "SubjectsAcademicProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectValues_Subjects",
                table: "SubjectValues");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAssignments_Subjects",
                table: "UserAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAssignments_Users",
                table: "UserAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCategories_Categories",
                table: "UserCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCategories_Categories1",
                table: "UserCategories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c4bc516-21eb-47cd-a594-88195eff6f62"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a852be9-7eef-4005-b2f6-0b4edad96394"));

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "SubjectValues",
                type: "nchar(4)",
                fixedLength: true,
                maxLength: 4,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(10)",
                oldFixedLength: true,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdSubject",
                table: "SubjectValues",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdSubject",
                table: "SubjectsAcademicProgram",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdAcademicProgram",
                table: "SubjectsAcademicProgram",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUser",
                table: "CourseNotes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTeacher",
                table: "CourseNotes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdSubject",
                table: "CourseNotes",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdInstitution",
                table: "AcademicsPrograms",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdAcademicLevel",
                table: "AcademicsPrograms",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdAcademicDirector",
                table: "AcademicsPrograms",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("0f1d3017-cc58-4e1a-a6e3-231459bbec77"), false, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" },
                    { new Guid("c6d8bcc9-b060-4db3-aaa6-7966438261c5"), false, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicProgramUsers_AcademicsPrograms_IdAcademicProgram",
                table: "AcademicProgramUsers",
                column: "IdAcademicProgram",
                principalTable: "AcademicsPrograms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicProgramUsers_Users_IdUser",
                table: "AcademicProgramUsers",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicsPrograms_AcademicLevels_IdAcademicLevel",
                table: "AcademicsPrograms",
                column: "IdAcademicLevel",
                principalTable: "AcademicLevels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicsPrograms_Institutions_IdInstitution",
                table: "AcademicsPrograms",
                column: "IdInstitution",
                principalTable: "Institutions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicsPrograms_Users_IdAcademicDirector",
                table: "AcademicsPrograms",
                column: "IdAcademicDirector",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_AcademicsPrograms_IdAcademicProgram",
                table: "Schedules",
                column: "IdAcademicProgram",
                principalTable: "AcademicsPrograms",
                principalColumn: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectValues_Subjects_IdSubject",
                table: "SubjectValues",
                column: "IdSubject",
                principalTable: "Subjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAssignments_Subjects_IdSubject",
                table: "UserAssignments",
                column: "IdSubject",
                principalTable: "Subjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAssignments_Users_IdUser",
                table: "UserAssignments",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategories_Categories_IdCategory",
                table: "UserCategories",
                column: "IdCategory",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategories_Users_IdUser",
                table: "UserCategories",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicProgramUsers_AcademicsPrograms_IdAcademicProgram",
                table: "AcademicProgramUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicProgramUsers_Users_IdUser",
                table: "AcademicProgramUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicsPrograms_AcademicLevels_IdAcademicLevel",
                table: "AcademicsPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicsPrograms_Institutions_IdInstitution",
                table: "AcademicsPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicsPrograms_Users_IdAcademicDirector",
                table: "AcademicsPrograms");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_AcademicsPrograms_IdAcademicProgram",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectsAcademicProgram_AcademicsPrograms_IdAcademicProgram",
                table: "SubjectsAcademicProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectsAcademicProgram_Subjects_IdSubject",
                table: "SubjectsAcademicProgram");

            migrationBuilder.DropForeignKey(
                name: "FK_SubjectValues_Subjects_IdSubject",
                table: "SubjectValues");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAssignments_Subjects_IdSubject",
                table: "UserAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAssignments_Users_IdUser",
                table: "UserAssignments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCategories_Categories_IdCategory",
                table: "UserCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCategories_Users_IdUser",
                table: "UserCategories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0f1d3017-cc58-4e1a-a6e3-231459bbec77"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6d8bcc9-b060-4db3-aaa6-7966438261c5"));

            migrationBuilder.AlterColumn<string>(
                name: "Year",
                table: "SubjectValues",
                type: "nchar(10)",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(4)",
                oldFixedLength: true,
                oldMaxLength: 4);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdSubject",
                table: "SubjectValues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdSubject",
                table: "SubjectsAcademicProgram",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdAcademicProgram",
                table: "SubjectsAcademicProgram",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdUser",
                table: "CourseNotes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdTeacher",
                table: "CourseNotes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdSubject",
                table: "CourseNotes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdInstitution",
                table: "AcademicsPrograms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdAcademicLevel",
                table: "AcademicsPrograms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "IdAcademicDirector",
                table: "AcademicsPrograms",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("3c4bc516-21eb-47cd-a594-88195eff6f62"), false, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("6a852be9-7eef-4005-b2f6-0b4edad96394"), false, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicProgramUsers_AcademicsPrograms",
                table: "AcademicProgramUsers",
                column: "IdAcademicProgram",
                principalTable: "AcademicsPrograms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicProgramUsers_Users",
                table: "AcademicProgramUsers",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicsPrograms_AcademicLevels",
                table: "AcademicsPrograms",
                column: "IdAcademicLevel",
                principalTable: "AcademicLevels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicsPrograms_Institutions",
                table: "AcademicsPrograms",
                column: "IdInstitution",
                principalTable: "Institutions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicsPrograms_Users",
                table: "AcademicsPrograms",
                column: "IdAcademicDirector",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_AcademicsPrograms",
                table: "Schedules",
                column: "IdAcademicProgram",
                principalTable: "AcademicsPrograms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectsAcademicProgram_AcademicsPrograms",
                table: "SubjectsAcademicProgram",
                column: "IdAcademicProgram",
                principalTable: "AcademicsPrograms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectsAcademicProgram_Subjects",
                table: "SubjectsAcademicProgram",
                column: "IdSubject",
                principalTable: "Subjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SubjectValues_Subjects",
                table: "SubjectValues",
                column: "IdSubject",
                principalTable: "Subjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAssignments_Subjects",
                table: "UserAssignments",
                column: "IdSubject",
                principalTable: "Subjects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAssignments_Users",
                table: "UserAssignments",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategories_Categories",
                table: "UserCategories",
                column: "IdUser",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCategories_Categories1",
                table: "UserCategories",
                column: "IdCategory",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
