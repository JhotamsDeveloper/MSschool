using MSschool.Application.Abstracions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Models.Categories;

namespace MSschool.Application.Features.Categories.Queries.GetAllActiveCategories;

internal sealed class GetAllActiveCategoriesQueryHandler : 
    IQueryHandler<GetAllActiveCategoriesQuery, IReadOnlyList<GetAllActiveCategoriesResponse>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllActiveCategoriesQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IReadOnlyList<GetAllActiveCategoriesResponse>> Handle(
        GetAllActiveCategoriesQuery request, 
        CancellationToken cancellationToken)
    {
        var getAll = await _unitOfWork
            .Repository<Category>()
            .GetAllAsync();

        var result = getAll
            .Select(Categories())
            .ToList();
        return result;
    }

    private static Func<Category, GetAllActiveCategoriesResponse> Categories() =>
        cat => new GetAllActiveCategoriesResponse(
            cat.Id!.Value,
            cat.Name.Value,
            cat.Description);
}
