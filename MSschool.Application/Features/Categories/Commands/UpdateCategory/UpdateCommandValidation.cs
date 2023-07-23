using FluentValidation;

namespace MSschool.Application.Features.Categories.Commands.UpdateCategory;

public class UpdateCommandValidation : AbstractValidator<UpdateCategoryCommand>
{
    public UpdateCommandValidation()
    {
        RuleFor(r => r.Id)
            .NotEmpty().WithMessage("No ha ingresado el id de la categoria");

        RuleFor(r => r.Name)
            .NotEmpty().WithMessage("No ha ingresado el nombre de la categoria")
            .Length(2, 50).WithMessage("La categoria tiene {TotalLength} caracteres, Debe tener una longitud entre {MinLength} y {MaxLength} carateres.");
    }
}
