using MSschool.Application.Abstractions;
using MSschool.Application.Domain.ValuesObjects;

namespace MSschool.Application.Features.Categories.Commands.CreateCategory;

public record CreateCategoryCommand(
    string Name,
    string Description) : ICommand<Id>;