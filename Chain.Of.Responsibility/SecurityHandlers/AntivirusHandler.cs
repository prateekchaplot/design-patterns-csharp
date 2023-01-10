namespace Chain.Of.Responsibility.SecurityHandlers;

public class AntivirusHandler : SecurityHandler
{
    public AntivirusHandler(SecurityHandler? handler) : base(handler)
    {
    }

    public override void HandleRequest(string request)
    {
        if (request.Contains("virus", StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("[Antivirus: HandleRequest]");
        else
            next?.HandleRequest(request);
    }
}