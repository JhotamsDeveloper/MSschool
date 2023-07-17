using Microsoft.Extensions.Logging;
using MSschool.Application.Abstractions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Exceptions;

namespace MSschool.Application.Features.Categories.Queries.GetActiveCategoryById;

public sealed class GetActiveCategoryByIdQueryHandler : IQueryHandler<GetActiveCategoryByIdQuery, GetActiveCategoryByIdResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<GetActiveCategoryByIdQueryHandler> _logger;

    public GetActiveCategoryByIdQueryHandler(IUnitOfWork unitOfWork, ILogger<GetActiveCategoryByIdQueryHandler> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<GetActiveCategoryByIdResponse> Handle(GetActiveCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var category = await _unitOfWork
            .Repository<Category>()
            .GetByIdAsync(request.Id);

        if (category is null)
        {
            throw new BadRequestEx($"El id {request.Id} no existe");
        }

        var result = new GetActiveCategoryByIdResponse(
            (Guid)category.Id!.Value!,
            category.Name,
            category.Description);

        return result;
    }
}
