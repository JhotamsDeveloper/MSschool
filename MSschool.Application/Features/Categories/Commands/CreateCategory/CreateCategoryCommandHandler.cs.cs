using MSschool.Application.Abstracions;
using MSschool.Application.Constants;
using MSschool.Application.Contracts.Persistence;
using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;
using MSschool.Application.Domain.Models.Institutions;
using System.Transactions;

namespace MSschool.Application.Features.Categories.Commands.CreateCategory;

public class CreateCategoryCommandHandler : ICommandHandler<CreateCategoryCommand, Id>
{
    private readonly IUnitOfWork _unitOfWork;

    public CreateCategoryCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Id> Handle(
        CreateCategoryCommand request,
        CancellationToken cancellationToken)
    {
        var existCategory = await _unitOfWork
            .Repository<Category>()
            .Exitst(e => e.Name!.Equals(new Name(request.Name)));

        if (existCategory)
            throw new Exception(
                "La categoria que esta intando registrar ya existe");

        var category = new Category(
            new Id(Guid.NewGuid()),
            new Name(request.Name),
            request.Description,
            new Id(Guid.Empty));

        await _unitOfWork
            .Repository<Category>()
            .AddAsync(category);

        await _unitOfWork
            .Repository<Institution>()
            .AddAsync(new Institution(
                new Id(Guid.NewGuid()),
                new Name("TECOC"),
                "Jhotams@tecoc.educ.co",
                "Antioquia",
                "57",
                "Santa Fe de Antioquia",
                "0750501246787444578785",
                "Llano de bolivar",
                new Id(Guid.NewGuid())));

        

        //using (var transactionScope = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
        //{


        //    if (result.Equals(UnitOfWorkSaveChangesEnum.Failed))
        //        throw new Exception(
        //            "Error al guardar la categoria");


        //    transactionScope.Complete();
        //    return category.Id!;
        //}

        return category.Id!;
    }
}
