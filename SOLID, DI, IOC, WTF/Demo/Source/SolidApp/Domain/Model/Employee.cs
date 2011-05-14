using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolidApp.Domain
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string EmailAddress { get; set; }
    }
}
