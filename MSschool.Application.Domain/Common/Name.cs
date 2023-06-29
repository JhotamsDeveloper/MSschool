namespace MSschool.Application.Domain.Common;

public record Name
{
    private const StringComparison ordinalIgnoreCase = StringComparison.OrdinalIgnoreCase;

    public Name(string value)
    {
        Value = value;
    }

    public string Value { get; init; }

    public static bool Equals(string value, string expectation)
    {
        return string
            .Equals(value, expectation, ordinalIgnoreCase);
    }

}
