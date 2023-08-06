using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Domain.Shared.Specifications;

namespace MSschool.Application.Specifications.PagGetAllCategories;

public class PagGetAllCategoriesCounterSpec : BaseSpecification<Category>
{
    public PagGetAllCategoriesCounterSpec(PagGetAllCategoriesSettingsParams settings) :
        base(bs => string.IsNullOrEmpty(settings.Search) || bs.Name!.Contains(settings.Search))
    {
        AddIgnoreQueryFilters(settings.DisableGlobalFilters);
    }
}
