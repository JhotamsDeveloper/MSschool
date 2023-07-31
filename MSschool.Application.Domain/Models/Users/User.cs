using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicProgramUsers;
using MSschool.Application.Domain.Models.AcademicsProgram;
using MSschool.Application.Domain.Models.CourseNotes;
using MSschool.Application.Domain.Models.UserAssignments;
using MSschool.Application.Domain.Models.UserCategories;

namespace MSschool.Application.Domain.Models.Users;

public partial class User : Audit
{
    public User(
        Id id,
        string firstName,
        string? secondName,
        string surname,
        string? secondSurname,
        string documentType,
        string documentNumber,
        string email,
        string? phone,
        DateTime? birthdate,
        string? cellPhone) : base(id)
    {
        FirstName = firstName;
        SecondName = secondName;
        Surname = surname;
        SecondSurname = secondSurname;
        DocumentType = documentType;
        DocumentNumber = documentNumber;
        Email = email;
        Phone = phone;
        Birthdate = birthdate;
        CellPhone = cellPhone;
    }

    private User(Id id) : base(id)
    {

    }

    public string FirstName { get; private set; } = string.Empty;

    public string? SecondName { get; private set; }

    public string Surname { get; private set; } = string.Empty;

    public string? SecondSurname { get; private set; }

    public string DocumentType { get; private set; } = string.Empty;

    public string DocumentNumber { get; private set; } = string.Empty;

    public string Email { get; private set; } = string.Empty;

    public string? Phone { get; private set; }

    public DateTime? Birthdate { get; private set; }

    public string? CellPhone { get; private set; }

    public Address? AddressOfBirth { get; private set; } = new();

    public Address? AddressCurrent { get; private set; } = new();

    public virtual ICollection<AcademicProgramUser> AcademicProgramUsers { get; private set; } = new List<AcademicProgramUser>();

    public virtual ICollection<AcademicProgram> AcademicsPrograms { get; private set; } = new List<AcademicProgram>();

    public virtual ICollection<CourseNote> CourseNoteIdTeacherNavigations { get; private set; } = new List<CourseNote>();

    public virtual ICollection<CourseNote> CourseNoteIdUserNavigations { get; private set; } = new List<CourseNote>();

    public virtual ICollection<UserAssignment> UserAssignments { get; private set; } = new List<UserAssignment>();

    public virtual ICollection<UserCategory> UserCategories { get; private set; } = new List<UserCategory>();

    public static class Factory
    {
        public static User AddPlaceOfBirth(
            Id id,
            string firstName,
            string? secondName,
            string surname,
            string? secondSurname,
            string documentType,
            string documentNumber,
            string email,
            string? phone,
            DateTime? birthdate,
            string? cellPhone,
            string country,
            string countryCode,
            string department,
            string departmentCode,
            string city,
            string cityCode,
            string direction,
            Availability? availability,
            CreatedDate? createdDate)
        {
            var user = new User(id)
            {
                FirstName = firstName,
                SecondName = secondName,
                Surname = surname,
                SecondSurname = secondSurname,
                DocumentType = documentType,
                DocumentNumber = documentNumber,
                Email = email,
                Phone = phone,
                Birthdate = birthdate,
                CellPhone = cellPhone,
                AddressOfBirth = new Address(country, countryCode, department, departmentCode, city, cityCode, direction),
            };
            user.SetAvailability(availability);
            user.SetCreatedDate(createdDate);
            return user;
        }
    }
}
