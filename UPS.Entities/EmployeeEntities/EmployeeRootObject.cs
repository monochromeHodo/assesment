using System;
using System.Collections.Generic;
using System.Text;

namespace UPS.Entities.EmployeeEntities
{
    public class EmployeeRootObject
    {
        public Meta _meta { get; set; }
        public IEnumerable<Employee> result { get; set; }
    }
}
