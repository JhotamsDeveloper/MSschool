using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicProgramUsers;
using MSschool.Application.Domain.Models.AcademicsProgram;
using MSschool.Application.Domain.Models.CourseNotes;
using MSschool.Application.Domain.Models.UserAssignments;
using MSschool.Application.Domain.Models.UserCategories;

namespace MSschool.Application.Domain.Models.Users;

public partial class User : Audit
{
    public User(Id id, Id createdByIdUser) : base(id, createdByIdUser)
    {
    }

    public string FirstName { get; private set; } = null!;

    public string? SecondName { get; private set; }

    public string Surname { get; private set; } = null!;

    public string? SecondSurname { get; private set; }

    public string DocumentType { get; private set; } = null!;

    public string DocumentNumber { get; private set; } = null!;

    public string Email { get; private set; } = null!;

    public string? Phone { get; private set; }

    public DateTime? Birthdate { get; private set; }

    public string? CellPhone { get; private set; }

    public string? IndicativeCountryOfBirth { get; private set; }

    public string? CountryOfBirth { get; private set; }

    public string? DepartmentOfBirth { get; private set; }

    public string? CityOfBirth { get; private set; }

    public string? IndicativeCountryOfDomicile { get; private set; }

    public string? CountryOfDomicile { get; private set; }

    public string? DepartmentOdDomicile { get; private set; }

    public string? CityOfDomicile { get; private set; }

    public string? AddressOfDomicile { get; private set; }

    public virtual ICollection<AcademicProgramUser> AcademicProgramUsers { get; private set; } = new List<AcademicProgramUser>();

    public virtual ICollection<AcademicProgram> AcademicsPrograms { get; private set; } = new List<AcademicProgram>();

    public virtual ICollection<CourseNote> CourseNoteIdTeacherNavigations { get; private set; } = new List<CourseNote>();

    public virtual ICollection<CourseNote> CourseNoteIdUserNavigations { get; private set; } = new List<CourseNote>();

    public virtual ICollection<UserAssignment> UserAssignments { get; private set; } = new List<UserAssignment>();

    public virtual ICollection<UserCategory> UserCategories { get; private set; } = new List<UserCategory>();
}
