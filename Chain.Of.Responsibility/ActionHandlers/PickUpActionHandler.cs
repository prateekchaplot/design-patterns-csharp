namespace Chain.Of.Responsibility.ActionHandlers;

public class PickUpActionHandler : ActionHandler
{
    public PickUpActionHandler(ActionHandler? successor) : base(successor)
    {
    }

    public override void Handle(Action command)
    {
        if (command.Type == "pick up")
            Console.WriteLine($"You pick up the {command.Target}.");
        else
            PassToSuccessor(command);
        
    }
}