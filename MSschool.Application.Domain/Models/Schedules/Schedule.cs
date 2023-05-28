﻿using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicsProgram;

namespace MSschool.Application.Domain.Models.Schedules;

public partial class Schedule : Audit
{
    public Schedule(Id id, Id createdByIdUser) : base(id, createdByIdUser)
    {
    }

    public Id? IdAcademicProgram { get; private set; }

    public string Weekday { get; private set; } = null!;

    public DateTime? StartTime { get; private set; }

    public DateTime? EndTime { get; private set; }

    public virtual AcademicProgram? IdAcademicProgramNavigation { get; private set; }
}
