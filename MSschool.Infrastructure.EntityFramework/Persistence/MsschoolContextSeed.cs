using MSschool.Application.Domain;

namespace MSschool.Infrastructure.EntityFramework.Persistence;

internal static class MsschoolContextSeed
{
    internal static IEnumerable<Category> PreloadedCategories()
    {
        return new Category[]
        {
            new Category()
            {
                Id= Guid.NewGuid(),
                Name= "Docente",
                Description= "Persona que presta los servicios de docencia a la institución.",
            },
            new Category()
            {
                Id= Guid.NewGuid(),
                Name= "Estudiante",
                Description= "Persona que se encuentra estudiando a la institución.",
            }
        };
    } 
}
