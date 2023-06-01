using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicsProgram;
using MSschool.Application.Domain.Models.Subjects;

namespace MSschool.Application.Domain.Models.SubjectsAcademicProgram;

public partial class SubjectOfTheAcademicProgram : Audit
{
    public SubjectOfTheAcademicProgram(
        Id id, 
        Id? idSubject, 
        Id? idAcademicProgram,
        Id createdByIdUser) : base(id, createdByIdUser)
    {
        IdSubject = idSubject;
        IdAcademicProgram = idAcademicProgram;
    }

    public Id? IdSubject { get; private set; }

    public Id? IdAcademicProgram { get; private set; }

    public virtual AcademicProgram IdAcademicProgramNavigation { get; private set; } = null!;

    public virtual Subject IdSubjectNavigation { get; private set; } = null!;
}
