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

        category.Update(
            new Id(request.Id),
            new Name(request.Name),
            request.Description,
            new Availability(true),
            new Id(request.LastModifiedByIdUser));

        await _unitOfWork.Repository<Category>().UpdateAsync(category);
        int saveChangesAsync = await _unitOfWork.SaveChangesAsync();

        if (saveChangesAsync.Equals((int)UnitOfWorkSaveChangesEnum.Failed))
            throw new Exception("Error al actualizar la categoria");

        return category.Id!;
    }
}
