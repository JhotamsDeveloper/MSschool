using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Domain.Shared.Specifications;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Application.Specifications.GetCategory;

internal class GetCategorySpec : BaseSpecification<Category>
{
    public GetCategorySpec(GetCategorySettingsParams settings) :
        base(bs => bs.Id == new Id(settings.Id))
    {
        AddIgnoreQueryFilters(settings.DisableGlobalFilters);
    }
}
