using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.Models
{
    public class StudentAbsenceSingleModel
    {
        public string User_Id { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public int status { get; set; }
        public DateTime abs_datetime { get; set; }
        public int justification_ID { get; set; }
        public int abs_Id { get; set; }
    }
}
