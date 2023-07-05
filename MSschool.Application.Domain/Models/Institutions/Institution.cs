using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicsProgram;

namespace MSschool.Application.Domain.Models.Institutions;

public partial class Institution : Audit
{
    public Institution(
        Id id, 
        Name? name, 
        string email, 
        string department, 
        string departmentCode, 
        string city, 
        string cityCode, 
        string address) : base(id)
    {
        Name = name;
        Email = email;
        Department = department;
        DepartmentCode = departmentCode;
        City = city;
        CityCode = cityCode;
        Address = address;
    }

    public Name? Name { get; private set; }

    public string Email { get; private set; } = null!;

    public string Department { get; private set; } = null!;

    public string DepartmentCode { get; private set; } = null!;

    public string City { get; private set; } = null!;

    public string CityCode { get; private set; } = null!;

    public string Address { get; private set; } = null!;

    public virtual ICollection<AcademicProgram> AcademicsPrograms { get; private set; } = new List<AcademicProgram>();
}
