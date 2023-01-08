namespace Adapter.Pattern.Database;

public class MySqlDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("[MySqlDatabase: Connect]");
    }

    public void Disconnect()
    {
        Console.WriteLine("[MySqlDatabase: Disconnect]");
    }

    public string[] ExecuteQuery(string query)
    {
        Console.WriteLine("[MySqlDatabase: ExecuteQuery]");
        return Array.Empty<string>();
    }
}