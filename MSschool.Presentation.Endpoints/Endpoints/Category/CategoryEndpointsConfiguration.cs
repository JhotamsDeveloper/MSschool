using Carter;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using MSschool.Application.Features.Categories.Queries.PagGetAllCategories;
using MSschool.Application.Handlers;

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


    }
}
