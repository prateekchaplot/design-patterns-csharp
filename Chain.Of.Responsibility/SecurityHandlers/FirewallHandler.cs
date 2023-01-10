namespace Chain.Of.Responsibility.SecurityHandlers;

public class FirewallHandler : SecurityHandler
{
    public FirewallHandler(SecurityHandler? handler) : base(handler)
    {
    }

    public override void HandleRequest(string request)
    {
        if (request.Contains("firewall", StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("[Firewall: HandleRequest]");
        else
            next?.HandleRequest(request);
    }
}