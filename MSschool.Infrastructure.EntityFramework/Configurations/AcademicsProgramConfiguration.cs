using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicsProgram;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class AcademicsProgramConfiguration : IEntityTypeConfiguration<AcademicProgram>
{
    public void Configure(EntityTypeBuilder<AcademicProgram> builder)
    {
        builder.Property(e => e.Id).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.Property(e => e.Code).HasMaxLength(50);
        builder.Property(e => e.Modality).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasConversion(e => e!.Value, value => new Name(value))
            .HasMaxLength(50);

        builder.Property(e => e.ProgramStatus).HasMaxLength(50);

        builder.HasOne(d => d.IdAcademicDirectorNavigation).WithMany(p => p.AcademicsPrograms)
            .HasForeignKey(d => d.IdAcademicDirector)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(d => d.IdAcademicLevelNavigation).WithMany(p => p.AcademicsPrograms)
            .HasForeignKey(d => d.IdAcademicLevel)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(d => d.IdInstitutionNavigation).WithMany(p => p.AcademicsPrograms)
            .HasForeignKey(d => d.IdInstitution)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.Property(e => e.CreatedDate).HasConversion(
            CreatedDate => CreatedDate!.Date,
            value => new CreatedDate(value));

        builder.Property(e => e.LastModifiedDate).HasConversion(
            LastModifiedDate => LastModifiedDate!.Date,
            value => new LastModifiedDate(value));

        builder.Property(e => e.CreatedByIdUser).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.Property(e => e.LastModifiedByIdUser).HasConversion(
            e => e!.Value,
            value => new Id(value));
    }
}
