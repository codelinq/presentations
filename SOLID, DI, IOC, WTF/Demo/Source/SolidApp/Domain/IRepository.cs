using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace SolidApp.Domain
{
    public interface IRepository<T>
    {
        IQueryable<T> Find(Expression<Func<T, bool>> query);
    }
}
