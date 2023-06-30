using MSschool.Application.Abstractions;
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
        IReadOnlyList<Category> getAllAsync;
        
        // Implementar un strategy
        if (!request.DisableGlobalFilters)
        {
            getAllAsync = await _unitOfWork
                .Repository<Category>()
                .GetAllAsync();
        }
        else
        {
            getAllAsync = await _unitOfWork
                .Repository<Category>()
                .GetAllIgnoreQueryFiltersAsync();
        }

        var result = getAllAsync
            .Select(Categories())
            .ToList();

        return result;
    }

    private static Func<Category, GetAllCategoriesResponse> Categories() =>
        cat => new GetAllCategoriesResponse(
            cat.Id!.Value,
            cat.Name,
            cat.Description);
}
