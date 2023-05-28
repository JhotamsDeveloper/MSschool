using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicLevels;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class AcademicLevelConfiguration : IEntityTypeConfiguration<AcademicLevel>
{
    public void Configure(EntityTypeBuilder<AcademicLevel> builder)
    {
        builder.Property(e => e.Id).HasConversion(
            e => e!.Value, 
            value => new Id(value));

        builder.Property(e => e.Code).HasMaxLength(50);
        builder.Property(e => e.Name).HasMaxLength(50);

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