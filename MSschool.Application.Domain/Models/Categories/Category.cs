using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.UserCategories;

namespace MSschool.Application.Domain.Models.Categories;

public class Category : Audit
{
    public Category(
        Id id, 
        string name, 
        string description) : base (id)
    {
        Name = name;
        Description = description;
    }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public void Update(Id id, string name, string description, Availability availability)
    {
        Name = name;
        Description= description;
        Update(id, availability);
    }

    public virtual ICollection<UserCategory> UserCategories { get; private set; } = new List<UserCategory>();
}
