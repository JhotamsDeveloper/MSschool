using MSschool.Application.Abstracions;
using MSschool.Application.Domain.Common;

namespace MSschool.Application.Features.Commands.CreateCategory;

public record CreateCategoryCommand(
    string Name,
    string Description,
    Guid CreatedByIdUser) : ICommand<Id>;