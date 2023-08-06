using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Institutions;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class InstitutionConfiguration : IEntityTypeConfiguration<Institution>
{
    public void Configure(EntityTypeBuilder<Institution> builder)
    {
        builder.Property(e => e.Address).HasMaxLength(300);
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
