using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public partial class Subject: Audit
{
    public string Name { get; set; } = null!;

    public int Credit { get; set; }

    public int Semester { get; set; }

    public string? PreRequisite { get; set; }

    public string Modality { get; set; } = null!;

    public virtual ICollection<CourseNote> CourseNotes { get; set; } = new List<CourseNote>();

    public virtual ICollection<SubjectValue> SubjectValues { get; set; } = new List<SubjectValue>();

    public virtual ICollection<SubjectsAcademicProgram> SubjectsAcademicPrograms { get; set; } = new List<SubjectsAcademicProgram>();

    public virtual ICollection<UserAssignment> UserAssignments { get; set; } = new List<UserAssignment>();
}
