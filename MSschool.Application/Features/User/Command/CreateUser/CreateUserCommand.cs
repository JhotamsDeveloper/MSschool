using MSschool.Application.Abstractions;
using MSschool.Application.Domain.Common;

namespace MSschool.Application.Features.User.Command.CreateUser;

public record CreateUserCommand(
    string FirstName,
    string SecondName,
    string Surname,
    string SecondSurname,
    int DocumentType,
    string DocumentNumber,
    string Email,
    string Phone,
    DateTime Birthdate,
    string CellPhone) : ICommand<Id>;