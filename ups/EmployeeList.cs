using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ups
{

    public class Rootobject
    {
        public _Meta _meta { get; set; }
        public IEnumerable<Result> result { get; set; }
    }

    public class _Meta
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

    public class Ratelimit
    {
        public int limit { get; set; }
        public int remaining { get; set; }
        public int reset { get; set; }
    }

    public class Result
    {
        public string id { get; set; }
        [DisplayName("First Name")]
        public string first_name { get; set; }
        [DisplayName("Last Name")]
        public string last_name { get; set; }
        [DisplayName("Gender")]
        public string gender { get; set; }
        public string dob { get; set; }
        [DisplayName("E-mail")]
        public string email { get; set; }
        [DisplayName("Phone")]
        public string phone { get; set; }
        [DisplayName("Website")]
        public string website { get; set; }
        [DisplayName("Adress")]
        public string address { get; set; }
        [DisplayName("Status")]
        public string status { get; set; }
        public _Links _links { get; set; }
    }

    public class _Links
    {
        public Self self { get; set; }
        public Edit edit { get; set; }
        public Avatar avatar { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Edit
    {
        public string href { get; set; }
    }

    public class Avatar
    {
        public string href { get; set; }
    }

}
