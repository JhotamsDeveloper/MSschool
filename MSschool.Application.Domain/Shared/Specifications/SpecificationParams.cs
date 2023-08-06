namespace MSschool.Application.Domain.Shared.Specifications;

public abstract class SpecificationParams
{
    private const int maxPageSize = 50;
    private int pageSize = 3;

    public string? Sort { get; set; }
    public string? Search { get; set; }
    public int PageIndex { get; set; } = 1;
    public bool DisableGlobalFilters { get; set; }
    public int PageSize
    {
        get => pageSize;
        set => pageSize = value > maxPageSize ? maxPageSize : value;
    }
}
