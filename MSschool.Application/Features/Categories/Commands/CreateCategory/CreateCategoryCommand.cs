﻿using MSschool.Application.Abstractions;
using MSschool.Application.Domain.Common;

namespace MSschool.Application.Features.Categories.Commands.CreateCategory;

public record CreateCategoryCommand(
    string Name,
    string Description,
    Guid CreatedByIdUser) : ICommand<Id>;