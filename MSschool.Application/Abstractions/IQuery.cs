using MediatR;

namespace MSschool.Application.Abstractions;

public interface IQuery<TResponse> : IRequest<TResponse>
{
}