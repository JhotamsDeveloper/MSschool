using MSschool.Application.Abstractions;

namespace MSschool.Application.Features.Categories.Queries.GetCategoryById;

public record class GetCategoryByIdQuery(Guid Id, bool IgnoreQueryFilters) : IQuery<GetCategoryByIdResponse>;
