using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Geolocation;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

public class ColombiaConfiguration : IEntityTypeConfiguration<Colombia>
{
    public void Configure(EntityTypeBuilder<Colombia> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(e => e.Id).HasConversion(
            e => e.Value,
            value => new Id(value));

        builder.Property(e => e.Region)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.DepartmentCode)
            .IsRequired();

        builder.Property(e => e.Department)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.CityCode)
            .IsRequired();

        builder.Property(e => e.City)
            .HasMaxLength(100)
            .IsRequired();

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
