using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.Models
{
    public class AllRequestsModel
    {
        public string fullName { get; set; }
        public int student_ID { get; set; }

        public DateTime abs_datetime { get; set; }
        public string raport { get; set; }

        public string status { get; set; }

        public string reason_name { get; set; }

    }
}
