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

    public bool Contains(string contain)
    {
        return Value.Contains(contain);
    }
}
