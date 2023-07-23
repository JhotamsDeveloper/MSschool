namespace MSschool.Application.Features.Categories.Queries.GetCategoryById;

public record class GetCategoryByIdResponse(Guid Id, string? Name, string? Description);
