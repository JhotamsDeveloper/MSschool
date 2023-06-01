using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Subjects;

namespace MSschool.Application.Domain.Models.ValueOfTheSubjects;

public partial class SubjectValue : Audit
{
    public SubjectValue(
        Id id, 
        string year, 
        double value, 
        int? iva, 
        Id? idSubject,
        Id createdByIdUser) : base(id, createdByIdUser)
    {
        Year = year;
        Value = value;
        Iva = iva;
        IdSubject = idSubject;
    }

    public string Year { get; private set; } = null!;

    public double Value { get; private set; }

    public int? Iva { get; private set; }

    public Id? IdSubject { get; private set; }

    public virtual Subject IdSubjectNavigation { get; private set; } = null!;
}
