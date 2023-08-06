using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Domain.Models.Users;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Application.Domain.Models.UserCategories;

public partial class UserCategory : Audit
{
    public UserCategory(
        Id id, 
        Id? idCategory, 
        Id? idUser) : base(id)
    {
        IdCategory = idCategory;
        IdUser = idUser;
    }

    public Id? IdCategory { get; private set; }

    public Id? IdUser { get; private set; }

    public virtual Category? IdCategoryNavigation { get; private set; }

    public virtual User? IdUserNavigation { get; private set; }
}
