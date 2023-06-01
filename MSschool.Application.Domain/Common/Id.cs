namespace MSschool.Application.Domain.Common;

public record Id(Guid? Value)
{
    public static bool Equals(Guid value, Guid expectation)
    {
        return Guid
            .Equals(value, expectation);
    }

}
