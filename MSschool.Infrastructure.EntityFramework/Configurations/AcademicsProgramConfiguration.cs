using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class AcademicsProgramConfiguration : IEntityTypeConfiguration<AcademicsProgram>
{
    public void Configure(EntityTypeBuilder<AcademicsProgram> builder)
    {
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.Code).HasMaxLength(50);
        builder.Property(e => e.Modality).HasMaxLength(50);
        builder.Property(e => e.Name).HasMaxLength(200);
        builder.Property(e => e.ProgramStatus).HasMaxLength(50);

        builder.HasOne(d => d.IdAcademicDirectorNavigation).WithMany(p => p.AcademicsPrograms)
            .HasForeignKey(d => d.IdAcademicDirector)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_AcademicsPrograms_Users");

        builder.HasOne(d => d.IdAcademicLevelNavigation).WithMany(p => p.AcademicsPrograms)
            .HasForeignKey(d => d.IdAcademicLevel)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_AcademicsPrograms_AcademicLevels");

        builder.HasOne(d => d.IdInstitutionNavigation).WithMany(p => p.AcademicsPrograms)
            .HasForeignKey(d => d.IdInstitution)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_AcademicsPrograms_Institutions");
    }
}
