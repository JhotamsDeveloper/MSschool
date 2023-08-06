using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicsProgram;
using MSschool.Application.Domain.Models.Users;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Application.Domain.Models.AcademicProgramUsers;

public class AcademicProgramUser : Audit
{
    public AcademicProgramUser(Id id, Id idUser, Id idAcademicProgram) : 
        base(id)
    {
        IdUser= idUser;
        IdAcademicProgram= idAcademicProgram;
    }

    public Id? IdUser { get; private set; }

    public Id? IdAcademicProgram { get; private set; }

    public virtual AcademicProgram? IdAcademicProgramNavigation { get; private set; }

    public virtual User? IdUserNavigation { get; private set; }
}
