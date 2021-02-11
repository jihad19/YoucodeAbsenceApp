using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.Models
{
    public class StudentRequestModel
    {
        public string User_Id { get; set; }
        public string fullName { get; set; }
        public DateTime jus_datetime { get; set; }
        public int justification_ID { get; set; }
        public int jus_type { get; set; }
        public int abs_Id { get; set; }
    }
}
