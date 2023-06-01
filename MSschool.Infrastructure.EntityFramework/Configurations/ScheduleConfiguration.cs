﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Schedules;

namespace MSschool.Infrastructure.EntityFramework.Configurations;

internal class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.Property(e => e.EndTime).HasColumnType("date");
        builder.Property(e => e.StartTime).HasColumnType("date");
        builder.Property(e => e.Weekday).HasMaxLength(15);

        builder.HasOne(d => d.IdAcademicProgramNavigation).WithMany(p => p.Schedules)
            .HasForeignKey(d => d.IdAcademicProgram);

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
