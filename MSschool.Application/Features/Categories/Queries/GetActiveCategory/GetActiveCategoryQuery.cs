using MSschool.Application.Abstracions;
using MSschool.Application.Domain.Common;

namespace MSschool.Application.Features.Categories.Queries.GetActiveCategory;

public record GetActiveCategoryQuery(Guid Id) : IQuery<GetActiveCategoryResponse>;
