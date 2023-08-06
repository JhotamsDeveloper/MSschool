using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.CourseNotes;
using MSschool.Application.Domain.Models.SubjectsAcademicProgram;
using MSschool.Application.Domain.Models.UserAssignments;
using MSschool.Application.Domain.Models.ValueOfTheSubjects;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Application.Domain.Models.Subjects;

public partial class Subject : Audit
{
    public Subject(
        Id id, 
        Name? name, 
        int credit, 
        int semester, 
        string? preRequisite, 
        string modality) : base(id)
    {
        Name = name;
        Credit = credit;
        Semester = semester;
        PreRequisite = preRequisite;
        Modality = modality;
    }

    public Name? Name { get; private set; }

    public int Credit { get; private set; }

    public int Semester { get; private set; }

    public string? PreRequisite { get; private set; }

    public string Modality { get; private set; } = null!;

    public virtual ICollection<CourseNote> CourseNotes { get; private set; } = new List<CourseNote>();

    public virtual ICollection<SubjectValue> SubjectValues { get; private set; } = new List<SubjectValue>();

    public virtual ICollection<SubjectOfTheAcademicProgram> SubjectsAcademicPrograms { get; private set; } = new List<SubjectOfTheAcademicProgram>();

    public virtual ICollection<UserAssignment> UserAssignments { get; private set; } = new List<UserAssignment>();
}
