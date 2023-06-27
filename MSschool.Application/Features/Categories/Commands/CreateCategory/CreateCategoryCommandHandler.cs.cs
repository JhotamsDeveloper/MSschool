using Microsoft.Extensions.Logging;
using MSschool.Application.Abstractions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Exceptions;

namespace MSschool.Application.Features.Categories.Commands.CreateCategory;

public class CreateCategoryCommandHandler : ICommandHandler<CreateCategoryCommand, Id>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<CreateCategoryCommandHandler> _logger;

    public CreateCategoryCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateCategoryCommandHandler> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<Id> Handle(
        CreateCategoryCommand request,
        CancellationToken cancellationToken)
    {
        var existCategory = await _unitOfWork
            .Repository<Category>()
            .Exitst(e => e.Name!.Equals(new Name(request.Name)));

        if (existCategory)
        {
            _logger.LogWarning("La {@category}, {@request} ya existe", nameof(Category), request);
            throw new BadRequestException($"La {nameof(Category)} ya existe");
        }

        var category = new Category(
            new Id(Guid.NewGuid()),
            new Name(request.Name),
            request.Description,
            new Id(Guid.Empty));

        await _unitOfWork
            .Repository<Category>()
            .AddAsync(category);

        return category.Id!;
    }
}
