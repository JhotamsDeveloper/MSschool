using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class SubjectsAcademicProgramConfiguration : IEntityTypeConfiguration<SubjectsAcademicProgram>
{
    public void Configure(EntityTypeBuilder<SubjectsAcademicProgram> builder)
    {
        builder.ToTable("SubjectsAcademicProgram");

        builder.Property(e => e.Id).ValueGeneratedNever();

        builder.HasOne(d => d.IdAcademicProgramNavigation).WithMany(p => p.SubjectsAcademicPrograms)
            .HasForeignKey(d => d.IdAcademicProgram)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SubjectsAcademicProgram_AcademicsPrograms");

        builder.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.SubjectsAcademicPrograms)
            .HasForeignKey(d => d.IdSubject)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SubjectsAcademicProgram_Subjects");
    }
}
