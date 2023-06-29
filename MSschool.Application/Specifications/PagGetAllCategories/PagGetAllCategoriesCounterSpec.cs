using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Domain.Specifications;

namespace MSschool.Application.Specifications.PagGetAllCategories;

public class PagGetAllCategoriesCounterSpec : BaseSpecification<Category>
{
    public PagGetAllCategoriesCounterSpec(PagGetAllCategoriesSettingsParams settings) :
        base(bs => string.IsNullOrEmpty(settings.Search) || bs.Name.Value.Contains(settings.Search))
    {
        
    }
}
