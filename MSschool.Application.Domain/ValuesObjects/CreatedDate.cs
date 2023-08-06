using MSschool.Application.Domain.Helpers;

namespace MSschool.Application.Domain.ValuesObjects;

public record CreatedDate
{
    private CreatedDate(DateTime value) =>
        Value = value;

    public DateTime Value { get; private set; }

    public static CreatedDate CreationDate()
    {
        var date = DateTimeHelper.GetDateAndTime();
        return new CreatedDate(date.DateTime);
    }
};