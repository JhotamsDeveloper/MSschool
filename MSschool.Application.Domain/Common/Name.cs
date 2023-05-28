namespace MSschool.Application.Domain.Common;

public record Name(string Value)
{
    private const StringComparison ordinalIgnoreCase = StringComparison.OrdinalIgnoreCase;

    public static bool Equals(string value, string expectation)
    {
        return string
            .Equals(value, expectation, ordinalIgnoreCase);
    }
}
