using MSschool.Application.Abstractions;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Application.Features.Categories.Commands.UpdateCategory;

public record UpdateCategoryCommand(
    Guid Id,
    string Name,
    string Description) : ICommand<Id>;
