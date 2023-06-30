using MSschool.Application.Abstractions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Models.Categories;

namespace MSschool.Application.Features.Categories.Queries.GetActiveCategoryById;

public sealed class GetActiveCategoryByIdQueryHandler : IQueryHandler<GetActiveCategoryByIdQuery, GetActiveCategoryByIdResponse>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetActiveCategoryByIdQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<GetActiveCategoryByIdResponse> Handle(GetActiveCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var category = await _unitOfWork.Repository<Category>().GetByIdAsync(request.Id);
        var result = new GetActiveCategoryByIdResponse(
            (Guid)category.Id!.Value!,
            category.Name,
            category.Description);

        return result;
    }
}
