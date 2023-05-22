using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class UserCategoryConfiguration : IEntityTypeConfiguration<UserCategory>
{
    public void Configure(EntityTypeBuilder<UserCategory> builder)
    {
        builder.Property(e => e.Id).ValueGeneratedNever();

        builder.HasOne(d => d.IdCategoryNavigation).WithMany(p => p.UserCategories)
            .HasForeignKey(d => d.IdCategory)
            .HasConstraintName("FK_UserCategories_Categories1");

        builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserCategories)
            .HasForeignKey(d => d.IdUser)
            .HasConstraintName("FK_UserCategories_Categories");
    }
}
