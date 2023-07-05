using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.UserCategories;

namespace MSschool.Application.Domain.Models.Categories;

public class Category : Audit
{
    public Category(
        Id id,
        string name,
        string description) : base(id)
    {
        Name = name;
        Description = description;
    }

    private Category(Id id, Availability availability) : base(id) { }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public virtual ICollection<UserCategory> UserCategories { get; private set; } = new List<UserCategory>();

    public static class Factory
    {
        public static Category Update(Category entity)
        {
            return entity;
        }
    }
}
