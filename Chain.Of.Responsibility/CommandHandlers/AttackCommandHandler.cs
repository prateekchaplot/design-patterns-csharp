namespace Chain.Of.Responsibility.CommandHandlers;

public class AttackCommandHandler : CommandHandler
{
    public AttackCommandHandler(CommandHandler? successor) : base(successor)
    {
    }

    public override void Handle(Command command)
    {
        if (command.Action == "attack")
            Console.WriteLine($"You attack the {command.Target}.");
        else
            PassToSuccessor(command);
    }
}