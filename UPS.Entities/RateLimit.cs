using System;
using System.Collections.Generic;
using System.Text;

namespace UPS.Entities
{
    public class Ratelimit
    {
        public int limit { get; set; }
        public int remaining { get; set; }
        public int reset { get; set; }
    }
}
