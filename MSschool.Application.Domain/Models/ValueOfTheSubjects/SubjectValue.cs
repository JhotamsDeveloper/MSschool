﻿using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Subjects;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Application.Domain.Models.ValueOfTheSubjects;

public partial class SubjectValue : Audit
{
    public SubjectValue(
        Id id, 
        string year, 
        double value, 
        int? iva, 
        Id? idSubject) : base(id)
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
