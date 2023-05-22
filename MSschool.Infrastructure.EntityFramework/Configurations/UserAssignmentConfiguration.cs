using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class UserAssignmentConfiguration : IEntityTypeConfiguration<UserAssignment>
{
    public void Configure(EntityTypeBuilder<UserAssignment> builder)
    {
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.SubjectStatus).HasMaxLength(50);

        builder.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.UserAssignments)
            .HasForeignKey(d => d.IdSubject)
            .HasConstraintName("FK_UserAssignments_Subjects");

        builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.UserAssignments)
            .HasForeignKey(d => d.IdUser)
            .HasConstraintName("FK_UserAssignments_Users");
    }
}
