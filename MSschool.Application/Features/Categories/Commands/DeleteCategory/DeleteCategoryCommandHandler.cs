using MSschool.Application.Abstractions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Specifications.GetCategory;

namespace MSschool.Application.Features.Categories.Commands.DeleteCategory;

public sealed class DeleteCategoryCommandHandler : ICommandHandler<DeleteCategoryCommand, Id>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteCategoryCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Id> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
    {
        var settings = new GetCategorySettingsParams(true, request.Id);

        var spec = new GetCategorySpec(settings);

        var category = await _unitOfWork
            .Repository<Category>()
            .GetIdWithSpec(spec) ??
            throw new Exception(
                "La categoria que intenta eliminar no existe");

        await _unitOfWork.Repository<Category>().DeleteAsync(category);
        return category.Id;
    }
}
