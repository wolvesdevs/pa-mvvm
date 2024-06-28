namespace AndersonMvvm.Exceptions;
public sealed class InputException : ExceptionBase
{
    public override MessageKind MessageKind => MessageKind.Information;

    public InputException(string message) : base(message) { }
}
