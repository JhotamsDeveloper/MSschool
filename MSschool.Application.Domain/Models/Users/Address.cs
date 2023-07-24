namespace MSschool.Application.Domain.Models.Users;

public class Address
{
    public Address(
        string country, 
        string countryCode, 
        string department, 
        string departmentCode, 
        string city, 
        string cityCode, 
        string direction)
    {
        Country = country;
        CountryCode = countryCode;
        Department = department;
        DepartmentCode = departmentCode;
        City = city;
        CityCode = cityCode;
        Direction = direction;
    }

    public string Country { get; private set; } = string.Empty;
    public string CountryCode { get; private set; } = string.Empty;
    public string Department { get; private set; } = string.Empty;
    public string DepartmentCode { get; private set; } = string.Empty;
    public string City { get; private set; } = string.Empty;
    public string CityCode { get; private set; } = string.Empty;
    public string Direction { get; private set; } = string.Empty;
}
