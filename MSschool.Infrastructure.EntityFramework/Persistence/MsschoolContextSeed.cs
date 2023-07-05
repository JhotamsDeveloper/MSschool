using MSschool.Application.Domain.Common;
using MSschool.Application.Domain.Models.Categories;

namespace MSschool.Infrastructure.EntityFramework.Persistence;

internal static class MsschoolContextSeed
{
    internal static IEnumerable<Category> PreloadedCategories()
    {
        return new Category[]
        {
            new Category(new Id(Guid.NewGuid()), "Docente", "Persona que presta los servicios de docencia a la institución."),
            new Category(new Id(Guid.NewGuid()), "Estudiante", "Persona que se encuentra estudiando a la institución."),
        };
    } 
}
