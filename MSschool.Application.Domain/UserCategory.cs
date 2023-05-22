using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public partial class UserCategory : Audit
{
    public Guid? IdCategory { get; set; }

    public Guid? IdUser { get; set; }

    public virtual Category? IdCategoryNavigation { get; set; }

    public virtual User? IdUserNavigation { get; set; }
}
