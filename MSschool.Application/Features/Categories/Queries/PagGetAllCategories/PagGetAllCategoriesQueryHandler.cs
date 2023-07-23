using MSschool.Application.Abstractions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Domain.Shared.Pagination;
using MSschool.Application.Specifications.PagGetAllCategories;

namespace MSschool.Application.Features.Categories.Queries.PagGetAllCategories;

public sealed class PagGetAllCategoriesQueryHandler :
    ICommandHandler<PagGetAllCategoriesQuery, PaginationResponse<PagGetAllCategoriesResponse>>
{
    private readonly IUnitOfWork _unitOfWork;

    public PagGetAllCategoriesQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<PaginationResponse<PagGetAllCategoriesResponse>> Handle(
        PagGetAllCategoriesQuery request, CancellationToken cancellationToken)
    {
        var settingsParams = new PagGetAllCategoriesSettingsParams()
        {
            PageIndex = request.PageIndex,
            PageSize = request.PageSize,
            Search = request.Search,
            Sort = request.Sort,
            DisableGlobalFilters = request.DisableGlobalFilters
        };

        var getAllWithSpec = new PagGetAllCategoriesSpecification(settingsParams);
        var categories = await _unitOfWork
            .Repository<Category>()
            .GetAllWithSpec(getAllWithSpec);

        var countSpec = new PagGetAllCategoriesCounterSpec(settingsParams);
        var totalCategories = await _unitOfWork
            .Repository<Category>()
            .CountAsync(countSpec);

        var rounded = Math
            .Ceiling(Convert.ToDecimal(totalCategories) / Convert.ToDecimal(request.PageSize));
        var totalPages = Convert.ToInt32(rounded);

        var data = categories.Select(category =>
        new PagGetAllCategoriesResponse(
            category!.Id.Value,
            category!.Name!,
            category!.Description!))
            .ToList();

        var result = new PaginationResponse<PagGetAllCategoriesResponse>()
        {
            Count = totalCategories,
            Data = data,
            PageCount = totalPages,
            PageIndex = request.PageIndex,
            PageSize = request.PageSize
        };

        return result;
    }
}
