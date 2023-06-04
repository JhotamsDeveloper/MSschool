using MSschool.Application.Abstracions;
using MSschool.Application.Constants;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;

namespace MSschool.Application.Features.Categories.Commands.CreateCategory;

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
        var existCategory = await _unitOfWork
            .Repository<Category>()
            .Exitst(e => e.Name!.Equals(new Name(request.Name)));

        if (existCategory)
            throw new Exception(
                "La categoria que esta intando registrar ya existe");

        var category = new Category(
            new Id(Guid.NewGuid()),
            new Name(request.Name),
            request.Description,
            new Id(Guid.Empty));

        await _unitOfWork
            .Repository<Category>()
            .AddAsync(category);

        var result = await _unitOfWork.SaveChangesAsync();

        if (result.Equals(UnitOfWorkSaveChangesEnum.Failed))
            throw new Exception(
                "Error al guardar la categoria");

        return category.Id!;
    }
}
