using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Subjects;
using MSschool.Application.Domain.Models.Users;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Application.Domain.Models.CourseNotes;

public partial class CourseNote : Audit
{
    public CourseNote(
        Id id, 
        decimal percentages, 
        decimal noteValue, 
        DateTime noteDate,
        string observation,
        Id idUser,
        Id idTeacher,
        Id idSubject) : base(id)
    {
        Percentages = percentages;
        NoteValue = noteValue;
        NoteDate = noteDate;
        Observation = observation;
        IdUser = idUser;
        IdTeacher = idTeacher;
        IdSubject = idSubject;
    }

    public decimal Percentages { get; private set; }

    public decimal NoteValue { get; private set; }

    public DateTime NoteDate { get; private set; }

    public string? Observation { get; private set; }

    public Id? IdUser { get; private set; }

    public Id? IdTeacher { get; private set; }

    public Id? IdSubject { get; private set; }

    public virtual Subject IdSubjectNavigation { get; private set; } = null!;

    public virtual User IdTeacherNavigation { get; private set; } = null!;

    public virtual User IdUserNavigation { get; private set; } = null!;
}
