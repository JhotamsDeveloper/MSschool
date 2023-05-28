using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.SubjectsAcademicProgram;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class SubjectsAcademicProgramConfiguration : IEntityTypeConfiguration<SubjectOfTheAcademicProgram>
{
    public void Configure(EntityTypeBuilder<SubjectOfTheAcademicProgram> builder)
    {
        builder.ToTable("SubjectsAcademicProgram");

        builder.Property(e => e.Id).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.HasOne(d => d.IdAcademicProgramNavigation).WithMany(p => p.SubjectsAcademicPrograms)
            .HasForeignKey(d => d.IdAcademicProgram)
            .OnDelete(DeleteBehavior.ClientSetNull);

        builder.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.SubjectsAcademicPrograms)
            .HasForeignKey(d => d.IdSubject)
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
