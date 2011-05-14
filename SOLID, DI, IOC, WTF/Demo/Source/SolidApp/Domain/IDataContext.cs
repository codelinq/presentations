using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidApp.Domain
{
    public interface IDataContext
    {
        IQueryable<T> GetDataStore<T>() where T : class ; 
    }
}
