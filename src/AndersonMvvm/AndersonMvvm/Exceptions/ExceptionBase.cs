namespace AndersonMvvm.Exceptions;
public abstract class ExceptionBase : Exception
{
    public abstract MessageKind MessageKind { get; }

    protected ExceptionBase(string message) : base(message) { }
}

public enum MessageKind
{
    Information,
    Warning,
    Error
}
