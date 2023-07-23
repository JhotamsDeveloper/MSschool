using Microsoft.Extensions.Logging;
using MSschool.Application.Abstractions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Exceptions;
using MSschool.Application.Specifications.GetCategory;

namespace MSschool.Application.Features.Categories.Queries.GetCategoryById;

public sealed class GetCategoryByIdQueryHandler : IQueryHandler<GetCategoryByIdQuery, GetCategoryByIdResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<GetCategoryByIdQueryHandler> _logger;

    public GetCategoryByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetCategoryByIdQueryHandler> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<GetCategoryByIdResponse> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
    {

        var settings = new GetCategorySettingsParams(
            request.IgnoreQueryFilters, 
            request.Id);

        var spec = new GetCategorySpec(settings);

        var category = await _unitOfWork
            .Repository<Category>()
            .GetIdWithSpec(spec) ??
            throw new Exception(
                "La categoría que intenta buscar esta inactiva o no existe.");

        var result = new GetCategoryByIdResponse(
            category.Id!.Value!,
            category.Name,
            category.Description);

        return result;
    }
}
