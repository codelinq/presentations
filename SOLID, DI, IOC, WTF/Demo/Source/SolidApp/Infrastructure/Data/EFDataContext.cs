using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidApp.Domain;
using System.Data.Objects;

namespace SolidApp.Infrastructure.Data
{
    public class EFDataContext : IDataContext
    {
        private readonly ObjectContext _objectContext;

        public EFDataContext(ObjectContext objectContext)
        {
            _objectContext = objectContext;
        }

        public IQueryable<T> GetDataStore<T>() where T: class 
        {
            return _objectContext.CreateObjectSet<T>();
        }
    }
}
