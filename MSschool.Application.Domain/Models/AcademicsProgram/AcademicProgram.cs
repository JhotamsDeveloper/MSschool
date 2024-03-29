﻿using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicLevels;
using MSschool.Application.Domain.Models.AcademicProgramUsers;
using MSschool.Application.Domain.Models.Institutions;
using MSschool.Application.Domain.Models.Schedules;
using MSschool.Application.Domain.Models.SubjectsAcademicProgram;
using MSschool.Application.Domain.Models.Users;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Application.Domain.Models.AcademicsProgram;

public partial class AcademicProgram : Audit
{
    public AcademicProgram(
        Id id, 
        Name name, 
        string code, 
        string programStatus, 
        string modality,
        Id idAcademicLevel,
        Id idAcademicDirector,
        Id idInstitution) : base(id)
    {
        Name = name; 
        Code= code; 
        ProgramStatus= programStatus; 
        Modality= modality;
        IdAcademicDirector= idAcademicDirector;
        IdAcademicLevel= idAcademicLevel;
        IdInstitution= idInstitution;
    }

    public Name? Name { get; private set; }

    public string Code { get; private set; } = null!;

    public string ProgramStatus { get; private set; } = null!;

    public string Modality { get; private set; } = null!;

    public Id? IdAcademicLevel { get; private set; }

    public Id? IdAcademicDirector { get; private set; }

    public Id? IdInstitution { get; private set; }


    public virtual User IdAcademicDirectorNavigation { get; private set; } = null!;

    public virtual AcademicLevel IdAcademicLevelNavigation { get; private set; } = null!;

    public virtual Institution IdInstitutionNavigation { get; private set; } = null!;

    public virtual ICollection<Schedule> Schedules { get; private set; } = new List<Schedule>();
    public virtual ICollection<AcademicProgramUser> AcademicProgramUsers { get; private set; } = new List<AcademicProgramUser>();
    public virtual ICollection<SubjectOfTheAcademicProgram> SubjectsAcademicPrograms { get; private set; } = new List<SubjectOfTheAcademicProgram>();
}
