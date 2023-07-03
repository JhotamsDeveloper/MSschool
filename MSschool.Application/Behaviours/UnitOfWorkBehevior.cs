using MediatR;
using MSschool.Application.Contracts.Persistence;
using System.Transactions;

namespace MSschool.Application.Behaviours;

public sealed class UnitOfWorkBehevior<TRequest, TResponse> :
    IPipelineBehavior<TRequest, TResponse> where TRequest : notnull
{
    private readonly IUnitOfWork _unitOfWork;

    public UnitOfWorkBehevior(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (IsNotCommand())
        {
            return await next();
        }

        try
        {
            using var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
            var response = await next();
            var saveChangesAsync = await _unitOfWork.SaveChangesAsync();
            transactionScope.Complete();
            return response;
        }
        catch (Exception)
        {
            throw;
        }
    }

    private static bool IsNotCommand()
    {
        return !typeof(TRequest).Name.EndsWith("Command");
    }
}
