using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Subjects;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class SubjectConfiguration : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.Property(e => e.Id).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.Property(e => e.Modality).HasMaxLength(50);
        builder.Property(e => e.Name).HasMaxLength(100);
        builder.Property(e => e.PreRequisite).HasMaxLength(50);

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
