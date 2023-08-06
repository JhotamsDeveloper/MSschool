using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Models.ValueOfTheSubjects;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class SubjectValueConfiguration : IEntityTypeConfiguration<SubjectValue>
{
    public void Configure(EntityTypeBuilder<SubjectValue> builder)
    {
        builder.Property(e => e.Year)
            .HasMaxLength(4)
            .IsFixedLength();

        builder.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.SubjectValues)
            .HasForeignKey(d => d.IdSubject)
            .OnDelete(DeleteBehavior.ClientSetNull);

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
