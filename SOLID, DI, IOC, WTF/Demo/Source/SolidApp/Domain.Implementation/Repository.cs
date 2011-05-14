using System;
using System.Linq;

using SolidApp.Domain;

namespace SolidApp.Implementation
{
    public class Repository<T> : IRepository<T>
    {
        private readonly IDataContext _context;

        public Repository(IDataContext context)
        {
            _context = context;
        }

        public IQueryable<T> All
        {
            get { return _context.GetDataStore<T>(); }
        }

        public IQueryable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> query)
        {
            return All.Where(query);
        }
    }
}
