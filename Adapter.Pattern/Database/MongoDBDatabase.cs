namespace Adapter.Pattern.Database;

public class MongoDBDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("[MongoDBDatabase: Connect]");
    }

    public void Disconnect()
    {
        Console.WriteLine("[MongoDBDatabase: Disconnect]");
    }

    public string[] ExecuteQuery(string query)
    {
        Console.WriteLine("[MongoDBDatabase: ExecuteQuery]");
        return Array.Empty<string>();
    }
}