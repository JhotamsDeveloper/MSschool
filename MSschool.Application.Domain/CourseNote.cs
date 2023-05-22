using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public partial class CourseNote: Audit
{
    public decimal Percentages { get; set; }

    public decimal NoteValue { get; set; }

    public DateTime NoteDate { get; set; }

    public string? Observation { get; set; }

    public Guid IdUser { get; set; }

    public Guid IdTeacher { get; set; }

    public Guid IdSubject { get; set; }

    public virtual Subject IdSubjectNavigation { get; set; } = null!;

    public virtual User IdTeacherNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
