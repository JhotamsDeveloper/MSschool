using MediatR;
using MSschool.Application.Domain.Common;

namespace MSschool.Application.Features.Commands.CreateCategory;

public record CreateCommand(
    string Name, 
    string Description,
    Guid DreatedByIdUser) : IRequest<Id>;