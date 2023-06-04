using MSschool.Application.Abstracions;
using MSschool.Application.Domain.Common;

namespace MSschool.Application.Features.Categories.Commands.UpdateCategory;

public record UpdateCategoryCommand(
    Guid Id,
    string Name,
    string Description,
    Guid LastModifiedByIdUser) : ICommand<Id>;
