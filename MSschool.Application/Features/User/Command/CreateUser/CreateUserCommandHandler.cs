using MSschool.Application.Abstractions;
using MSschool.Application.Domain.Common;

namespace MSschool.Application.Features.User.Command.CreateUser;

public sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, Id>
{
    public Task<Id> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
