using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidApp.Domain;

namespace SolidApp.Implementation
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IDataContext context) : base(context) {}

        public IEnumerable<Employee> EmployeesBornOn(DateTime dayOfBirth)
        {
            return Find(e => e.DateOfBirth.Date == dayOfBirth.Date);
        }
    }
}
