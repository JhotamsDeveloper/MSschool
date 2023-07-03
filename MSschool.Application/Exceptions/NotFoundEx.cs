namespace MSschool.Application.Exceptions;

public class NotFoundEx : ApplicationException
{
    public NotFoundEx(string name, object key) : base($"Entity \"{name}\" ({key}) no fue encontrado")
    {

    }
}
