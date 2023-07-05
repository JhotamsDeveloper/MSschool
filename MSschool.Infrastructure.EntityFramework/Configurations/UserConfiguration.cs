using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Users;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(e => e.AddressOfDomicile).HasMaxLength(200);
        builder.Property(e => e.Birthdate).HasColumnType("date");
        builder.Property(e => e.CellPhone).HasMaxLength(15);
        builder.Property(e => e.CityOfBirth).HasMaxLength(50);
        builder.Property(e => e.CityOfDomicile).HasMaxLength(50);
        builder.Property(e => e.CountryOfBirth).HasMaxLength(20);
        builder.Property(e => e.CountryOfDomicile).HasMaxLength(20);
        builder.Property(e => e.DepartmentOdDomicile).HasMaxLength(50);
        builder.Property(e => e.DepartmentOfBirth).HasMaxLength(50);
        builder.Property(e => e.DocumentNumber).HasMaxLength(50);
        builder.Property(e => e.DocumentType).HasMaxLength(50);
        builder.Property(e => e.Email).HasMaxLength(200).IsUnicode();
        builder.Property(e => e.FirstName).HasMaxLength(50);
        builder.Property(e => e.IndicativeCountryOfBirth)
            .HasMaxLength(10)
            .IsFixedLength();
        builder.Property(e => e.IndicativeCountryOfDomicile)
            .HasMaxLength(10)
            .IsFixedLength();
        builder.Property(e => e.Phone).HasMaxLength(20);
        builder.Property(e => e.SecondName).HasMaxLength(50);
        builder.Property(e => e.SecondSurname).HasMaxLength(50);
        builder.Property(e => e.Surname).HasMaxLength(50);

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
