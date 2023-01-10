namespace Command.Pattern.Commands;

public class BackupCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("[BackupCommand: Execute]");
    }
}