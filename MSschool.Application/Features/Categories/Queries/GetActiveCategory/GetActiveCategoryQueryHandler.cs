using MSschool.Application.Abstracions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Models.Categories;

namespace MSschool.Application.Features.Categories.Queries.GetActiveCategory;

internal sealed class GetActiveCategoryQueryHandler : IQueryHandler<GetActiveCategoryQuery, GetActiveCategoryResponse>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetActiveCategoryQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<GetActiveCategoryResponse> Handle(GetActiveCategoryQuery request, CancellationToken cancellationToken)
    {
        var category = await _unitOfWork.Repository<Category>().GetByIdAsync(request.Id);
        var result = new GetActiveCategoryResponse(
            (Guid)category.Id!.Value!, 
            category.Name.Value, 
            category.Description);

        return result;
    }
}
