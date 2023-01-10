namespace Chain.Of.Responsibility;

public abstract class CommandHandler
{
    private readonly CommandHandler? _successor;

    public CommandHandler(CommandHandler? successor)
    {
        _successor = successor;
    }

    public abstract void Handle(Command command);

    protected void PassToSuccessor(Command command)
    {
        if (_successor != null)
            _successor.Handle(command);
        else
            Console.WriteLine("Invalid command");
        
    }
}