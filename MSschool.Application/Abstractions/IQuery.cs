using MediatR;

namespace MSschool.Application.Abstracions;

public interface IQuery<TResponse> : IRequest<TResponse>
{
}