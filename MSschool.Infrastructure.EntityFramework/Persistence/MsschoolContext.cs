﻿using Microsoft.EntityFrameworkCore;
using MSschool.Application.Domain.Models.AcademicLevels;
using MSschool.Application.Domain.Models.AcademicProgramUsers;
using MSschool.Application.Domain.Models.AcademicsProgram;
using MSschool.Application.Domain.Models.CourseNotes;
using MSschool.Application.Domain.Models.Institutions;
using MSschool.Application.Domain.Models.Schedules;
using MSschool.Application.Domain.Models.Subjects;
using MSschool.Application.Domain.Models.SubjectsAcademicProgram;
using MSschool.Application.Domain.Models.Users;
using MSschool.Application.Domain.Models.UserAssignments;
using MSschool.Application.Domain.Models.ValueOfTheSubjects;
using MSschool.Infrastructure.EntityFramework.Configurations;
using MSschool.Application.Domain.Models.UserCategories;
using MSschool.Application.Domain.Models.Categories;

namespace MSschool.Infrastructure.EntityFramework.Persistence;

public partial class MsschoolContext: DbContext
{
    public MsschoolContext()
    {
            
    }

    public MsschoolContext(DbContextOptions<MsschoolContext> options): base(options)
    {
        
    }

    public virtual DbSet<AcademicLevel> AcademicLevels { get; set; }

    public virtual DbSet<AcademicProgramUser> AcademicProgramUsers { get; set; }

    public virtual DbSet<AcademicProgram> AcademicsPrograms { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CourseNote> CourseNotes { get; set; }

    public virtual DbSet<Institution> Institutions { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<SubjectValue> SubjectValues { get; set; }

    public virtual DbSet<SubjectOfTheAcademicProgram> SubjectsAcademicPrograms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAssignment> UserAssignments { get; set; }

    public virtual DbSet<UserCategory> UserCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Settings();
        modelBuilder.Entity<Category>()
            .HasData(MsschoolContextSeed
            .PreloadedCategories());
        
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
