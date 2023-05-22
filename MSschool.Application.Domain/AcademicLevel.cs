using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public partial class AcademicLevel: Audit
{
    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;

    public int SemesterQuantity { get; set; }

    public virtual ICollection<AcademicsProgram> AcademicsPrograms { get; set; } = new List<AcademicsProgram>();
}
