namespace Adapter.Pattern;

public interface IDatabase
{
    void Connect();
    void Disconnect();
    string[] ExecuteQuery(string query);
}