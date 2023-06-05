using NetArchTest.Rules;
using Xunit;

namespace MSschool.Test.Arquitecture;

public class CleanArchitectureRulesTest
{

    //Los nombres de las interfaces deben comenzar con una "I"
    [Fact]
    public void InterfaceNamesShouldStartWithAnI()
    {
        var result = Types.InCurrentDomain()
            .That().AreInterfaces()
            .Should()
            .HaveNameStartingWith("I")
            .GetResult();

        Assert.True(result.IsSuccessful);
    }

    //Las clases de servicio deben ser no públicas y selladas
    [Fact]
    public void ServiceClassesShouldSealed()
    {
        var result = Types.InCurrentDomain()
                    .That()
                    .ResideInNamespace(("MSschool.Infrastructure.EntityFramework.Repositories"))
                    .Should()
                    .NotBePublic()
                    .And()
                    .BeSealed()
                    .GetResult();
        Assert.True(result.IsSuccessful);
    }

}
