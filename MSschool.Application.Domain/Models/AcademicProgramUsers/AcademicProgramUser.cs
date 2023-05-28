using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicsProgram;
using MSschool.Application.Domain.Models.Users;

namespace MSschool.Application.Domain.Models.AcademicProgramUsers;

public class AcademicProgramUser : Audit
{
    public AcademicProgramUser(Id id, Id createdByIdUser) : base(id, createdByIdUser)
    {
    }

    public Id? IdUser { get; private set; }

    public Id? IdAcademicProgram { get; private set; }

    public virtual AcademicProgram? IdAcademicProgramNavigation { get; private set; }

    public virtual User? IdUserNavigation { get; private set; }
}
