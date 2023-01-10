namespace Chain.Of.Responsibility;

public abstract class ActionHandler
{
    private readonly ActionHandler? _successor;

    public ActionHandler(ActionHandler? successor)
    {
        _successor = successor;
    }

    public abstract void Handle(Action command);

    protected void PassToSuccessor(Action command)
    {
        if (_successor != null)
            _successor.Handle(command);
        else
            Console.WriteLine("Invalid command");
        
    }
}