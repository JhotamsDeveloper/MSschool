using MSschool.Application.Abstracions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;

namespace MSschool.Application.Features.Commands.CreateCategory;

internal class CreateCategoryCommandHandler : ICommandHandler<CreateCategoryCommand, Id>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateCategoryCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Id> Handle(
        CreateCategoryCommand request, 
        CancellationToken cancellationToken)
    {
        var category = new Category(
            new Id(Guid.NewGuid()),
            request.Name,
            request.Description,
            new Id(request.DreatedByIdUser));

        await _unitOfWork.Repository<Category>().AddAsync(category);
        var result = await _unitOfWork.SaveChangesAsync();

        if (result.Equals(0))
            throw new Exception("Error al guardar la categoria");

        return category.Id;
    }
}
