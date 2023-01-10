using Chain.Of.Responsibility;
using Chain.Of.Responsibility.SecurityHandlers;

SecurityHandler antivirusHandler = new AntivirusHandler(null);
SecurityHandler firewallHandler = new FirewallHandler(antivirusHandler);
SecurityHandler intrusionHandler = new IntrusionDetectionHandler(firewallHandler);

var securityAlerts = new List<string>
{
    "Firewall blocked a suspicious connection",
    "Intrusion detected from IP address 123.456.789",
    "Virus warning: Trojan.Badware found",
    "Nothing to report"
};

foreach (string alert in securityAlerts)
    intrusionHandler.HandleRequest(alert);
