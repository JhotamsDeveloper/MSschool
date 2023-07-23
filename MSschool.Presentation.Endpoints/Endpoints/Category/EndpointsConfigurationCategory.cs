using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace MSschool.Presentation.Endpoints.Endpoints.Category;

public class EndpointsConfigurationCategory : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var category = app.MapGroup("/category");

        AddCategory.Endpoint(category);
        UpdateCategory.Endpoint(category);
        AllActiveCategory.Endpoint(category);
        AllIncludingInactiveCategory.Endpoint(category);
        GetActiveByIdCategory.Endpoind(category);
        DeleteCategory.Endpoint(category);
        GetIncludingInactiveByIdCategory.Endpoind(category);
    }
}
