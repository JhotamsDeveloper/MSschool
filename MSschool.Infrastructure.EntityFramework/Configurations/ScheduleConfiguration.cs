using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.EndTime).HasColumnType("date");
        builder.Property(e => e.StartTime).HasColumnType("date");
        builder.Property(e => e.Weekday).HasMaxLength(15);

        builder.HasOne(d => d.IdAcademicProgramNavigation).WithMany(p => p.Schedules)
            .HasForeignKey(d => d.IdAcademicProgram)
            .HasConstraintName("FK_Schedules_AcademicsPrograms");
    }
}
