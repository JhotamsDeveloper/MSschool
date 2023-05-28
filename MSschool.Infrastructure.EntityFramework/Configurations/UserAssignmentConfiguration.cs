using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.UserAssignments;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class UserAssignmentConfiguration : IEntityTypeConfiguration<UserAssignment>
{
    public void Configure(EntityTypeBuilder<UserAssignment> builder)
    {
        builder.Property(e => e.Id).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.Property(e => e.SubjectStatus).HasMaxLength(50);

        builder.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.UserAssignments)
            .HasForeignKey(d => d.IdSubject);

        builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserAssignments)
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
