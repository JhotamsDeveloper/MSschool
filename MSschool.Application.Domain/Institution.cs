using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public partial class Institution: Audit
{
    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string DepartmentCode { get; set; } = null!;

    public string City { get; set; } = null!;

    public string CityCode { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<AcademicsProgram> AcademicsPrograms { get; set; } = new List<AcademicsProgram>();
}
