using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Domain.Models.Users;

namespace MSschool.Application.Domain.Models.UserCategories;

public partial class UserCategory : Audit
{
    public UserCategory(Id id, Id createdByIdUser) : base(id, createdByIdUser)
    {
    }

    public Id? IdCategory { get; private set; }

    public Id? IdUser { get; private set; }

    public virtual Category? IdCategoryNavigation { get; private set; }

    public virtual User? IdUserNavigation { get; private set; }
}
