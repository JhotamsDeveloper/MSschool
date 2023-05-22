using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public class AcademicProgramUser: Audit
{
    public Guid? IdUser { get; set; }

    public Guid? IdAcademicProgram { get; set; }

    public virtual AcademicsProgram? IdAcademicProgramNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
