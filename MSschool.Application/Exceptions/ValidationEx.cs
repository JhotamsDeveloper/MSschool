using FluentValidation.Results;

namespace MSschool.Application.Exceptions;

public class ValidationEx : ApplicationException
{
    public IDictionary<string, string[]> Errors { get; set; }

    public ValidationEx() : base("Se ha presentado uno o más errores de validación")
    {
        Errors = new Dictionary<string, string[]>();
    }

    public ValidationEx(IEnumerable<ValidationFailure> failures) : this()
    {
        Errors = failures
            .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
            .ToDictionary(
                failureGroup => failureGroup.Key, 
                failureGroup => failureGroup.ToArray());
    }
}
