using MediatR;

namespace MSschool.Application.Abstractions;

public interface ICommand : IRequest
{
}

public interface ICommand<TResponse> : IRequest<TResponse>
{
}
