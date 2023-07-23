using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Domain.Specifications;

namespace MSschool.Application.Specifications.GetCategory;

internal class GetCategorySpec : BaseSpecification<Category>
{
    public GetCategorySpec(GetCategorySettingsParams settings) :
        base(bs => bs.Id == new Id(settings.Id))
    {
        AddIgnoreQueryFilters(settings.DisableGlobalFilters);
    }
}
