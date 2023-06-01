using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.CourseNotes;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class CourseNoteConfiguration : IEntityTypeConfiguration<CourseNote>
{
    public void Configure(EntityTypeBuilder<CourseNote> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(e => e.Id).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.Property(e => e.NoteDate).HasColumnType("date");
        builder.Property(e => e.NoteValue).HasColumnType("decimal(18, 0)");
        builder.Property(e => e.Percentages).HasColumnType("decimal(18, 0)");

        builder.HasOne(d => d.IdSubjectNavigation).WithMany(p => p.CourseNotes)
            .HasForeignKey(d => d.IdSubject)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CourseNotes_Subjects");

        builder.HasOne(d => d.IdTeacherNavigation).WithMany(p => p.CourseNoteIdTeacherNavigations)
            .HasForeignKey(d => d.IdTeacher)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CourseNotes_Teacher");

        builder.HasOne(d => d.IdUserNavigation).WithMany(p => p.CourseNoteIdUserNavigations)
            .HasForeignKey(d => d.IdUser)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_CourseNotes_User");

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

        builder.Property(e => e.CreatedByIdUser).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.Property(e => e.LastModifiedByIdUser).HasConversion(
            e => e!.Value,
            value => new Id(value));
        #endregion
    }
}
