namespace Command.Pattern;

public class TaskScheduler
{
    private readonly List<ICommand> _commands;

    public TaskScheduler()
    {
        _commands = new List<ICommand>();
    }

    public void AddCommand(ICommand command)
    {
        _commands.Add(command);
    }

    public void Run()
    {
        foreach (var command in _commands)
            command.Execute();
    }
}