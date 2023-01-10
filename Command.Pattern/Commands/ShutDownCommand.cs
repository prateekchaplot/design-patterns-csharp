namespace Command.Pattern.Commands;

public class ShutDownCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("[ShutDownCommand: Execute]");
    }
}