namespace MSschool.Presentation.Api.Error;

public class CodeErrorException : CodeErrorResponse
{
    public object? Details { get; set; }
    public CodeErrorException(
        int statusCode, 
        string? message = null, 
        object? details = null) : 
        base(statusCode, message)
    {
        Details = details;
    }
}
