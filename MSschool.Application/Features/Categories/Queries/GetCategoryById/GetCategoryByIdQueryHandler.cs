using MSschool.Application.Common;
using MSschool.Application.Models.Category;

namespace MSschool.Application.Features.Categories.Queries.GetCategoryById;

internal class GetCategoryByIdQueryHandler : IQueryHandler<GetCategoryByIdQuery, DtoCategory>
{
    public async Task<DtoCategory> Handle(GetCategoryByIdQuery query, CancellationToken cancellation)
    {
        await Task.CompletedTask;
        return new DtoCategory() { 
            Id= query.Id,
            Name= "Jhonatan"
        };
    }
}
