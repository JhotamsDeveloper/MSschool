using MSschool.Infrastructure.EntityFramework.Repositories;
using NetArchTest.Rules;
using Xunit;

namespace MSschool.Test.Arquitecture;

public class CleanArchitectureRulesTest
{
    [Fact]
    public void ServiceClassesShouldHaveNameEndingWithServicex()
    {
        //var types = Types.InAssembly(typeof(UnitOfWorkService).Assembly);
        //var isValid = types
        //    .That()
        //    .ResideInNamespace("MSschool.Infrastructure.EntityFramework.Repositories")
        //    .Should()
        //    .BeSealed()
        //    .GetResult()
        //    .IsSuccessful;

        //Assert.True(isValid);
    }

    [Fact]
    public void ServiceClassesShouldHaveNameEndingWithService()
    {
        var result = Types.InCurrentDomain()
                     .That()
                     .ResideInNamespace(("MSschool.Infrastructure.EntityFramework.Services"))
                     .And()
                     .AreClasses()
                     .Should().HaveNameEndingWith("Service")
                     .GetResult();
        Assert.True(result.IsSuccessful);
    }

    //Las clases de servicio deben ser públicas y selladas
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
