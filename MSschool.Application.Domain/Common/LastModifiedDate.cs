using MSschool.Application.Domain.Helpers;

namespace MSschool.Application.Domain.Common;

public record LastModifiedDate
{
    private LastModifiedDate(DateTime value) =>
        Value = value;

    public DateTime Value { get; init; }

    public static LastModifiedDate CreationDate()
    {
        var date = DateTimeHelper.GetDateAndTime();
        return new LastModifiedDate(date.DateTime);
    }
}
