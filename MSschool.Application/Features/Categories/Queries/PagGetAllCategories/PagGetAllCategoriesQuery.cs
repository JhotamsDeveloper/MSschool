using MSschool.Application.Abstractions;
using MSschool.Application.Domain.Shared.Pagination;
using MSschool.Application.Features.Categories.Queries.GetAllCategories;

namespace MSschool.Application.Features.Categories.Queries.PagGetAllCategories;

public class PagGetAllCategoriesQuery : PaginationBaseQuery, ICommand<PaginationResponse<PagGetAllCategoriesResponse>>
{

}
