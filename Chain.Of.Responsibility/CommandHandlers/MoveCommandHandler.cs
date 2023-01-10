namespace Chain.Of.Responsibility.CommandHandlers;

public class MoveCommandHandler : CommandHandler
{
    public MoveCommandHandler(CommandHandler? successor) : base(successor)
    {
    }

    public override void Handle(Command command)
    {
        if (command.Action == "go")
        {
            string message;
            switch (command.Target)
            {
                case "north":
                    message = "You move one step north";
                    break;

                case "south":
                    message = "You move one step south";
                    break;

                case "east":
                    message = "You move one step east";
                    break;

                case "west":
                    message = "You move one step west";
                    break;

                default:
                    throw new Exception("Move target not handled");
            }

            Console.WriteLine(message);
        }
        else
            PassToSuccessor(command);
    }
}