using System.Data;

namespace Solid.Demo.SRP.Better
{
    public class DBContext
    {
        public string ConnectionString { get; set; }

        public IDbCommand CreateCommand(string sql)
        {
            return null;
        }

        public void ExecuteNonQuery(IDbCommand command)
        {
            //execute query
        }

        public IDataReader ExecuteReader(IDbCommand command)
        {
            return null;
        }
    }
}
