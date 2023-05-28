using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicLevels;
using MSschool.Application.Domain.Models.AcademicProgramUsers;
using MSschool.Application.Domain.Models.Institutions;
using MSschool.Application.Domain.Models.Schedules;
using MSschool.Application.Domain.Models.SubjectsAcademicProgram;
using MSschool.Application.Domain.Models.Users;

namespace MSschool.Application.Domain.Models.AcademicsProgram;

public partial class AcademicProgram : Audit
{
    public AcademicProgram(Id id, Id createdByIdUser) : base(id, createdByIdUser)
    {
    }

    public string Name { get; private set; } = null!;

    public string Code { get; private set; } = null!;

    public string ProgramStatus { get; private set; } = null!;

    public string Modality { get; private set; } = null!;

    public Id? IdAcademicLevel { get; private set; }

    public Id? IdAcademicDirector { get; private set; }

    public Id? IdInstitution { get; private set; }

    public virtual ICollection<AcademicProgramUser> AcademicProgramUsers { get; private set; } = new List<AcademicProgramUser>();

    public virtual User IdAcademicDirectorNavigation { get; private set; } = null!;

    public virtual AcademicLevel IdAcademicLevelNavigation { get; private set; } = null!;

    public virtual Institution IdInstitutionNavigation { get; private set; } = null!;

    public virtual ICollection<Schedule> Schedules { get; private set; } = new List<Schedule>();

    public virtual ICollection<SubjectOfTheAcademicProgram> SubjectsAcademicPrograms { get; private set; } = new List<SubjectOfTheAcademicProgram>();
}
