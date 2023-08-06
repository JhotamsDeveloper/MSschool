using MSschool.Application.Abstractions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Domain.ValuesObjects;
using MSschool.Application.Exceptions;

namespace MSschool.Application.Features.Categories.Commands.UpdateCategory;

public class UpdateCategoryCommandHandler : ICommandHandler<UpdateCategoryCommand, Id>
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
            throw new BadRequestEx(
                "La categoria que intenta actualizar no existe");

        category = Category.Factory
            .Update(new Id(request.Id), new Name(request.Name), request.Description, category.Availability, category.CreatedDate);

        await _unitOfWork.Repository<Category>().UpdateAsync(category);

        return category.Id!;
    }
}
