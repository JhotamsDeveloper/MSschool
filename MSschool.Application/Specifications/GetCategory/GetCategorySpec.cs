using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Domain.Specifications;

namespace MSschool.Application.Specifications.GetCategory;

internal class GetCategorySpec : BaseSpecification<Category>
{
    public GetCategorySpec(GetCategorySettingsParams settings)
    {
        AddIgnoreQueryFilters(settings.DisableGlobalFilters);
    }
}
