using Carter;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSschool.Presentation.Endpoints.Endpoints.User;

public class EndpointsConfigurationUser : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        var user = app.MapGroup("/user");
        AddUser.Endpoint(user);
        AddUserPlaceOfBirth.Endpoint(user);
    }
}
