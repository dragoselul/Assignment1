namespace Domain.Exceptions;

public class UserException :Exception
{
    public string UserName { get; }
    public UserException() { }

    public UserException(string message)
        : base(message) { }

    public UserException(string message, Exception inner)
        : base(message, inner) { }
    public UserException(string message, string userName)
        : this(message)
    {
        UserName = userName;
    }
}