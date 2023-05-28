using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.UserCategories;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class UserCategoryConfiguration : IEntityTypeConfiguration<UserCategory>
{
    public void Configure(EntityTypeBuilder<UserCategory> builder)
    {
        builder.Property(e => e.Id).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.UserCategories)
            .HasForeignKey(d => d.IdCategory);

        builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserCategories)
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
