using System.Text.RegularExpressions;

namespace MSschool.Application.Domain.Common;

public record Name
{
    private const StringComparison ordinalIgnoreCase = StringComparison.OrdinalIgnoreCase;

    public Name(string value)
    {
        Value = value;
    }

    public string Value { get; init; }

    public static bool Contains(string value, string contain)
    {
        return value.Contains(contain);
    }
}
