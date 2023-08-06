using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Models.UserAssignments;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class UserAssignmentConfiguration : IEntityTypeConfiguration<UserAssignment>
{
    public void Configure(EntityTypeBuilder<UserAssignment> builder)
    {
        builder.Property(e => e.SubjectStatus).HasMaxLength(50);

        builder.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.UserAssignments)
            .HasForeignKey(d => d.IdSubject);

        builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserAssignments)
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
