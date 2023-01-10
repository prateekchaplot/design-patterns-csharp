namespace Chain.Of.Responsibility.CommandHandlers;

public class PickUpCommandHandler : CommandHandler
{
    public PickUpCommandHandler(CommandHandler? successor) : base(successor)
    {
    }

    public override void Handle(Command command)
    {
        if (command.Action == "pick up")
            Console.WriteLine($"You pick up the {command.Target}.");
        else
            PassToSuccessor(command);
        
    }
}