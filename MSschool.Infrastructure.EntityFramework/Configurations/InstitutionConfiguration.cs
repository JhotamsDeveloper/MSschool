using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Institutions;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class InstitutionConfiguration : IEntityTypeConfiguration<Institution>
{
    public void Configure(EntityTypeBuilder<Institution> builder)
    {
        builder.Property(e => e.Id).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.Property(e => e.Address).HasMaxLength(200);
        builder.Property(e => e.City).HasMaxLength(50);
        builder.Property(e => e.CityCode)
            .HasMaxLength(10)
            .IsFixedLength();
        builder.Property(e => e.Department).HasMaxLength(50);
        builder.Property(e => e.DepartmentCode)
            .HasMaxLength(10)
            .IsFixedLength();
        builder.Property(e => e.Email).HasMaxLength(50);

        builder.Property(e => e.Name)
            .HasConversion(e => e!.Value, value => new Name(value))
            .HasMaxLength(50);

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
