using Chain.Of.Responsibility;
using Chain.Of.Responsibility.ActionHandlers;

ActionHandler attackHandler = new AttackActionHandler(null);
ActionHandler pickUpHandler = new PickUpActionHandler(attackHandler);
ActionHandler moveHandler = new MoveActionHandler(pickUpHandler);

var commands = new List<Chain.Of.Responsibility.Action>
{
    new Chain.Of.Responsibility.Action { Type = "go", Target = "north" },
    new Chain.Of.Responsibility.Action { Type = "pick up", Target = "sword" },
    new Chain.Of.Responsibility.Action { Type = "attack", Target = "goblin" }
};

foreach (var command in commands)
    moveHandler.Handle(command);
