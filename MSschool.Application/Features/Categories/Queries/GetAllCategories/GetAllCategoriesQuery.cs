using MSschool.Application.Abstracions;

namespace MSschool.Application.Features.Categories.Queries.GetAllCategories;

public record class GetAllCategoriesQuery(bool DisableGlobalFilters) : 
    IQuery<IReadOnlyList<GetAllCategoriesResponse>>;
