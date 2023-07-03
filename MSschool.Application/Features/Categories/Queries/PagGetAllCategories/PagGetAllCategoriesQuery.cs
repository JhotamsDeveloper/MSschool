using MSschool.Application.Abstractions;
using MSschool.Application.Domain.Shared.Pagination;

namespace MSschool.Application.Features.Categories.Queries.PagGetAllCategories;

public class PagGetAllCategoriesQuery : PaginationBaseQuery, ICommand<PaginationResponse<PagGetAllCategoriesResponse>>
{
}
