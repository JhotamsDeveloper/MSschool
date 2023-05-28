using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.UserCategories;

namespace MSschool.Application.Domain.Models.Categories;

public class Category : Audit
{
    public Category(
        Id id,
        Name name,
        string description,
        Id createdByIdUser) : base(id, createdByIdUser)
    {
        Name = name;
        Description = description;
    }

    public Name? Name { get; private set; }

    public string? Description { get; private set; }

    public virtual ICollection<UserCategory> UserCategories { get; private set; } = new List<UserCategory>();
}
