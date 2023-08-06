using MSschool.Application.Domain.Common;

namespace MSschool.Application.Domain.Models.Geolocation;

public class Colombia : Audit
{
    public Colombia(Id id, string region, int departmentCode, string department, int cityCode, string city) : base(id)
    {
        Region = region;
        DepartmentCode = departmentCode;
        Department = department;
        CityCode = cityCode;
        City = city;
    }

    public string Region { get; private set; } = string.Empty;
    public int DepartmentCode { get; private set; }
    public string Department { get; private set; } = string.Empty;
    public int CityCode { get; private set; }
    public string City { get; private set; } = string.Empty;
}
