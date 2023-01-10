namespace Chain.Of.Responsibility.ActionHandlers;

public class AttackActionHandler : ActionHandler
{
    public AttackActionHandler(ActionHandler? successor) : base(successor)
    {
    }

    public override void Handle(Action command)
    {
        if (command.Type == "attack")
            Console.WriteLine($"You attack the {command.Target}.");
        else
            PassToSuccessor(command);
    }
}