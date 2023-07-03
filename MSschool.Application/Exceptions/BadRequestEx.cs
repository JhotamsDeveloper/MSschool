namespace MSschool.Application.Exceptions;

public class BadRequestEx : ApplicationException
{
    public BadRequestEx(string? message) : base(message)
    {
    }
}
