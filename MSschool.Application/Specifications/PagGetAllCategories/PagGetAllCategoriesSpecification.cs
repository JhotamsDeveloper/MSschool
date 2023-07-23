using MSschool.Application.Constants;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Domain.Specifications;

namespace MSschool.Application.Specifications.PagGetAllCategories;

public sealed class PagGetAllCategoriesSpecification : BaseSpecification<Category>
{
    public PagGetAllCategoriesSpecification(PagGetAllCategoriesSettingsParams settings) :
        base(bs => string.IsNullOrEmpty(settings.Search) || bs.Name!.Contains(settings.Search))
    {
        ApplyPaging(settings.PageSize * (settings.PageIndex - 1), settings.PageSize);

        if (!string.IsNullOrEmpty(settings.Sort))
        {
            switch (settings.Sort)
            {
                case CategoryOrdering.nameAsc:
                    AddOrderBy(x => x.Name);
                    break;

                case CategoryOrdering.nameDesc:
                    AddOrderByDesc(x => x.Name);
                    break;

                case CategoryOrdering.idAsc:
                    AddOrderBy(x => x.Id);
                    break;

                case CategoryOrdering.idDesc:
                    AddOrderByDesc(x => x.Id);
                    break;

                default:
                    AddOrderBy(x => x.Name);
                    break;
            }
        }

        AddIgnoreQueryFilters(settings.DisableGlobalFilters);
    }
}
