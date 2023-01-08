namespace Adapter.Pattern.Database;

public class CassandraDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("[CassandraDatabase: Connect]");
    }

    public void Disconnect()
    {
        Console.WriteLine("[CassandraDatabase: Disconnect]");
    }

    public string[] ExecuteQuery(string query)
    {
        Console.WriteLine("[CassandraDatabase: ExecuteQuery]");
        return Array.Empty<string>();
    }
}