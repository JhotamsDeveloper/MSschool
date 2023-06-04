using MSschool.Application.Abstracions;

namespace MSschool.Application.Features.Categories.Queries.GetAllActiveCategories;

public record class GetAllActiveCategoriesQuery() : 
    IQuery<IReadOnlyList<GetAllActiveCategoriesResponse>>;
