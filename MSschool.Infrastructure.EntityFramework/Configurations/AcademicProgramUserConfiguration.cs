using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicProgramUsers;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class AcademicProgramUserConfiguration : IEntityTypeConfiguration<AcademicProgramUser>
{
    public void Configure(EntityTypeBuilder<AcademicProgramUser> builder)
    {
        builder.HasOne(d => d.IdAcademicProgramNavigation).WithMany(p => p.AcademicProgramUsers)
            .HasForeignKey(d => d.IdAcademicProgram);

        builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.AcademicProgramUsers)
            .HasForeignKey(d => d.IdUser);

        #region "AUDIT"
        builder.HasKey(x => x.Id);
        builder.Property(e => e.Id).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.Property(e => e.CreatedDate).HasConversion(
            CreatedDate => CreatedDate!.Value,
            value => CreatedDate.CreationDate());

        builder.Property(e => e.LastModifiedDate).HasConversion(
            LastModifiedDate => LastModifiedDate!.Value,
            value => LastModifiedDate.CreationDate());

        builder.Property(e => e.Availability)
            .HasConversion(
            e => e!.Value,
            value => new Availability(value));

        builder.Property(e => e.CreatedByUser).IsRequired(false);
        builder.Property(e => e.LastModifiedByUser).IsRequired(false);
        #endregion
    }
}
