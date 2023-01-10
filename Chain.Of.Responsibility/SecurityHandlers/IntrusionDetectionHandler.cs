namespace Chain.Of.Responsibility.SecurityHandlers;

public class IntrusionDetectionHandler : SecurityHandler
{
    public IntrusionDetectionHandler(SecurityHandler? handler) : base(handler)
    {
    }

    public override void HandleRequest(string request)
    {
        if (request.Contains("intrusion", StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("[Intrusion: HandleRequest]");
        else
            next?.HandleRequest(request);
    }
}