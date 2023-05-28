using MediatR;

namespace MSschool.Application.Abstracions;
public interface IQueryHandler<TQuery, TResponse> : 
    IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
{
}