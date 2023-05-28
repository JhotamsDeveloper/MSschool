using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Subjects;
using MSschool.Application.Domain.Models.Users;

namespace MSschool.Application.Domain.Models.CourseNotes;

public partial class CourseNote : Audit
{
    public CourseNote(Id id, Id createdByIdUser) : base(id, createdByIdUser)
    {
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
