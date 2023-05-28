using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.AcademicsProgram;

namespace MSschool.Application.Domain.Models.Institutions;

public partial class Institution : Audit
{
    public Institution(Id id, Id createdByIdUser) : base(id, createdByIdUser)
    {
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
