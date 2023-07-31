using Microsoft.Extensions.Logging;
using MSschool.Application.Abstractions;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Users;
using MSschool.Application.Exceptions;

namespace MSschool.Application.Features.ApplicationUsers.Command.AddUserAddresses;

public sealed class AddUserAddressesCommandHandler : ICommandHandler<AddUserAddressesCommand>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<AddUserAddressesCommandHandler> _logger;

    public AddUserAddressesCommandHandler(IUnitOfWork unitOfWork, ILogger<AddUserAddressesCommandHandler> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task Handle(AddUserAddressesCommand request, CancellationToken cancellationToken)
    {
        var user = await _unitOfWork
            .Repository<User>()
            .GetByIdAsync(request.IdUser) ?? throw new BadRequestEx($"El id {request.IdUser} que intenta actualizar no existe");

        User.Factory.AddPlaceOfBirth(new Id(request.IdUser), user.FirstName, user.SecondName, user.Surname,
            user.Email, user.DocumentType, user.DocumentNumber, user.Email, user.Phone, user.Birthdate,
            user.CellPhone, request.Country, request.CountryCode, request.Department, request.DepartmentCode,
            request.City, request.CityCode, request.Direction, user.Availability,user.CreatedDate);

        await _unitOfWork
            .Repository<User>()
            .UpdateAsync(user);
    }
}
