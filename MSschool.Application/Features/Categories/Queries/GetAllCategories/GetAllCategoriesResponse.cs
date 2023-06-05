namespace MSschool.Application.Features.Categories.Queries.GetAllCategories;

public record class GetAllCategoriesResponse(
    Guid Id, 
    string Name, 
    string Description);
