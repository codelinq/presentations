using System;
using System.Data;

namespace Solid.Demo.SRP.Better
{
    public class Repository<T>
    {
        private readonly DBContext _dbContext;

        public Repository(DBContext context)
        {
            _dbContext = context;
        }

        public void Add(T item)
        {
            var command = GetCreateCommand(item);
            _dbContext.ExecuteNonQuery(command);
        }

        public T FetchById(Guid id)
        {
            var command = GetFetchCommand(id);
            var result = default(T);
            using (var reader = _dbContext.ExecuteReader(command))
            {
                if (reader.Read())
                {
                    result = Activator.CreateInstance<T>();
                    foreach (var property in result.GetType().GetProperties())
                    {
                        var index = reader.GetOrdinal(property.Name);
                        property.SetValue(result, reader.GetValue(index), null);
                    }
                }
            }

            return result;
        }

        private IDbCommand GetFetchCommand(Guid id)
        {
            var visitor = new SqlSelectVisitor<T>(id);
            return _dbContext.CreateCommand(visitor.Query);
        }

        private IDbCommand GetCreateCommand(T item)
        {
            var visitor = new SqlInsertVisitor<T>();
            visitor.Visit(item);

            return _dbContext.CreateCommand(visitor.Query);
        }
    }
}
