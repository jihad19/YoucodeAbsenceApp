using System;
using System.Collections.Generic;
using System.Text;

namespace DemoData.Models
{
    public class RequestsModel
    {
        public int reqid { get; set; }
        public string type { get; set; }
        public bool status { get; set; }
        public DateTime date { get; set; }
        public string description { get; set; }
    }
}
