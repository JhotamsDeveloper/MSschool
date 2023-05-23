using NetArchTest.Rules;
using Xunit;

namespace MSschool.Test.Arquitecture;

public class CleanArchitectureRulesTest
{
    [Fact]
    public void La_capa_de_dominio_solo_debe_estar_referenciado_en_la_capa_de_aplicacion()
    {
        var result = Types
            .InCurrentDomain()
            .That()
            .ResideInNamespace("MSschool.Application.Domain")
            .ShouldNot()
            .HaveDependencyOnAny(
                "MSschool.Presentation.Api",
                "MSschool.Infrastructure.EntityFramework",
                "MSschool.Presentation.Endpoints")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }

    [Fact]
    public void La_capa_de_infrastructura_solo_debe_estar_referenciado_en_la_capa_de_aplicacion_y_en_la_API()
    {
        var result = Types
            .InCurrentDomain()
            .That()
            .ResideInNamespace("MSschool.Infrastructure.EntityFramework")
            .ShouldNot()
            .HaveDependencyOnAny(
                "MSschool.Presentation.Api",
                "MSschool.Presentation.Endpoints")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }
}
