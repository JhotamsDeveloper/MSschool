using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Schedules;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.Property(e => e.Id).HasConversion(
            e => e!.Value,
            value => new Id(value));

        builder.Property(e => e.EndTime).HasColumnType("date");
        builder.Property(e => e.StartTime).HasColumnType("date");
        builder.Property(e => e.Weekday).HasMaxLength(15);

        builder.HasOne(d => d.IdAcademicProgramNavigation).WithMany(p => p.Schedules)
            .HasForeignKey(d => d.IdAcademicProgram);

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
