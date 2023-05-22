using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public partial class UserAssignment: Audit
{
    public Guid? IdUser { get; set; }

    public Guid? IdSubject { get; set; }

    public string? SubjectStatus { get; set; }

    public virtual Subject? IdSubjectNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
