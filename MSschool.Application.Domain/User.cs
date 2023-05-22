using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public partial class User: Audit
{
    public string FirstName { get; set; } = null!;

    public string? SecondName { get; set; }

    public string Surname { get; set; } = null!;

    public string? SecondSurname { get; set; }

    public string DocumentType { get; set; } = null!;

    public string DocumentNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public DateTime? Birthdate { get; set; }

    public string? CellPhone { get; set; }

    public string? IndicativeCountryOfBirth { get; set; }

    public string? CountryOfBirth { get; set; }

    public string? DepartmentOfBirth { get; set; }

    public string? CityOfBirth { get; set; }

    public string? IndicativeCountryOfDomicile { get; set; }

    public string? CountryOfDomicile { get; set; }

    public string? DepartmentOdDomicile { get; set; }

    public string? CityOfDomicile { get; set; }

    public string? AddressOfDomicile { get; set; }

    public virtual ICollection<AcademicProgramUser> AcademicProgramUsers { get; set; } = new List<AcademicProgramUser>();

    public virtual ICollection<AcademicsProgram> AcademicsPrograms { get; set; } = new List<AcademicsProgram>();

    public virtual ICollection<CourseNote> CourseNoteIdTeacherNavigations { get; set; } = new List<CourseNote>();

    public virtual ICollection<CourseNote> CourseNoteIdUserNavigations { get; set; } = new List<CourseNote>();

    public virtual ICollection<UserAssignment> UserAssignments { get; set; } = new List<UserAssignment>();

    public virtual ICollection<UserCategory> UserCategories { get; set; } = new List<UserCategory>();
}
