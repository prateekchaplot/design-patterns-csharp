using Chain.Of.Responsibility;
using Chain.Of.Responsibility.CommandHandlers;

CommandHandler attackHandler = new AttackCommandHandler(null);
CommandHandler pickUpHandler = new PickUpCommandHandler(attackHandler);
CommandHandler moveHandler = new MoveCommandHandler(pickUpHandler);

var commands = new List<Command>
{
    new Command { Action = "go", Target = "north" },
    new Command { Action = "pick up", Target = "sword" },
    new Command { Action = "attack", Target = "goblin" }
};

foreach (var command in commands)
    moveHandler.Handle(command);
