using Adapter.Pattern;
using Adapter.Pattern.Database;

IDatabase database = new MySqlDatabase();
database.Connect();
string[] results = database.ExecuteQuery("SELECT * FROM users");
database.Disconnect();
