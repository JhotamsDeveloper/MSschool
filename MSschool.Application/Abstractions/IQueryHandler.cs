using MediatR;

namespace MSschool.Application.Abstractions;
public interface IQueryHandler<TQuery, TResponse> :
    IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
{
}