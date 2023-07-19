using Microsoft.EntityFrameworkCore;
using MSschool.Application.Contracts.Insfrastructure;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicLevels;
using MSschool.Application.Domain.Models.AcademicProgramUsers;
using MSschool.Application.Domain.Models.AcademicsProgram;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Domain.Models.CourseNotes;
using MSschool.Application.Domain.Models.Institutions;
using MSschool.Application.Domain.Models.Schedules;
using MSschool.Application.Domain.Models.Subjects;
using MSschool.Application.Domain.Models.SubjectsAcademicProgram;
using MSschool.Application.Domain.Models.UserAssignments;
using MSschool.Application.Domain.Models.UserCategories;
using MSschool.Application.Domain.Models.Users;
using MSschool.Application.Domain.Models.ValueOfTheSubjects;
using System.Reflection;

namespace MSschool.Infrastructure.EntityFramework.Persistence;

public partial class MsschoolContext : DbContext
{
    private readonly IAuditContex? _auditContex;
    public MsschoolContext()
    {

    }

    public MsschoolContext(DbContextOptions<MsschoolContext> options, IAuditContex? auditContex) : base(options)
    {
        _auditContex = auditContex;
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

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var user = _auditContex?.GetUserFromRecord()!;
        foreach (var entry in ChangeTracker.Entries<Audit>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.SetCreatedByUser(user);
                    entry.Entity.SetAvailability(new Availability(true));
                    entry.Entity.SetCreatedDate(CreatedDate.CreationDate());
                    break;

                case EntityState.Modified:
                    entry.Entity.SetLastModifiedDate(LastModifiedDate.CreationDate());
                    entry.Entity.SetLastModifiedByUser(user);
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(Assembly
            .GetExecutingAssembly());

        modelBuilder.Entity<Category>()
            .HasData(MsschoolContextSeed
            .PreloadedCategories());

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
