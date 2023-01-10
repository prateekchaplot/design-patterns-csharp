namespace Chain.Of.Responsibility;

public class Command
{
    public string Action { get; set; } = string.Empty;
    public string Target { get; set; } = string.Empty;
}