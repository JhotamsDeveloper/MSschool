using MSschool.Application.Abstractions;
using MSschool.Application.Domain.Common;

namespace MSschool.Application.Features.Categories.Commands.DeleteCategory;

public record DeleteCategoryCommand(Guid Id) : ICommand<Id>;
