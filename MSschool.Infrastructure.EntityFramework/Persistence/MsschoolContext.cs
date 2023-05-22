using Microsoft.EntityFrameworkCore;
using MSschool.Application.Domain;
using MSschool.Application.Domain.Common;
using MSschool.Infrastructure.EntityFramework.Configurations;

namespace MSschool.Infrastructure.EntityFramework.Persistence;

public partial class MsschoolContext: DbContext
{
    public MsschoolContext()
    {
            
    }

    public MsschoolContext(DbContextOptions<MsschoolContext> options): base(options)
    {
        
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        foreach (var entry in ChangeTracker.Entries<Audit>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedDate = DateTime.Now;
                    entry.Entity.CreatedBy = "system";
                    break;

                case EntityState.Modified:
                    entry.Entity.LastModifiedDate = DateTime.Now;
                    entry.Entity.LastModifiedBy = "system";
                    break;
            }
        }

        return base.SaveChangesAsync(cancellationToken);
    }

    public virtual DbSet<AcademicLevel> AcademicLevels { get; set; }

    public virtual DbSet<AcademicProgramUser> AcademicProgramUsers { get; set; }

    public virtual DbSet<AcademicsProgram> AcademicsPrograms { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CourseNote> CourseNotes { get; set; }

    public virtual DbSet<Institution> Institutions { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<SubjectValue> SubjectValues { get; set; }

    public virtual DbSet<SubjectsAcademicProgram> SubjectsAcademicPrograms { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserAssignment> UserAssignments { get; set; }

    public virtual DbSet<UserCategory> UserCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Settings();
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
