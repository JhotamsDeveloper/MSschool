using MSschool.Application.Abstractions;

namespace MSschool.Application.Features.Categories.Queries.GetActiveCategory;

public record GetActiveCategoryQuery(Guid Id) : IQuery<GetActiveCategoryResponse>;
