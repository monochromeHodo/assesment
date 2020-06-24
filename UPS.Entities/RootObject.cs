using System;
using System.Collections.Generic;
using System.Text;

namespace UPS.Entities
{
    public class Rootobject
    {
        public Meta _meta { get; set; }
        public IEnumerable<Employee> result { get; set; }
    }
}
