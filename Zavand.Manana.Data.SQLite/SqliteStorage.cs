using System.Data.Common;
using System.Data.SQLite;

namespace Zavand.Manana.Data.SQLite;

public class SqliteStorage : Storage
{
    public override void ChangeDatabase(string databaseName)
    {
        throw new NotSupportedException();
    }

    protected override DbConnection CreateConnection()
    {
        return new SQLiteConnection(_connectionString);
    }

    protected override DbCommand CreateCommand()
    {
        return new SQLiteCommand();
    }

    protected override void AddParameter(DbParameterCollection parameters, string parameterName, object value)
    {
        ((SQLiteParameterCollection)parameters).AddWithValue(parameterName, value);
    }
}