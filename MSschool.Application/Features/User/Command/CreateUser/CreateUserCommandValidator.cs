using FluentValidation;

namespace MSschool.Application.Features.User.Command.CreateUser;

public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        
    }
}
