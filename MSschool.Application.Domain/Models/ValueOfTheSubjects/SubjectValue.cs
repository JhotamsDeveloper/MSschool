using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Subjects;

namespace MSschool.Application.Domain.Models.ValueOfTheSubjects;

public partial class SubjectValue : Audit
{
    public SubjectValue(Id id, Id createdByIdUser) : base(id, createdByIdUser)
    {
    }

    public string Year { get; private set; } = null!;

    public double Value { get; private set; }

    public int? Iva { get; private set; }

    public Id? IdSubject { get; private set; }

    public virtual Subject IdSubjectNavigation { get; private set; } = null!;
}
