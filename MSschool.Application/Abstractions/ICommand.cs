using MediatR;

namespace MSschool.Application.Abstracions;

public interface ICommand : IRequest
{
}

public interface ICommand<TResponse> : IRequest<TResponse>
{
}
