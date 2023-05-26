using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class V001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SemesterQuantity = table.Column<int>(type: "int", nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartmentCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CityCode = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Credit = table.Column<int>(type: "int", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    PreRequisite = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Modality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecondSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DocumentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DocumentNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Birthdate = table.Column<DateTime>(type: "date", nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    IndicativeCountryOfBirth = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CountryOfBirth = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DepartmentOfBirth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CityOfBirth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IndicativeCountryOfDomicile = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: true),
                    CountryOfDomicile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    DepartmentOdDomicile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CityOfDomicile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    AddressOfDomicile = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubjectValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Year = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false),
                    Iva = table.Column<int>(type: "int", nullable: true),
                    IdSubject = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectValues_Subjects",
                        column: x => x.IdSubject,
                        principalTable: "Subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AcademicsPrograms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdAcademicLevel = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAcademicDirector = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProgramStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Modality = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdInstitution = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicsPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcademicsPrograms_AcademicLevels",
                        column: x => x.IdAcademicLevel,
                        principalTable: "AcademicLevels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AcademicsPrograms_Institutions",
                        column: x => x.IdInstitution,
                        principalTable: "Institutions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AcademicsPrograms_Users",
                        column: x => x.IdAcademicDirector,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CourseNotes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Percentages = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    NoteValue = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    NoteDate = table.Column<DateTime>(type: "date", nullable: false),
                    Observation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdTeacher = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSubject = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseNotes_Subjects",
                        column: x => x.IdSubject,
                        principalTable: "Subjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CourseNotes_Teacher",
                        column: x => x.IdTeacher,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CourseNotes_User",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserAssignments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdSubject = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubjectStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAssignments_Subjects",
                        column: x => x.IdSubject,
                        principalTable: "Subjects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserAssignments_Users",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCategory = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserCategories_Categories",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserCategories_Categories1",
                        column: x => x.IdCategory,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AcademicProgramUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdAcademicProgram = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicProgramUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcademicProgramUsers_AcademicsPrograms",
                        column: x => x.IdAcademicProgram,
                        principalTable: "AcademicsPrograms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AcademicProgramUsers_Users",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAcademicProgram = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Weekday = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    StartTime = table.Column<DateTime>(type: "date", nullable: true),
                    EndTime = table.Column<DateTime>(type: "date", nullable: true),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_AcademicsPrograms",
                        column: x => x.IdAcademicProgram,
                        principalTable: "AcademicsPrograms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SubjectsAcademicProgram",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSubject = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAcademicProgram = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectsAcademicProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubjectsAcademicProgram_AcademicsPrograms",
                        column: x => x.IdAcademicProgram,
                        principalTable: "AcademicsPrograms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubjectsAcademicProgram_Subjects",
                        column: x => x.IdSubject,
                        principalTable: "Subjects",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Availability", "CreatedBy", "CreatedDate", "Description", "LastModifiedBy", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("3c4bc516-21eb-47cd-a594-88195eff6f62"), false, null, null, "Persona que presta los servicios de docencia a la institución.", null, null, "Docente" },
                    { new Guid("6a852be9-7eef-4005-b2f6-0b4edad96394"), false, null, null, "Persona que se encuentra estudiando a la institución.", null, null, "Estudiante" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicProgramUsers_IdAcademicProgram",
                table: "AcademicProgramUsers",
                column: "IdAcademicProgram");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicProgramUsers_IdUser",
                table: "AcademicProgramUsers",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicsPrograms_IdAcademicDirector",
                table: "AcademicsPrograms",
                column: "IdAcademicDirector");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicsPrograms_IdAcademicLevel",
                table: "AcademicsPrograms",
                column: "IdAcademicLevel");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicsPrograms_IdInstitution",
                table: "AcademicsPrograms",
                column: "IdInstitution");

            migrationBuilder.CreateIndex(
                name: "IX_CourseNotes_IdSubject",
                table: "CourseNotes",
                column: "IdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_CourseNotes_IdTeacher",
                table: "CourseNotes",
                column: "IdTeacher");

            migrationBuilder.CreateIndex(
                name: "IX_CourseNotes_IdUser",
                table: "CourseNotes",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_IdAcademicProgram",
                table: "Schedules",
                column: "IdAcademicProgram");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectsAcademicProgram_IdAcademicProgram",
                table: "SubjectsAcademicProgram",
                column: "IdAcademicProgram");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectsAcademicProgram_IdSubject",
                table: "SubjectsAcademicProgram",
                column: "IdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_SubjectValues_IdSubject",
                table: "SubjectValues",
                column: "IdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssignments_IdSubject",
                table: "UserAssignments",
                column: "IdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_UserAssignments_IdUser",
                table: "UserAssignments",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_UserCategories_IdCategory",
                table: "UserCategories",
                column: "IdCategory");

            migrationBuilder.CreateIndex(
                name: "IX_UserCategories_IdUser",
                table: "UserCategories",
                column: "IdUser");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicProgramUsers");

            migrationBuilder.DropTable(
                name: "CourseNotes");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "SubjectsAcademicProgram");

            migrationBuilder.DropTable(
                name: "SubjectValues");

            migrationBuilder.DropTable(
                name: "UserAssignments");

            migrationBuilder.DropTable(
                name: "UserCategories");

            migrationBuilder.DropTable(
                name: "AcademicsPrograms");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AcademicLevels");

            migrationBuilder.DropTable(
                name: "Institutions");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
