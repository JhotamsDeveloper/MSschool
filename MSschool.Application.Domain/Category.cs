using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain;

public class Category: Audit
{
    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<UserCategory> UserCategories { get; set; } = new List<UserCategory>();
}
