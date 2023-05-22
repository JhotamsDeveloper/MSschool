using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public partial class AcademicsProgram: Audit
{
    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public Guid IdAcademicLevel { get; set; }

    public Guid IdAcademicDirector { get; set; }

    public string ProgramStatus { get; set; } = null!;

    public string Modality { get; set; } = null!;

    public Guid IdInstitution { get; set; }

    public virtual ICollection<AcademicProgramUser> AcademicProgramUsers { get; set; } = new List<AcademicProgramUser>();

    public virtual User IdAcademicDirectorNavigation { get; set; } = null!;

    public virtual AcademicLevel IdAcademicLevelNavigation { get; set; } = null!;

    public virtual Institution IdInstitutionNavigation { get; set; } = null!;

    public virtual ICollection<Schedule> Schedules { get; set; } = new List<Schedule>();

    public virtual ICollection<SubjectsAcademicProgram> SubjectsAcademicPrograms { get; set; } = new List<SubjectsAcademicProgram>();
}
