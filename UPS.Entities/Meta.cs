using System;
using System.Collections.Generic;
using System.Text;

namespace UPS.Entities
{
    public class Meta
    {
        public bool success { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public int totalCount { get; set; }
        public int pageCount { get; set; }
        public int currentPage { get; set; }
        public int perPage { get; set; }
        public Ratelimit rateLimit { get; set; }
    }
}
