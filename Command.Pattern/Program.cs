using Command.Pattern.Commands;

var taskScheduler = new Command.Pattern.TaskScheduler();

taskScheduler.AddCommand(new BackupCommand());
taskScheduler.AddCommand(new ShutDownCommand());

taskScheduler.Run();
