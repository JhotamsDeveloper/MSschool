using Microsoft.Extensions.Logging;
using MSschool.Application.Abstractions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Users;
using MSschool.Application.Exceptions;
using System.Linq.Expressions;

namespace MSschool.Application.Features.ApplicationUsers.Command.CreateUser;

public sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, Id>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<CreateUserCommandHandler> _logger;

    public CreateUserCommandHandler(IUnitOfWork unitOfWork, ILogger<CreateUserCommandHandler> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<Id> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var existUser = await _unitOfWork.Repository<User>().Exitst(ValidatedUser(request));
        if (existUser)
        {
            _logger.LogWarning("El {@user}, {@request} ya existe", nameof(User), request);
            throw new BadRequestEx($"La {nameof(User)} ya existe");
        }

        var user = new User(new Id(Guid.NewGuid()), request.FirstName, request.SecondName, request.Surname,
            request.SecondSurname, request.DocumentType.ToString(), request.DocumentNumber, request.Email, request.Phone,
            request.Birthdate, request.CellPhone);

        await _unitOfWork.Repository<User>().AddAsync(user);
        return user.Id;
    }

    private static Expression<Func<User, bool>> ValidatedUser(CreateUserCommand request) =>
        user =>
        user.DocumentType == request.DocumentType.ToString() &&
        user.DocumentNumber == request.DocumentNumber;
}
