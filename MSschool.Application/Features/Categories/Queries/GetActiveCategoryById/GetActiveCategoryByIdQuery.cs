using MSschool.Application.Abstractions;

namespace MSschool.Application.Features.Categories.Queries.GetActiveCategoryById;

public record class GetActiveCategoryByIdQuery(Guid Id) : IQuery<GetActiveCategoryByIdResponse>;
