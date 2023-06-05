using MSschool.Application.Abstracions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Models.Categories;

namespace MSschool.Application.Features.Categories.Queries.GetAllCategories;

internal sealed class GetAllCategoriesQueryHandler : 
    IQueryHandler<GetAllCategoriesQuery, IReadOnlyList<GetAllCategoriesResponse>>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetAllCategoriesQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IReadOnlyList<GetAllCategoriesResponse>> Handle(
        GetAllCategoriesQuery request, 
        CancellationToken cancellationToken)
    {
        var getAll = await _unitOfWork
            .Repository<Category>()
            .GetAllAsync(request.DisableGlobalFilters);

        var result = getAll
            .Select(Categories())
            .ToList();
        return result;
    }

    private static Func<Category, GetAllCategoriesResponse> Categories() =>
        cat => new GetAllCategoriesResponse(
            cat.Id!.Value,
            cat.Name.Value,
            cat.Description);
}
