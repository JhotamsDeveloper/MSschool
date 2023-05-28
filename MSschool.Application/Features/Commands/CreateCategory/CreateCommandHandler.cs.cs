using MediatR;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;
using System.ComponentModel.DataAnnotations;

namespace MSschool.Application.Features.Commands.CreateCategory;

internal class CreateCommandHandler : IRequestHandler<CreateCommand,Id>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Id> Handle(CreateCommand request, CancellationToken cancellationToken)
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
