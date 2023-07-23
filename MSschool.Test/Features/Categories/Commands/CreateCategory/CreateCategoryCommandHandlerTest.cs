using Microsoft.Extensions.Logging;
using Moq;
using MSschool.Application.Constants;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Features.Categories.Commands.CreateCategory;
using Xunit;

namespace MSschool.Test.Features.Categories.Commands.CreateCategory;

public class CreateCategoryCommandHandlerTest
{
    private const string Id = "6717be28-4b35-48e8-8654-466ab8809b1d";

    Mock<IUnitOfWork>? _unitOfWork;
    Mock<ILogger<CreateCategoryCommandHandler>>? _logger;

    CreateCategoryCommandHandler? handle;

    private void InitializeDependencies()
    {
        _unitOfWork = new Mock<IUnitOfWork>();
        _logger = new Mock<ILogger<CreateCategoryCommandHandler>>();
        handle = new(_unitOfWork.Object, _logger.Object);
    }

    [Fact()]
    public async void Deberia_crear_una_categoria_exitosamente()
    {
        InitializeDependencies();

        var command = new CreateCategoryCommand("TestCategory", "TestDescription");

        var category = new Category(
            new Id(Guid.Parse(Id)),
            "Docente",
            "Description");

        var existCategoryResult = false;
        _unitOfWork!
            .Setup(s => s
                .Repository<Category>()
                .Exitst(e => e.Name.Equals(new Name(It.IsAny<string>()))))
            .ReturnsAsync(existCategoryResult);

        _unitOfWork!.Setup(s => s.Repository<Category>().AddAsync(It.IsAny<Category>()))
            .Returns(Task.FromResult(category));

        _unitOfWork.Setup(s => s.SaveChangesAsync()).ReturnsAsync((int)UnitOfWorkSaveChangesEnum.Saved);

        var result = await handle!.Handle(command, new CancellationToken());
        Assert.NotNull(result!);
        Assert.NotEqual(Guid.Empty, result.Value);
    }
}