namespace MSschool.Application.Domain.Shared.Pagination;

public class PaginationResponse<T> where T : class
{
    public int Count { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public IReadOnlyList<T> Data { get; set; } = default!;
    public int PageCount { get; set; }
}
