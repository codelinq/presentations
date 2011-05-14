using System;
using System.Collections.Generic;

namespace SolidApp.Domain
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> EmployeesBornOn(DateTime dayOfBirth);
    }
}
