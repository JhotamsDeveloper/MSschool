﻿// <auto-generated />
using System;
using MSschool.Infrastructure.EntityFramework.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MSschool.Infrastructure.EntityFramework.Migrations
{
    [DbContext(typeof(MsschoolContext))]
    [Migration("20230531195157_v0-0-5")]
    partial class v005
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MSschool.Application.Domain.Models.AcademicLevels.AcademicLevel", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SemesterQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AcademicLevels");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.AcademicProgramUsers.AcademicProgramUser", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdAcademicProgram")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdAcademicProgram");

                    b.HasIndex("IdUser");

                    b.ToTable("AcademicProgramUsers");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.AcademicsProgram.AcademicProgram", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdAcademicDirector")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdAcademicLevel")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdInstitution")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Modality")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProgramStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdAcademicDirector");

                    b.HasIndex("IdAcademicLevel");

                    b.HasIndex("IdInstitution");

                    b.ToTable("AcademicsPrograms");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.Categories.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5203b072-488d-481a-bcce-2dfd38d411ab"),
                            Availability = true,
                            CreatedByIdUser = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(2023, 5, 31, 14, 51, 57, 600, DateTimeKind.Unspecified).AddTicks(576),
                            Description = "Persona que presta los servicios de docencia a la institución.",
                            Name = "Docente"
                        },
                        new
                        {
                            Id = new Guid("f2fed544-0e4b-4cf5-8929-301d81643379"),
                            Availability = true,
                            CreatedByIdUser = new Guid("00000000-0000-0000-0000-000000000000"),
                            CreatedDate = new DateTime(2023, 5, 31, 14, 51, 57, 600, DateTimeKind.Unspecified).AddTicks(616),
                            Description = "Persona que se encuentra estudiando a la institución.",
                            Name = "Estudiante"
                        });
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.CourseNotes.CourseNote", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdSubject")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdTeacher")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NoteDate")
                        .HasColumnType("date");

                    b.Property<decimal>("NoteValue")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("Observation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Percentages")
                        .HasColumnType("decimal(18, 0)");

                    b.HasKey("Id");

                    b.HasIndex("IdSubject");

                    b.HasIndex("IdTeacher");

                    b.HasIndex("IdUser");

                    b.ToTable("CourseNotes");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.Institutions.Institution", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CityCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DepartmentCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Institutions");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.Schedules.Schedule", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("date");

                    b.Property<Guid?>("IdAcademicProgram")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("date");

                    b.Property<string>("Weekday")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("IdAcademicProgram");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.Subjects.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Modality")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PreRequisite")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.SubjectsAcademicProgram.SubjectOfTheAcademicProgram", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdAcademicProgram")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdSubject")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdAcademicProgram");

                    b.HasIndex("IdSubject");

                    b.ToTable("SubjectsAcademicProgram", (string)null);
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.UserAssignments.UserAssignment", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdSubject")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdSubject");

                    b.HasIndex("IdUser");

                    b.ToTable("UserAssignments");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.UserCategories.UserCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdCategory")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdCategory");

                    b.HasIndex("IdUser");

                    b.ToTable("UserCategories");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.Users.User", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressOfDomicile")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("date");

                    b.Property<string>("CellPhone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("CityOfBirth")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CityOfDomicile")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CountryOfBirth")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("CountryOfDomicile")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartmentOdDomicile")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DepartmentOfBirth")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DocumentType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IndicativeCountryOfBirth")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<string>("IndicativeCountryOfDomicile")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength();

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("SecondName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SecondSurname")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.ValueOfTheSubjects.SubjectValue", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<Guid>("CreatedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("IdSubject")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("Iva")
                        .HasColumnType("int");

                    b.Property<Guid?>("LastModifiedByIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<string>("Year")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nchar(4)")
                        .IsFixedLength();

                    b.HasKey("Id");

                    b.HasIndex("IdSubject");

                    b.ToTable("SubjectValues");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.AcademicProgramUsers.AcademicProgramUser", b =>
                {
                    b.HasOne("MSschool.Application.Domain.Models.AcademicsProgram.AcademicProgram", "IdAcademicProgramNavigation")
                        .WithMany("AcademicProgramUsers")
                        .HasForeignKey("IdAcademicProgram");

                    b.HasOne("MSschool.Application.Domain.Models.Users.User", "IdUserNavigation")
                        .WithMany("AcademicProgramUsers")
                        .HasForeignKey("IdUser");

                    b.Navigation("IdAcademicProgramNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.AcademicsProgram.AcademicProgram", b =>
                {
                    b.HasOne("MSschool.Application.Domain.Models.Users.User", "IdAcademicDirectorNavigation")
                        .WithMany("AcademicsPrograms")
                        .HasForeignKey("IdAcademicDirector");

                    b.HasOne("MSschool.Application.Domain.Models.AcademicLevels.AcademicLevel", "IdAcademicLevelNavigation")
                        .WithMany("AcademicsPrograms")
                        .HasForeignKey("IdAcademicLevel");

                    b.HasOne("MSschool.Application.Domain.Models.Institutions.Institution", "IdInstitutionNavigation")
                        .WithMany("AcademicsPrograms")
                        .HasForeignKey("IdInstitution");

                    b.Navigation("IdAcademicDirectorNavigation");

                    b.Navigation("IdAcademicLevelNavigation");

                    b.Navigation("IdInstitutionNavigation");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.CourseNotes.CourseNote", b =>
                {
                    b.HasOne("MSschool.Application.Domain.Models.Subjects.Subject", "IdSubjectNavigation")
                        .WithMany("CourseNotes")
                        .HasForeignKey("IdSubject")
                        .HasConstraintName("FK_CourseNotes_Subjects");

                    b.HasOne("MSschool.Application.Domain.Models.Users.User", "IdTeacherNavigation")
                        .WithMany("CourseNoteIdTeacherNavigations")
                        .HasForeignKey("IdTeacher")
                        .HasConstraintName("FK_CourseNotes_Teacher");

                    b.HasOne("MSschool.Application.Domain.Models.Users.User", "IdUserNavigation")
                        .WithMany("CourseNoteIdUserNavigations")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("FK_CourseNotes_User");

                    b.Navigation("IdSubjectNavigation");

                    b.Navigation("IdTeacherNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.Schedules.Schedule", b =>
                {
                    b.HasOne("MSschool.Application.Domain.Models.AcademicsProgram.AcademicProgram", "IdAcademicProgramNavigation")
                        .WithMany("Schedules")
                        .HasForeignKey("IdAcademicProgram");

                    b.Navigation("IdAcademicProgramNavigation");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.SubjectsAcademicProgram.SubjectOfTheAcademicProgram", b =>
                {
                    b.HasOne("MSschool.Application.Domain.Models.AcademicsProgram.AcademicProgram", "IdAcademicProgramNavigation")
                        .WithMany("SubjectsAcademicPrograms")
                        .HasForeignKey("IdAcademicProgram");

                    b.HasOne("MSschool.Application.Domain.Models.Subjects.Subject", "IdSubjectNavigation")
                        .WithMany("SubjectsAcademicPrograms")
                        .HasForeignKey("IdSubject");

                    b.Navigation("IdAcademicProgramNavigation");

                    b.Navigation("IdSubjectNavigation");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.UserAssignments.UserAssignment", b =>
                {
                    b.HasOne("MSschool.Application.Domain.Models.Subjects.Subject", "IdSubjectNavigation")
                        .WithMany("UserAssignments")
                        .HasForeignKey("IdSubject");

                    b.HasOne("MSschool.Application.Domain.Models.Users.User", "IdUserNavigation")
                        .WithMany("UserAssignments")
                        .HasForeignKey("IdUser");

                    b.Navigation("IdSubjectNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.UserCategories.UserCategory", b =>
                {
                    b.HasOne("MSschool.Application.Domain.Models.Categories.Category", "IdCategoryNavigation")
                        .WithMany("UserCategories")
                        .HasForeignKey("IdCategory");

                    b.HasOne("MSschool.Application.Domain.Models.Users.User", "IdUserNavigation")
                        .WithMany("UserCategories")
                        .HasForeignKey("IdUser");

                    b.Navigation("IdCategoryNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.ValueOfTheSubjects.SubjectValue", b =>
                {
                    b.HasOne("MSschool.Application.Domain.Models.Subjects.Subject", "IdSubjectNavigation")
                        .WithMany("SubjectValues")
                        .HasForeignKey("IdSubject");

                    b.Navigation("IdSubjectNavigation");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.AcademicLevels.AcademicLevel", b =>
                {
                    b.Navigation("AcademicsPrograms");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.AcademicsProgram.AcademicProgram", b =>
                {
                    b.Navigation("AcademicProgramUsers");

                    b.Navigation("Schedules");

                    b.Navigation("SubjectsAcademicPrograms");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.Categories.Category", b =>
                {
                    b.Navigation("UserCategories");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.Institutions.Institution", b =>
                {
                    b.Navigation("AcademicsPrograms");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.Subjects.Subject", b =>
                {
                    b.Navigation("CourseNotes");

                    b.Navigation("SubjectValues");

                    b.Navigation("SubjectsAcademicPrograms");

                    b.Navigation("UserAssignments");
                });

            modelBuilder.Entity("MSschool.Application.Domain.Models.Users.User", b =>
                {
                    b.Navigation("AcademicProgramUsers");

                    b.Navigation("AcademicsPrograms");

                    b.Navigation("CourseNoteIdTeacherNavigations");

                    b.Navigation("CourseNoteIdUserNavigations");

                    b.Navigation("UserAssignments");

                    b.Navigation("UserCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
