using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.UserCategories;
using MSschool.Application.Domain.ValuesObjects;

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

    private Category(Id id) : base(id)
    {
        
    }

    public string? Name { get; private set; }

    public string? Description { get; private set; }

    public virtual ICollection<UserCategory> UserCategories { get; private set; } = new List<UserCategory>();

    public static class Factory
    {
        public static Category Update(
            Id id, 
            Name name, 
            string description, 
            Availability? availability, 
            CreatedDate? createdDate)
        {
            var category = new Category(id)
            {
                Name = name.Value,
                Description = description
            };
            category.SetAvailability(availability);
            category.SetCreatedDate(createdDate);
            return category;
        }
    }
}
