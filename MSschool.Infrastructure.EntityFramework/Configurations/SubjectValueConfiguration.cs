using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class SubjectValueConfiguration : IEntityTypeConfiguration<SubjectValue>
{
    public void Configure(EntityTypeBuilder<SubjectValue> builder)
    {
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.Year)
            .HasMaxLength(10)
            .IsFixedLength();

        builder.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.SubjectValues)
            .HasForeignKey(d => d.IdSubject)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_SubjectValues_Subjects");
    }
}
