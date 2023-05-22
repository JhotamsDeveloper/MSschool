using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class AcademicProgramUserConfiguration : IEntityTypeConfiguration<AcademicProgramUser>
{
    public void Configure(EntityTypeBuilder<AcademicProgramUser> builder)
    {
        builder.Property(e => e.Id).ValueGeneratedNever();

        builder.HasOne(d => d.IdAcademicProgramNavigation).WithMany(p => p.AcademicProgramUsers)
            .HasForeignKey(d => d.IdAcademicProgram)
            .HasConstraintName("FK_AcademicProgramUsers_AcademicsPrograms");

        builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.AcademicProgramUsers)
            .HasForeignKey(d => d.IdUser)
            .HasConstraintName("FK_AcademicProgramUsers_Users");
    }
}
