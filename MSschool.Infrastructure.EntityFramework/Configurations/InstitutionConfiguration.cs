using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class InstitutionConfiguration : IEntityTypeConfiguration<Institution>
{
    public void Configure(EntityTypeBuilder<Institution> builder)
    {
        builder.Property(e => e.Id).ValueGeneratedNever();
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
        builder.Property(e => e.Name).HasMaxLength(50);
    }
}
