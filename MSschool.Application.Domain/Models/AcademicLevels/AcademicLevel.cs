﻿using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicsProgram;

namespace MSschool.Application.Domain.Models.AcademicLevels;

public partial class AcademicLevel : Audit
{
    public AcademicLevel(Id id, Id createdByIdUser) : base(id, createdByIdUser)
    {
    }

    public Name? Name { get; private set; }

    public string Code { get; private set; } = null!;

    public int SemesterQuantity { get; private set; }

    public virtual ICollection<AcademicProgram> AcademicsPrograms { get; set; } = new List<AcademicProgram>();
}
