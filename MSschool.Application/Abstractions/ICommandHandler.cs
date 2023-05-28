using MediatR;

namespace MSschool.Application.Abstracions;

public interface ICommandHandler<TCommnd> : IRequestHandler<TCommnd> where TCommnd : ICommand
{
}

public interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
{
}