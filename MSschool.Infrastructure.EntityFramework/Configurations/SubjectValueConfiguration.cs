using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.ValueOfTheSubjects;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class SubjectValueConfiguration : IEntityTypeConfiguration<SubjectValue>
{
    public void Configure(EntityTypeBuilder<SubjectValue> builder)
    {
        builder.Property(e => e.Id).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.Property(e => e.Year)
            .HasMaxLength(4)
            .IsFixedLength();

        builder.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.SubjectValues)
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
