using FluentValidation;

namespace MSschool.Application.Features.Categories.Commands.CreateCategory;

public class CreateCategoryCommandValidation : AbstractValidator<CreateCategoryCommand>
{
    public CreateCategoryCommandValidation()
    {
        RuleFor(r => r.Name)
            .NotEmpty().WithMessage("No ha ingresado el nombre de la categoria")
            .Length(2, 50).WithMessage("La categoria tiene {TotalLength} caracteres, Debe tener una longitud entre {MinLength} y {MaxLength} carateres.");
    }
}
