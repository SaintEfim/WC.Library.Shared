using System.Net;

namespace WC.Library.Shared.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException()
    {
    }

    public NotFoundException(string message) : base(message)
    {
    }

    public string Title = "User Not Found";
    public int StatusCode = (int)HttpStatusCode.NotFound;
}