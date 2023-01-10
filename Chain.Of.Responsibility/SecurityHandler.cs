namespace Chain.Of.Responsibility;

public abstract class SecurityHandler
{
    protected readonly SecurityHandler? next;

    public SecurityHandler(SecurityHandler? handler)
    {
        next = handler;
    }

    public abstract void HandleRequest(string request);
}