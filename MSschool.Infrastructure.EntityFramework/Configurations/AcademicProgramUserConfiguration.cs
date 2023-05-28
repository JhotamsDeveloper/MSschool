using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicProgramUsers;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class AcademicProgramUserConfiguration : IEntityTypeConfiguration<AcademicProgramUser>
{
    public void Configure(EntityTypeBuilder<AcademicProgramUser> builder)
    {
        builder.Property(e => e.Id).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.HasOne(d => d.IdAcademicProgramNavigation).WithMany(p => p.AcademicProgramUsers)
            .HasForeignKey(d => d.IdAcademicProgram);

        builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.AcademicProgramUsers)
            .HasForeignKey(d => d.IdUser);

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
