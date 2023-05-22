using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public partial class SubjectValue: Audit
{
    public string Year { get; set; } = null!;

    public double Value { get; set; }

    public int? Iva { get; set; }

    public Guid IdSubject { get; set; }

    public virtual Subject IdSubjectNavigation { get; set; } = null!;
}
