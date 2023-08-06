using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Subjects;
using MSschool.Application.Domain.Models.Users;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Application.Domain.Models.UserAssignments;

public partial class UserAssignment : Audit
{
    public UserAssignment(
        Id id, 
        Id? idUser, 
        Id? idSubject, 
        string? subjectStatus) : base(id)
    {
        IdUser = idUser;
        IdSubject = idSubject;
        SubjectStatus = subjectStatus;
    }

    public Id? IdUser { get; private set; }

    public Id? IdSubject { get; private set; }

    public string? SubjectStatus { get; private set; }

    public virtual Subject? IdSubjectNavigation { get; private set; }

    public virtual User? IdUserNavigation { get; private set; }
}
