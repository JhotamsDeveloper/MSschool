using MSschool.Application.Abstractions;

namespace MSschool.Application.Features.ApplicationUsers.Command.AddUserAddresses;

public record AddUserAddressesCommand(
    Guid IdUser,
    string Country, 
    string CountryCode, 
    string Department, 
    string DepartmentCode, 
    string City, 
    string CityCode,
    string Direction):ICommand;
