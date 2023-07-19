using MSschool.Application.Abstractions;
using MSschool.Application.Constants;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;

namespace MSschool.Application.Features.Categories.Commands.UpdateCategory;

internal class UpdateCategoryCommandHandler : ICommandHandler<UpdateCategoryCommand, Id>
{
    private readonly IUnitOfWork _unitOfWork;

    public UpdateCategoryCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Id> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await _unitOfWork
            .Repository<Category>()
            .GetByIdAsync(request.Id) ??
            throw new Exception(
                "La categoria que intenta actualizar no existe");

        category = Category.Factory
            .Update(new Id(request.Id), new Name(request.Name),request.Description,category.Availability,category.CreatedDate);

        await _unitOfWork.Repository<Category>().UpdateAsync(category);

        return category.Id!;
    }
}
