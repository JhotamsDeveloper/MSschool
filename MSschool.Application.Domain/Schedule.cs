using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public partial class Schedule: Audit
{
    public Guid? IdAcademicProgram { get; set; }

    public string Weekday { get; set; } = null!;

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public virtual AcademicsProgram? IdAcademicProgramNavigation { get; set; }
}
