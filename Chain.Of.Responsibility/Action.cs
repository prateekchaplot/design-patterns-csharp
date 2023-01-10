namespace Chain.Of.Responsibility;

public class Action
{
    public string Type { get; set; } = string.Empty;
    public string Target { get; set; } = string.Empty;
}