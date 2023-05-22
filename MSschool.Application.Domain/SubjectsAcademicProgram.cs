using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public partial class SubjectsAcademicProgram: Audit
{
    public Guid IdSubject { get; set; }

    public Guid IdAcademicProgram { get; set; }

    public virtual AcademicsProgram IdAcademicProgramNavigation { get; set; } = null!;

    public virtual Subject IdSubjectNavigation { get; set; } = null!;
}
