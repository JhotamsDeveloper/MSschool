using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace MSschool.Presentation.Endpoints.Endpoints.Category;

public class CategoryEndpointsConfiguration : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var category = app.MapGroup("/category");

        AddCategory.Endpoint(category);
        UpdateCategory.Endpoint(category);
        AllActive.Endpoint(category);
        AllIncludingInactive.Endpoint(category);
        GetActiveCategoryById.Endpoind(category);
    }
}
